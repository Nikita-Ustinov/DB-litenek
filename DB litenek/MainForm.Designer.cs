/*
 * Created by SharpDevelop.
 * User: Comp
 * Date: 09.01.2017
 * Time: 22:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DB_litenek
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(642, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 55);
			this.button1.TabIndex = 0;
			this.button1.Text = "Hledat";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(642, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(97, 55);
			this.button2.TabIndex = 1;
			this.button2.Text = "Pridat";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.maskedTextBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(577, 206);
			this.panel1.TabIndex = 2;
			this.panel1.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(26, 149);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(154, 34);
			this.button3.TabIndex = 11;
			this.button3.Text = "Pridat";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(186, 113);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(103, 20);
			this.textBox5.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(15, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(166, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Pocet volnych mist:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(316, 16);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(186, 65);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(103, 20);
			this.textBox3.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(186, 41);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(103, 20);
			this.textBox2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(125, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Cas:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(124, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Kam:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(107, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Odkud:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(186, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(103, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(15, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Letecká společnost: ";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(186, 88);
			this.maskedTextBox1.Mask = "90:00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(53, 20);
			this.maskedTextBox1.TabIndex = 12;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(739, 396);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "DB litenek";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
