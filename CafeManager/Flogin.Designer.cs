namespace CafeManager
{
	partial class formdangnhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdangnhap));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbdangnhap = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(2, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(389, 219);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = global::CafeManager.Properties.Resources.nencf;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.lbdangnhap);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(383, 212);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button3.Location = new System.Drawing.Point(256, 140);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(73, 25);
			this.button3.TabIndex = 11;
			this.button3.Text = "Thoát";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button4.Location = new System.Drawing.Point(164, 140);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(73, 25);
			this.button4.TabIndex = 10;
			this.button4.Text = "Đăng nhập";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(164, 97);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(165, 20);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(164, 50);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(165, 20);
			this.textBox4.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(54, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mật khẩu";
			// 
			// lbdangnhap
			// 
			this.lbdangnhap.AutoSize = true;
			this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbdangnhap.Location = new System.Drawing.Point(54, 50);
			this.lbdangnhap.Name = "lbdangnhap";
			this.lbdangnhap.Size = new System.Drawing.Size(104, 17);
			this.lbdangnhap.TabIndex = 6;
			this.lbdangnhap.Text = "Tên đăng nhập";
			this.lbdangnhap.BackColorChanged += new System.EventHandler(this.label4_BackColorChanged);
			this.lbdangnhap.Click += new System.EventHandler(this.label4_Click);
			// 
			// formdangnhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(392, 215);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "formdangnhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.formdangnhap_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbdangnhap;
	}
}

