using Exam_ADONET.Models;
using Repository;

namespace Exam_ADONET
{
	public partial class FSPJ : Form
	{
		public SupplierPartProject SupplierPartProject { get; private set; }

		private AppDbContext dbContext;
		private GenericUnitOfWork work;

		public FSPJ()
		{
			dbContext = new AppDbContext();
			work = new GenericUnitOfWork(dbContext);

			InitializeComponent();
			InitializeComboBoxes();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
			{
				e.Handled = true; // Suppress the key press event
			}

			// Allow only one negative sign at the beginning
			if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
			{
				e.Handled = true; // Suppress the key press event
			}
		}

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void InitializeComboBoxes()
		{
			var suppliers = work.Repository<Supplier>().GetAll();
			var parts = work.Repository<Part>().GetAll();
			var projects = work.Repository<Project>().GetAll();

			foreach (var supplier in suppliers)
			{
				comboBox1.Items.Add(supplier.SNAME);
			}
			comboBox1.SelectedIndex = 0;

			foreach (var part in parts)
			{
				comboBox2.Items.Add(part.PNAME);
			}
			comboBox2.SelectedIndex = 0;

			foreach (var project in projects)
			{
				comboBox3.Items.Add(project.JNAME);
			}
			comboBox3.SelectedIndex = 0;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(comboBox1.Text) &&
				!string.IsNullOrEmpty(comboBox2.Text) &&
				!string.IsNullOrEmpty(comboBox3.Text) &&
				!string.IsNullOrEmpty(textBox1.Text))
			{
				SupplierPartProject = new SupplierPartProject
				{
					SupplierId = work.Repository<Supplier>().GetAll().FirstOrDefault(x => x.SNAME == comboBox1.Text).Id,
					PartId = work.Repository<Part>().GetAll().FirstOrDefault(x => x.PNAME == comboBox2.Text).Id,
					ProjectId = work.Repository<Project>().GetAll().FirstOrDefault(x => x.JNAME == comboBox3.Text).Id,
					QTY = int.Parse(textBox1.Text)
				};

				DialogResult = DialogResult.OK;
				Close();
				return;
			}
			DialogResult = DialogResult.Cancel;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
