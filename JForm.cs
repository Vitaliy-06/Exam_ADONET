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
	public partial class JForm : Form
	{
		public Project Project { get; private set; }

		public JForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox1.Text) &&
				!string.IsNullOrEmpty(textBox2.Text) &&
				!string.IsNullOrEmpty(dateTimePicker1.ToString()))
			{
				Project = new Project
				{
					JNAME = textBox1.Text,
					CITY = textBox2.Text,
					DATE = dateTimePicker1.Value
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
