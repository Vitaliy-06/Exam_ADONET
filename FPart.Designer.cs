namespace Exam_ADONET
{
	partial class FPart
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			textBox3 = new TextBox();
			label3 = new Label();
			textBox4 = new TextBox();
			label4 = new Label();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 32);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(211, 27);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(12, 99);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(211, 27);
			textBox2.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 76);
			label2.Name = "label2";
			label2.Size = new Size(45, 20);
			label2.TabIndex = 2;
			label2.Text = "Color";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(12, 172);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(211, 27);
			textBox3.TabIndex = 5;
			textBox3.TextChanged += textBox3_TextChanged;
			textBox3.KeyPress += textBox3_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 149);
			label3.Name = "label3";
			label3.Size = new Size(56, 20);
			label3.TabIndex = 4;
			label3.Text = "Weight";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(12, 247);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(211, 27);
			textBox4.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 224);
			label4.Name = "label4";
			label4.Size = new Size(34, 20);
			label4.TabIndex = 6;
			label4.Text = "City";
			// 
			// button1
			// 
			button1.Location = new Point(12, 296);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 8;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(129, 296);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 9;
			button2.Text = "CANCEL";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// FPart
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(256, 341);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox4);
			Controls.Add(label4);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "FPart";
			Text = "FPart";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private TextBox textBox3;
		private Label label3;
		private TextBox textBox4;
		private Label label4;
		private Button button1;
		private Button button2;
	}
}