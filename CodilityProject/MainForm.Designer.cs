namespace CodilityProject
{
	partial class MainForm
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
			this.btnCalc = new System.Windows.Forms.Button();
			this.txtvalue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSonuc = new System.Windows.Forms.Label();
			this.btntrcalc = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblSonuc_TtoN = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDollarTtoN = new System.Windows.Forms.Button();
			this.btnTRTtoN = new System.Windows.Forms.Button();
			this.txtvalue_TtoN = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(236, 161);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(144, 44);
			this.btnCalc.TabIndex = 0;
			this.btnCalc.Text = "ÇEVİR ($)";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// txtvalue
			// 
			this.txtvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtvalue.Location = new System.Drawing.Point(236, 105);
			this.txtvalue.MaxLength = 15;
			this.txtvalue.Multiline = true;
			this.txtvalue.Name = "txtvalue";
			this.txtvalue.Size = new System.Drawing.Size(364, 33);
			this.txtvalue.TabIndex = 1;
			this.txtvalue.Text = "795384";
			this.txtvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalue_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(370, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "RAKAM GİRİNİZ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(398, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "SONUÇ";
			// 
			// lblSonuc
			// 
			this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSonuc.ForeColor = System.Drawing.Color.Red;
			this.lblSonuc.Location = new System.Drawing.Point(23, 282);
			this.lblSonuc.Name = "lblSonuc";
			this.lblSonuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblSonuc.Size = new System.Drawing.Size(807, 45);
			this.lblSonuc.TabIndex = 4;
			this.lblSonuc.Text = "-";
			this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btntrcalc
			// 
			this.btntrcalc.Location = new System.Drawing.Point(456, 161);
			this.btntrcalc.Name = "btntrcalc";
			this.btntrcalc.Size = new System.Drawing.Size(144, 44);
			this.btntrcalc.TabIndex = 5;
			this.btntrcalc.Text = "ÇEVİR (₺)";
			this.btntrcalc.UseVisualStyleBackColor = true;
			this.btntrcalc.Click += new System.EventHandler(this.btntrcalc_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.BlueViolet;
			this.label3.Location = new System.Drawing.Point(287, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(261, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "- RAKAMLARI YAZIYA ÇEVİR -";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Controls.Add(this.lblSonuc);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnCalc);
			this.groupBox1.Controls.Add(this.btntrcalc);
			this.groupBox1.Controls.Add(this.txtvalue);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(849, 344);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rakamları Yazıya Çevir";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox2.Controls.Add(this.lblSonuc_TtoN);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btnDollarTtoN);
			this.groupBox2.Controls.Add(this.btnTRTtoN);
			this.groupBox2.Controls.Add(this.txtvalue_TtoN);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 366);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(849, 344);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rakamları Yazıya Çevir";
			// 
			// lblSonuc_TtoN
			// 
			this.lblSonuc_TtoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSonuc_TtoN.ForeColor = System.Drawing.Color.Red;
			this.lblSonuc_TtoN.Location = new System.Drawing.Point(23, 282);
			this.lblSonuc_TtoN.Name = "lblSonuc_TtoN";
			this.lblSonuc_TtoN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblSonuc_TtoN.Size = new System.Drawing.Size(807, 45);
			this.lblSonuc_TtoN.TabIndex = 4;
			this.lblSonuc_TtoN.Text = "-";
			this.lblSonuc_TtoN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.BlueViolet;
			this.label5.Location = new System.Drawing.Point(287, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(226, 22);
			this.label5.TabIndex = 6;
			this.label5.Text = "- YAZIYI RAKAMA ÇEVİR -";
			// 
			// btnDollarTtoN
			// 
			this.btnDollarTtoN.Location = new System.Drawing.Point(222, 161);
			this.btnDollarTtoN.Name = "btnDollarTtoN";
			this.btnDollarTtoN.Size = new System.Drawing.Size(158, 44);
			this.btnDollarTtoN.TabIndex = 0;
			this.btnDollarTtoN.Text = "ÇEVİR ($) \"English\"";
			this.btnDollarTtoN.UseVisualStyleBackColor = true;
			this.btnDollarTtoN.Click += new System.EventHandler(this.btnDollarTtoN_Click);
			// 
			// btnTRTtoN
			// 
			this.btnTRTtoN.Location = new System.Drawing.Point(456, 161);
			this.btnTRTtoN.Name = "btnTRTtoN";
			this.btnTRTtoN.Size = new System.Drawing.Size(152, 44);
			this.btnTRTtoN.TabIndex = 5;
			this.btnTRTtoN.Text = "ÇEVİR (₺) \"Türkçe\"";
			this.btnTRTtoN.UseVisualStyleBackColor = true;
			this.btnTRTtoN.Click += new System.EventHandler(this.btnTRTtoN_Click);
			// 
			// txtvalue_TtoN
			// 
			this.txtvalue_TtoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtvalue_TtoN.Location = new System.Drawing.Point(23, 105);
			this.txtvalue_TtoN.MaxLength = 250;
			this.txtvalue_TtoN.Multiline = true;
			this.txtvalue_TtoN.Name = "txtvalue_TtoN";
			this.txtvalue_TtoN.Size = new System.Drawing.Size(804, 33);
			this.txtvalue_TtoN.TabIndex = 1;
			this.txtvalue_TtoN.Text = "seven hundred eighty five thousand four hundred eighty seven";
			this.txtvalue_TtoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(370, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "YAZI GİRİNİZ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(398, 245);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "SONUÇ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 722);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Converter";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.TextBox txtvalue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSonuc;
		private System.Windows.Forms.Button btntrcalc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblSonuc_TtoN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDollarTtoN;
		private System.Windows.Forms.Button btnTRTtoN;
		private System.Windows.Forms.TextBox txtvalue_TtoN;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

