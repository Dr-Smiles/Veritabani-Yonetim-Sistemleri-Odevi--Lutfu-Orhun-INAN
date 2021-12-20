namespace VTY_Ödev_test_0._1
{
    partial class envanterControl
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
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIndirimDurumu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urunSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMarkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSaglayici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_indirim = new System.Windows.Forms.CheckBox();
            this.txt_urunSayisi = new System.Windows.Forms.TextBox();
            this.txt_urunIsmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.urunTuru = new System.Windows.Forms.TextBox();
            this.uretimTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunId,
            this.urunAdi,
            this.urunIndirimDurumu,
            this.urunSayisi,
            this.urunMarkasi,
            this.urunSaglayici});
            this.dataGridView1.Location = new System.Drawing.Point(368, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(573, 584);
            this.dataGridView1.TabIndex = 0;
            // 
            // urunId
            // 
            this.urunId.HeaderText = "Ürün İd";
            this.urunId.Name = "urunId";
            this.urunId.Width = 60;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            // 
            // urunIndirimDurumu
            // 
            this.urunIndirimDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunIndirimDurumu.HeaderText = "İndirim Durumu";
            this.urunIndirimDurumu.Name = "urunIndirimDurumu";
            this.urunIndirimDurumu.ReadOnly = true;
            this.urunIndirimDurumu.Width = 70;
            // 
            // urunSayisi
            // 
            this.urunSayisi.HeaderText = "Ürün Sayısı";
            this.urunSayisi.Name = "urunSayisi";
            // 
            // urunMarkasi
            // 
            this.urunMarkasi.HeaderText = "Ürün Markası";
            this.urunMarkasi.Name = "urunMarkasi";
            // 
            // urunSaglayici
            // 
            this.urunSaglayici.HeaderText = "Ürün Sağlayıcısı";
            this.urunSaglayici.Name = "urunSaglayici";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uretimTarihi);
            this.panel1.Controls.Add(this.urunTuru);
            this.panel1.Controls.Add(this.btn_indirim);
            this.panel1.Controls.Add(this.txt_urunSayisi);
            this.panel1.Controls.Add(this.txt_urunIsmi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 370);
            this.panel1.TabIndex = 1;
            // 
            // btn_indirim
            // 
            this.btn_indirim.AutoSize = true;
            this.btn_indirim.Location = new System.Drawing.Point(186, 266);
            this.btn_indirim.Name = "btn_indirim";
            this.btn_indirim.Size = new System.Drawing.Size(111, 19);
            this.btn_indirim.TabIndex = 9;
            this.btn_indirim.Text = "İndirim Durumu";
            this.btn_indirim.UseVisualStyleBackColor = true;
            // 
            // txt_urunSayisi
            // 
            this.txt_urunSayisi.Location = new System.Drawing.Point(16, 262);
            this.txt_urunSayisi.Name = "txt_urunSayisi";
            this.txt_urunSayisi.PlaceholderText = "Ürün Sayısı";
            this.txt_urunSayisi.Size = new System.Drawing.Size(146, 23);
            this.txt_urunSayisi.TabIndex = 8;
            this.txt_urunSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_urunSayisi_KeyPress_1);
            // 
            // txt_urunIsmi
            // 
            this.txt_urunIsmi.Location = new System.Drawing.Point(16, 224);
            this.txt_urunIsmi.Name = "txt_urunIsmi";
            this.txt_urunIsmi.PlaceholderText = "Ürün İsmi";
            this.txt_urunIsmi.Size = new System.Drawing.Size(298, 23);
            this.txt_urunIsmi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sağlayıcı";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(99, 139);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 79);
            this.listBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Ürün Ekle";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(99, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 79);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürünü Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunTuru
            // 
            this.urunTuru.Location = new System.Drawing.Point(16, 291);
            this.urunTuru.Name = "urunTuru";
            this.urunTuru.PlaceholderText = "Ürün Türü";
            this.urunTuru.Size = new System.Drawing.Size(116, 23);
            this.urunTuru.TabIndex = 10;
            // 
            // uretimTarihi
            // 
            this.uretimTarihi.Location = new System.Drawing.Point(138, 291);
            this.uretimTarihi.Name = "uretimTarihi";
            this.uretimTarihi.Size = new System.Drawing.Size(176, 23);
            this.uretimTarihi.TabIndex = 11;
            // 
            // envanterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "envanterControl";
            this.Size = new System.Drawing.Size(944, 712);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urunIndirimDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSaglayici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox btn_indirim;
        private System.Windows.Forms.TextBox txt_urunSayisi;
        private System.Windows.Forms.TextBox txt_urunIsmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uretimTarihi;
        private System.Windows.Forms.TextBox urunTuru;
    }
}
