﻿namespace Rehber
{
	partial class Rehber
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnTemizle = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnGüncelle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtMail = new System.Windows.Forms.TextBox();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnEkle = new System.Windows.Forms.Button();
			this.MskTel = new System.Windows.Forms.MaskedTextBox();
			this.TxtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(0, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(654, 334);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "REHBER";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 22);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(648, 309);
			this.dataGridView1.TabIndex = 25;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnTemizle);
			this.groupBox2.Controls.Add(this.BtnSil);
			this.groupBox2.Controls.Add(this.BtnGüncelle);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.TxtMail);
			this.groupBox2.Controls.Add(this.TxtSoyad);
			this.groupBox2.Controls.Add(this.TxtAd);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.BtnEkle);
			this.groupBox2.Controls.Add(this.MskTel);
			this.groupBox2.Controls.Add(this.TxtId);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(660, 14);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(320, 334);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "YENİ KİŞİ";
			// 
			// BtnTemizle
			// 
			this.BtnTemizle.Location = new System.Drawing.Point(188, 238);
			this.BtnTemizle.Name = "BtnTemizle";
			this.BtnTemizle.Size = new System.Drawing.Size(109, 29);
			this.BtnTemizle.TabIndex = 8;
			this.BtnTemizle.Text = "TEMİZLE";
			this.BtnTemizle.UseVisualStyleBackColor = true;
			this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(188, 203);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(111, 29);
			this.BtnSil.TabIndex = 6;
			this.BtnSil.Text = "SİL";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnGüncelle
			// 
			this.BtnGüncelle.Location = new System.Drawing.Point(73, 238);
			this.BtnGüncelle.Name = "BtnGüncelle";
			this.BtnGüncelle.Size = new System.Drawing.Size(109, 29);
			this.BtnGüncelle.TabIndex = 7;
			this.BtnGüncelle.Text = "GÜNCELLE";
			this.BtnGüncelle.UseVisualStyleBackColor = true;
			this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "MAİL:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "TEL:";
			// 
			// TxtMail
			// 
			this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtMail.Location = new System.Drawing.Point(73, 171);
			this.TxtMail.Name = "TxtMail";
			this.TxtMail.Size = new System.Drawing.Size(226, 26);
			this.TxtMail.TabIndex = 4;
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtSoyad.Location = new System.Drawing.Point(73, 107);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(226, 26);
			this.TxtSoyad.TabIndex = 2;
			// 
			// TxtAd
			// 
			this.TxtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtAd.Location = new System.Drawing.Point(73, 74);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(226, 26);
			this.TxtAd.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "SOYAD:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "AD:";
			// 
			// BtnEkle
			// 
			this.BtnEkle.Location = new System.Drawing.Point(73, 203);
			this.BtnEkle.Name = "BtnEkle";
			this.BtnEkle.Size = new System.Drawing.Size(109, 29);
			this.BtnEkle.TabIndex = 5;
			this.BtnEkle.Text = "EKLE";
			this.BtnEkle.UseVisualStyleBackColor = true;
			this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
			// 
			// MskTel
			// 
			this.MskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.MskTel.Location = new System.Drawing.Point(73, 139);
			this.MskTel.Mask = "(999) 000-0000";
			this.MskTel.Name = "MskTel";
			this.MskTel.Size = new System.Drawing.Size(226, 26);
			this.MskTel.TabIndex = 3;
			// 
			// TxtId
			// 
			this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtId.Location = new System.Drawing.Point(73, 41);
			this.TxtId.Name = "TxtId";
			this.TxtId.Size = new System.Drawing.Size(226, 26);
			this.TxtId.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// Rehber
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(991, 461);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Rehber";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnEkle;
		private System.Windows.Forms.MaskedTextBox MskTel;
		private System.Windows.Forms.TextBox TxtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnTemizle;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Button BtnGüncelle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtMail;
	}
}

