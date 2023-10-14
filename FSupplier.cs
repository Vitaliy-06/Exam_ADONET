using Exam_ADONET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_ADONET
{
	public partial class FSupplier : Form
	{
		public Supplier Supplier { get; private set; }

		public FSupplier()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox1.Text) &&
				!string.IsNullOrEmpty(textBox2.Text) &&
				!string.IsNullOrEmpty(textBox3.Text))
			{
				Supplier = new Supplier
				{
					SNAME = textBox1.Text,
					STATUS = textBox2.Text,
					CITY = textBox3.Text
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
