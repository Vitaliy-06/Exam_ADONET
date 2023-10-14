using Exam_ADONET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_ADONET
{
	public partial class FPart : Form
	{
		public Part Part { get; private set; }

		public FPart()
		{
			InitializeComponent();
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Allow digits, decimal point, backspace, and negative sign
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
			{
				e.Handled = true; // Suppress the key press event
			}

			// Allow only one decimal point and one negative sign
			if ((e.KeyChar == '.' && (sender as TextBox).Text.Contains('.')) ||
				(e.KeyChar == '-' && (sender as TextBox).Text.Length > 0))
			{
				e.Handled = true; // Suppress the key press event
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBox1.Text) &&
				!string.IsNullOrEmpty(textBox2.Text) &&
				!string.IsNullOrEmpty(textBox3.Text) &&
				!string.IsNullOrEmpty(textBox4.Text))
			{
				Part = new Part
				{
					PNAME = textBox1.Text,
					COLOR = textBox2.Text,
					WEIGHT = double.Parse(textBox3.Text, CultureInfo.InvariantCulture),
					CITY = textBox4.Text
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

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			//if (!double.TryParse(textBox1.Text,  CultureInfo.InvariantCulture, out _))
			//{
			//	textBox3.BackColor = Color.LightSalmon; // Highlight the TextBox background
			//}
			//else
			//{
			//	textBox3.BackColor = SystemColors.Window; // Reset the TextBox background
			//}
		}
	}
}
