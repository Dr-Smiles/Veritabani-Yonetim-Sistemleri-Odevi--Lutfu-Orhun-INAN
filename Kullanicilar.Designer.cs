using System;

namespace VTY_Ödev_test_0._1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchIsım = new System.Windows.Forms.TextBox();
            this.searchSoyisim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIl = new System.Windows.Forms.TextBox();
            this.searchId = new System.Windows.Forms.TextBox();
            this.pnlSilAra = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutToBeDeleted = new System.Windows.Forms.RichTextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchSilIl = new System.Windows.Forms.TextBox();
            this.searchSilId = new System.Windows.Forms.TextBox();
            this.searchSilAd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchSilSoyad = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uyariMusteriVar = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.eklePlaka = new System.Windows.Forms.TextBox();
            this.ekleAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.ekleSoyad = new System.Windows.Forms.TextBox();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteri_ili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSilAra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.musteri_ad,
            this.musteri_soyadi,
            this.müsteri_ili});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.dataGridView1.Location = new System.Drawing.Point(274, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 661);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchIsım
            // 
            this.searchIsım.Location = new System.Drawing.Point(97, 32);
            this.searchIsım.Name = "searchIsım";
            this.searchIsım.Size = new System.Drawing.Size(100, 23);
            this.searchIsım.TabIndex = 1;
            // 
            // searchSoyisim
            // 
            this.searchSoyisim.Location = new System.Drawing.Point(97, 61);
            this.searchSoyisim.Name = "searchSoyisim";
            this.searchSoyisim.Size = new System.Drawing.Size(100, 23);
            this.searchSoyisim.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchIl);
            this.panel1.Controls.Add(this.searchId);
            this.panel1.Controls.Add(this.searchIsım);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchSoyisim);
            this.panel1.Location = new System.Drawing.Point(36, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 181);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteri İli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müşteri Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri İd";
            // 
            // searchIl
            // 
            this.searchIl.Location = new System.Drawing.Point(97, 90);
            this.searchIl.Name = "searchIl";
            this.searchIl.Size = new System.Drawing.Size(100, 23);
            this.searchIl.TabIndex = 5;
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(97, 3);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(100, 23);
            this.searchId.TabIndex = 4;
            // 
            // pnlSilAra
            // 
            this.pnlSilAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.pnlSilAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSilAra.Controls.Add(this.panel2);
            this.pnlSilAra.Controls.Add(this.label5);
            this.pnlSilAra.Controls.Add(this.label6);
            this.pnlSilAra.Controls.Add(this.label7);
            this.pnlSilAra.Controls.Add(this.label8);
            this.pnlSilAra.Controls.Add(this.searchSilIl);
            this.pnlSilAra.Controls.Add(this.searchSilId);
            this.pnlSilAra.Controls.Add(this.searchSilAd);
            this.pnlSilAra.Controls.Add(this.button2);
            this.pnlSilAra.Controls.Add(this.SearchSilSoyad);
            this.pnlSilAra.Location = new System.Drawing.Point(36, 221);
            this.pnlSilAra.Name = "pnlSilAra";
            this.pnlSilAra.Size = new System.Drawing.Size(214, 181);
            this.pnlSilAra.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.aboutToBeDeleted);
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 181);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // aboutToBeDeleted
            // 
            this.aboutToBeDeleted.BackColor = System.Drawing.SystemColors.Control;
            this.aboutToBeDeleted.Location = new System.Drawing.Point(23, 40);
            this.aboutToBeDeleted.Name = "aboutToBeDeleted";
            this.aboutToBeDeleted.Size = new System.Drawing.Size(158, 73);
            this.aboutToBeDeleted.TabIndex = 6;
            this.aboutToBeDeleted.Text = "";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(126, 153);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "İptal";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(6, 153);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Müşteri İli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Müşteri Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(23, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Müşteri Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Müşteri İd";
            // 
            // searchSilIl
            // 
            this.searchSilIl.Location = new System.Drawing.Point(97, 90);
            this.searchSilIl.Name = "searchSilIl";
            this.searchSilIl.Size = new System.Drawing.Size(100, 23);
            this.searchSilIl.TabIndex = 5;
            // 
            // searchSilId
            // 
            this.searchSilId.Location = new System.Drawing.Point(97, 3);
            this.searchSilId.Name = "searchSilId";
            this.searchSilId.Size = new System.Drawing.Size(100, 23);
            this.searchSilId.TabIndex = 4;
            // 
            // searchSilAd
            // 
            this.searchSilAd.Location = new System.Drawing.Point(97, 32);
            this.searchSilAd.Name = "searchSilAd";
            this.searchSilAd.Size = new System.Drawing.Size(100, 23);
            this.searchSilAd.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchSilSoyad
            // 
            this.SearchSilSoyad.Location = new System.Drawing.Point(97, 61);
            this.SearchSilSoyad.Name = "SearchSilSoyad";
            this.SearchSilSoyad.Size = new System.Drawing.Size(100, 23);
            this.SearchSilSoyad.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uyariMusteriVar);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.eklePlaka);
            this.panel3.Controls.Add(this.ekleAd);
            this.panel3.Controls.Add(this.btnAra);
            this.panel3.Controls.Add(this.ekleSoyad);
            this.panel3.Location = new System.Drawing.Point(36, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 252);
            this.panel3.TabIndex = 9;
            // 
            // uyariMusteriVar
            // 
            this.uyariMusteriVar.BackColor = System.Drawing.SystemColors.Control;
            this.uyariMusteriVar.Location = new System.Drawing.Point(23, 125);
            this.uyariMusteriVar.Name = "uyariMusteriVar";
            this.uyariMusteriVar.Size = new System.Drawing.Size(158, 73);
            this.uyariMusteriVar.TabIndex = 8;
            this.uyariMusteriVar.Text = "";
            this.uyariMusteriVar.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Müşteri İli";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Müşteri Soyadı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(23, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Müşteri Adı";
            // 
            // eklePlaka
            // 
            this.eklePlaka.Location = new System.Drawing.Point(97, 73);
            this.eklePlaka.MaxLength = 2;
            this.eklePlaka.Name = "eklePlaka";
            this.eklePlaka.PlaceholderText = "Plaka No (1-81)";
            this.eklePlaka.Size = new System.Drawing.Size(100, 23);
            this.eklePlaka.TabIndex = 5;
            this.eklePlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eklePlaka_KeyPress_1);
            // 
            // ekleAd
            // 
            this.ekleAd.Location = new System.Drawing.Point(97, 15);
            this.ekleAd.Name = "ekleAd";
            this.ekleAd.Size = new System.Drawing.Size(100, 23);
            this.ekleAd.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(122, 214);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ekle";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ekleSoyad
            // 
            this.ekleSoyad.Location = new System.Drawing.Point(97, 44);
            this.ekleSoyad.Name = "ekleSoyad";
            this.ekleSoyad.Size = new System.Drawing.Size(100, 23);
            this.ekleSoyad.TabIndex = 2;
            // 
            // musteri_id
            // 
            this.musteri_id.HeaderText = "Müşteri İd";
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.ReadOnly = true;
            // 
            // musteri_ad
            // 
            this.musteri_ad.HeaderText = "Müşteri Adı";
            this.musteri_ad.Name = "musteri_ad";
            this.musteri_ad.ReadOnly = true;
            this.musteri_ad.Width = 200;
            // 
            // musteri_soyadi
            // 
            this.musteri_soyadi.HeaderText = "Müşteri Soyadı";
            this.musteri_soyadi.Name = "musteri_soyadi";
            this.musteri_soyadi.ReadOnly = true;
            this.musteri_soyadi.Width = 200;
            // 
            // müsteri_ili
            // 
            this.müsteri_ili.HeaderText = "Müşteri Kayıtlı İli";
            this.müsteri_ili.Name = "müsteri_ili";
            this.müsteri_ili.ReadOnly = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSilAra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(944, 712);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSilAra.ResumeLayout(false);
            this.pnlSilAra.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchIsım;
        private System.Windows.Forms.TextBox searchSoyisim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchIl;
        private System.Windows.Forms.TextBox searchId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSilAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchSilIl;
        private System.Windows.Forms.TextBox searchSilId;
        private System.Windows.Forms.TextBox searchSilAd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SearchSilSoyad;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.RichTextBox aboutToBeDeleted;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox eklePlaka;
        private System.Windows.Forms.TextBox ekleAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox ekleSoyad;
        private System.Windows.Forms.RichTextBox uyariMusteriVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteri_ili;
    }
}
