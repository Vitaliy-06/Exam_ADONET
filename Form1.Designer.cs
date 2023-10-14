namespace Exam_ADONET
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView1 = new DataGridView();
			comboBox1 = new ComboBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(630, 426);
			dataGridView1.TabIndex = 0;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(648, 12);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 1;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
			comboBox1.KeyPress += comboBox1_KeyPress;
			// 
			// button1
			// 
			button1.Location = new Point(648, 46);
			button1.Name = "button1";
			button1.Size = new Size(151, 29);
			button1.TabIndex = 2;
			button1.Text = "Add Part";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(648, 221);
			button2.Name = "button2";
			button2.Size = new Size(151, 29);
			button2.TabIndex = 3;
			button2.Text = "Delete";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(648, 186);
			button3.Name = "button3";
			button3.Size = new Size(151, 29);
			button3.TabIndex = 4;
			button3.Text = "Edit";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(648, 81);
			button4.Name = "button4";
			button4.Size = new Size(151, 29);
			button4.TabIndex = 5;
			button4.Text = "Add Project";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(648, 116);
			button5.Name = "button5";
			button5.Size = new Size(151, 29);
			button5.TabIndex = 6;
			button5.Text = "Add Supplier";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Location = new Point(648, 151);
			button6.Name = "button6";
			button6.Size = new Size(151, 29);
			button6.TabIndex = 7;
			button6.Text = "Add SPJ";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(comboBox1);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private ComboBox comboBox1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
	}
}