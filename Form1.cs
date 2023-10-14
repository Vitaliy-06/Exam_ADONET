using Exam_ADONET.Models;
using Repository;

namespace Exam_ADONET
{

	public enum Table
	{
		Part,
		Project,
		Supplier,
		SupplierPartProject
	}

	public partial class Form1 : Form
	{
		private AppDbContext dbContext;
		private GenericUnitOfWork work;

		private IGenericRepository<Part> partRepository;
		private IGenericRepository<Project> projectRepository;
		private IGenericRepository<Supplier> supplierRepository;
		private IGenericRepository<SupplierPartProject> supplierPartProjectRepository;

		private Table currentTable;

		public Form1()
		{
			dbContext = new AppDbContext();
			work = new GenericUnitOfWork(dbContext);

			partRepository = work.Repository<Part>();
			projectRepository = work.Repository<Project>();
			supplierRepository = work.Repository<Supplier>();
			supplierPartProjectRepository = work.Repository<SupplierPartProject>();

			InitializeComponent();
			CreateTestData();
			InitializeComboBox();
			InitializeDataGridView();

		}

		private void CreateTestData()
		{
			if (supplierPartProjectRepository.GetAll().Count() < 1)
			{
				partRepository.Add(new Part { CITY = "Lviv", COLOR = "Black", PNAME = "P1", WEIGHT = 25 });
				projectRepository.Add(new Project { CITY = "Lviv", DATE = new DateTime(2019, 6, 15), JNAME = "J1" });
				supplierRepository.Add(new Supplier { CITY = "Lviv", SNAME = "S1", STATUS = "CEO" });
				supplierPartProjectRepository.Add(new SupplierPartProject
				{
					PartId = partRepository.GetAll().FirstOrDefault(x => x.PNAME == "P1").Id,
					ProjectId = projectRepository.GetAll().FirstOrDefault(x => x.JNAME == "J1").Id,
					SupplierId = supplierRepository.GetAll().FirstOrDefault(x => x.SNAME == "S1").Id
				});
			}
		}

		private void InitializeDataGridView()
		{
			switch (currentTable)
			{
				case Table.Part:
					dataGridView1.DataSource = partRepository.GetAll();
					break;
				case Table.Project:
					dataGridView1.DataSource = projectRepository.GetAll();
					break;
				case Table.Supplier:
					dataGridView1.DataSource = supplierRepository.GetAll();
					break;
				case Table.SupplierPartProject:
					dataGridView1.DataSource = supplierPartProjectRepository.GetAll();
					dataGridView1.Columns["Project"].Visible = false;
					dataGridView1.Columns["Part"].Visible = false;
					dataGridView1.Columns["Supplier"].Visible = false;
					break;
			}
			dataGridView1.Columns["id"].Width = 50;
		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
		private void InitializeComboBox()
		{
			Table[] tables = (Table[])Enum.GetValues(typeof(Table));

			foreach (Table table in tables)
			{
				comboBox1.Items.Add(table.ToString());
			}

			comboBox1.SelectedIndex = 0;

			currentTable = (Table)comboBox1.SelectedIndex;
		}
		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			currentTable = (Table)comboBox1.SelectedIndex;
			InitializeDataGridView();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FPart form = new FPart();
			if (form.ShowDialog() == DialogResult.OK)
			{
				partRepository.Add(form.Part);
				InitializeDataGridView();
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int selectedId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
				switch (currentTable)
				{
					case Table.Part:
						FPart form = new FPart();
						if (form.ShowDialog() == DialogResult.OK)
						{
							var part = partRepository.FindById(selectedId);
							part.PNAME = form.Part.PNAME;
							part.COLOR = form.Part.COLOR;
							part.WEIGHT = form.Part.WEIGHT;
							part.CITY = form.Part.CITY;
							dbContext.SaveChanges();
							InitializeDataGridView();
						}
						break;
					case Table.Project:
						JForm formm = new JForm();
						if (formm.ShowDialog() == DialogResult.OK)
						{
							var project = projectRepository.FindById(selectedId);
							project.JNAME = formm.Project.JNAME;
							project.CITY = formm.Project.CITY;
							project.DATE = formm.Project.DATE;
							dbContext.SaveChanges();
							InitializeDataGridView();
						}
						break;
					case Table.Supplier:
						FSupplier fSupplier = new FSupplier();
						if(fSupplier.ShowDialog() == DialogResult.OK)
						{
							var supplier = supplierRepository.FindById(selectedId);
							supplier.SNAME = fSupplier.Supplier.SNAME;
							supplier.STATUS = fSupplier.Supplier.STATUS;
							supplier.CITY = fSupplier.Supplier.CITY;
							dbContext.SaveChanges();
							InitializeDataGridView();
						}
						break;
					case Table.SupplierPartProject:
						FSPJ fSPJ = new FSPJ();
						if(fSPJ.ShowDialog() == DialogResult.OK)
						{
							var spj = supplierPartProjectRepository.FindById(selectedId);
							spj.SupplierId = fSPJ.SupplierPartProject.SupplierId;
							spj.ProjectId = fSPJ.SupplierPartProject.ProjectId;
							spj.PartId = fSPJ.SupplierPartProject.PartId;
							spj.QTY = fSPJ.SupplierPartProject.QTY;
							dbContext.SaveChanges();
							InitializeDataGridView();
						}
						break;
				}
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int selectedId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
				switch (currentTable)
				{
					case Table.Part:
						var partToDelete = partRepository.GetAll().FirstOrDefault(x => x.Id == selectedId);
						if (supplierPartProjectRepository.GetAll().Any(x => x.PartId == selectedId))
						{
							MessageBox.Show("You cannot delete this row!");
							break;
						}
						partRepository.Remove(partToDelete);
						InitializeDataGridView();
						break;
					case Table.Project:
						var projectToDelete = projectRepository.GetAll().FirstOrDefault(x => x.Id == selectedId);
						if (supplierPartProjectRepository.GetAll().Any(x => x.ProjectId == selectedId))
						{
							MessageBox.Show("You cannot delete this row!");
							break;
						}
						projectRepository.Remove(projectToDelete);
						InitializeDataGridView();
						break;
					case Table.Supplier:
						var supplierToDelete = supplierRepository.GetAll().FirstOrDefault(x => x.Id == selectedId);
						if (supplierPartProjectRepository.GetAll().Any(x => x.SupplierId == selectedId))
						{
							MessageBox.Show("You cannot delete this row!");
							break;
						}
						supplierRepository.Remove(supplierToDelete);
						InitializeDataGridView();
						break;
					case Table.SupplierPartProject:
						var supplierPartProject = supplierPartProjectRepository.GetAll().FirstOrDefault(x => x.Id == selectedId);
						supplierPartProjectRepository.Remove(supplierPartProject);
						InitializeDataGridView();
						break;
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			JForm form = new JForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				projectRepository.Add(form.Project);
				InitializeDataGridView();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FSupplier form = new FSupplier();
			if (form.ShowDialog() == DialogResult.OK)
			{
				supplierRepository.Add(form.Supplier);
				InitializeDataGridView();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			FSPJ form = new FSPJ();
			if (form.ShowDialog() == DialogResult.OK)
			{
				supplierPartProjectRepository.Add(form.SupplierPartProject);
				InitializeDataGridView();
			}
		}
	}
}