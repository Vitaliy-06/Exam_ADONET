namespace Exam_ADONET
{
	partial class FSupplier
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
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			label3 = new Label();
			textBox2 = new TextBox();
			label2 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(140, 252);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 17;
			button2.Text = "CANCEL";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(23, 252);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 16;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(23, 185);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(211, 27);
			textBox3.TabIndex = 15;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 162);
			label3.Name = "label3";
			label3.Size = new Size(34, 20);
			label3.TabIndex = 14;
			label3.Text = "City";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(23, 112);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(211, 27);
			textBox2.TabIndex = 13;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 89);
			label2.Name = "label2";
			label2.Size = new Size(49, 20);
			label2.TabIndex = 12;
			label2.Text = "Status";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(23, 45);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(211, 27);
			textBox1.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 22);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 10;
			label1.Text = "Name";
			// 
			// FSupplier
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(256, 293);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "FSupplier";
			Text = "FSupplier";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private TextBox textBox3;
		private Label label3;
		private TextBox textBox2;
		private Label label2;
		private TextBox textBox1;
		private Label label1;
	}
}