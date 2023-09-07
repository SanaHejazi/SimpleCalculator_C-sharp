namespace Calculator
{
	partial class Form1
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
			this.numberone = new System.Windows.Forms.NumericUpDown();
			this.numbertow = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnplus = new System.Windows.Forms.Button();
			this.btnmine = new System.Windows.Forms.Button();
			this.btnmulti = new System.Windows.Forms.Button();
			this.btndiv = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numberone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numbertow)).BeginInit();
			this.SuspendLayout();
			// 
			// numberone
			// 
			this.numberone.Location = new System.Drawing.Point(253, 106);
			this.numberone.Name = "numberone";
			this.numberone.Size = new System.Drawing.Size(236, 26);
			this.numberone.TabIndex = 0;
			// 
			// numbertow
			// 
			this.numbertow.Location = new System.Drawing.Point(253, 188);
			this.numbertow.Name = "numbertow";
			this.numbertow.Size = new System.Drawing.Size(236, 26);
			this.numbertow.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(79, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 43);
			this.label1.TabIndex = 2;
			this.label1.Text = "Number 1:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(79, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 43);
			this.label2.TabIndex = 3;
			this.label2.Text = "Number 2:";
			// 
			// btnplus
			// 
			this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnplus.Location = new System.Drawing.Point(49, 300);
			this.btnplus.Name = "btnplus";
			this.btnplus.Size = new System.Drawing.Size(75, 68);
			this.btnplus.TabIndex = 4;
			this.btnplus.Text = "+";
			this.btnplus.UseVisualStyleBackColor = true;
			this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
			// 
			// btnmine
			// 
			this.btnmine.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmine.Location = new System.Drawing.Point(163, 300);
			this.btnmine.Name = "btnmine";
			this.btnmine.Size = new System.Drawing.Size(75, 68);
			this.btnmine.TabIndex = 5;
			this.btnmine.Text = "-";
			this.btnmine.UseVisualStyleBackColor = true;
			// 
			// btnmulti
			// 
			this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmulti.Location = new System.Drawing.Point(282, 300);
			this.btnmulti.Name = "btnmulti";
			this.btnmulti.Size = new System.Drawing.Size(75, 68);
			this.btnmulti.TabIndex = 6;
			this.btnmulti.Text = "X";
			this.btnmulti.UseVisualStyleBackColor = true;
			// 
			// btndiv
			// 
			this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndiv.Location = new System.Drawing.Point(398, 300);
			this.btndiv.Name = "btndiv";
			this.btndiv.Size = new System.Drawing.Size(75, 68);
			this.btndiv.TabIndex = 7;
			this.btndiv.Text = "/";
			this.btndiv.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(548, 414);
			this.Controls.Add(this.btndiv);
			this.Controls.Add(this.btnmulti);
			this.Controls.Add(this.btnmine);
			this.Controls.Add(this.btnplus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numbertow);
			this.Controls.Add(this.numberone);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numberone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numbertow)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numberone;
		private System.Windows.Forms.NumericUpDown numbertow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnplus;
		private System.Windows.Forms.Button btnmine;
		private System.Windows.Forms.Button btnmulti;
		private System.Windows.Forms.Button btndiv;
	}
}

