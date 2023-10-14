namespace Exam_ADONET
{
	partial class FSPJ
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			label2 = new Label();
			comboBox3 = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			textBox1 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(64, 20);
			label1.TabIndex = 0;
			label1.Text = "Supplier";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(12, 40);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(211, 28);
			comboBox1.TabIndex = 1;
			comboBox1.KeyPress += comboBox2_KeyPress;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(12, 94);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(211, 28);
			comboBox2.TabIndex = 3;
			comboBox2.KeyPress += comboBox2_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 71);
			label2.Name = "label2";
			label2.Size = new Size(34, 20);
			label2.TabIndex = 2;
			label2.Text = "Part";
			// 
			// comboBox3
			// 
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(12, 148);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(211, 28);
			comboBox3.TabIndex = 5;
			comboBox3.KeyPress += comboBox2_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 125);
			label3.Name = "label3";
			label3.Size = new Size(55, 20);
			label3.TabIndex = 4;
			label3.Text = "Project";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 179);
			label4.Name = "label4";
			label4.Size = new Size(35, 20);
			label4.TabIndex = 6;
			label4.Text = "QTY";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 202);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(211, 27);
			textBox1.TabIndex = 7;
			textBox1.KeyPress += textBox1_KeyPress;
			// 
			// button2
			// 
			button2.Location = new Point(129, 252);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 19;
			button2.Text = "CANCEL";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(12, 252);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 18;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// FSPJ
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(241, 293);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(comboBox3);
			Controls.Add(label3);
			Controls.Add(comboBox2);
			Controls.Add(label2);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Name = "FSPJ";
			Text = "FSPJ";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Label label2;
		private ComboBox comboBox3;
		private Label label3;
		private Label label4;
		private TextBox textBox1;
		private Button button2;
		private Button button1;
	}
}