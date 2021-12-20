using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace VTY_Ödev_test_0._1
{
    public partial class geriIade : UserControl
    {
        public geriIade()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            btn_son.Visible = false;   
        }

        List<int> faturaId = new List<int>();
        List<string> faturaName = new List<string>();
        List<string> urunName = new List<string>();
        List<int> faturaSayisi = new List<int>();
        List<int> personelid = new List<int>();
        //int faturaaid = 0;

        protected override void OnVisibleChanged(EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            btn_son.Visible = false;

            base.OnVisibleChanged(e);

            if (Visible && !Disposing)
            {
                var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
                using var con = new NpgsqlConnection(cs);
                con.Open();

                string sql = "SELECT fatura.fatura_id,musteriler.musteri_adi,musteriler.musteri_soyadi,urunler.urun_adi,sepet.urun_sayisi FROM fatura" +
                    " INNER JOIN musteriler ON musteriler.musteri_id = fatura.musteri_id" +
                    " INNER JOIN sepet ON sepet.sepet_id = fatura.sepet_id" +
                    " INNER JOIN urunler ON urunler.urun_id = sepet.urun_id";
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = sql;
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (faturaId.Contains(rdr.GetInt32(0)) != true && urunName.Contains(rdr.GetString(3)) != true)
                    {
                        faturaId.Add(rdr.GetInt32(0));
                        faturaName.Add(rdr.GetString(1) + " " + rdr.GetString(2));
                        urunName.Add(rdr.GetString(3));
                        faturaSayisi.Add(rdr.GetInt32(4));
                    }
                    else if (faturaId.Contains(rdr.GetInt32(0)) == true && urunName.Contains(rdr.GetString(3)) != true)
                    {
                        faturaId.Add(rdr.GetInt32(0));
                        faturaName.Add(rdr.GetString(1) + " " + rdr.GetString(2));
                        urunName.Add(rdr.GetString(3));
                        faturaSayisi.Add(rdr.GetInt32(4));
                    }
                    else if (faturaId.Contains(rdr.GetInt32(0)) == true && urunName.Contains(rdr.GetString(3)) == true)
                    {
                        faturaSayisi[faturaId.IndexOf(rdr.GetInt32(0))] += rdr.GetInt32(4); 
                    }
                }

                for (int sayac = 0; sayac < faturaSayisi.Count; sayac++)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = faturaId[n];
                    dataGridView1.Rows[n].Cells[1].Value = faturaName[n];
                    dataGridView1.Rows[n].Cells[2].Value = urunName[n];
                    dataGridView1.Rows[n].Cells[3].Value = faturaSayisi[n];
                }

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (faturaId.Contains(Int32.Parse(geri_faturaid.Text)))
            {
                //label1.Visible = true;
                //label1.Text = geri_faturaid.Text;
                pnlFatura.Visible = false;

                pnlFatura.Visible = false;
                panel1.Visible = true;

                var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
                using var con = new NpgsqlConnection(cs);
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                string sql = "SELECT personel_no,personel_ad,personel_soyad FROM personel";

                cmd.CommandText = sql;
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                int tmp = 0;

                while (rdr.Read())
                {
                    tmp =rdr.GetInt32(0);
                    personelid.Add(tmp);
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                    dataGridView2.Rows[n].Cells[1].Value = rdr.GetString(1);
                    dataGridView2.Rows[n].Cells[2].Value = rdr.GetString(2);
                }

                con.Close();
            }
            else
            {

            }
        }

        private void geri_faturaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personelid.Contains(Int32.Parse(salak.Text)))
            { 
                panel1.Visible = false;
                panel2.Visible = true;

                btn_son.Visible = true;
            }
        }

        private void salak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_son_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            int urunid = 0;

            cmd.CommandText = "SELECT urun_id FROM urunler WHERE urun_adi = '" + urunName[faturaId.IndexOf(Int32.Parse(geri_faturaid.Text))]+"'";
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                urunid = rdr.GetInt32(0);
            }
            rdr.Close();
            cmd.Cancel();

            cmd.CommandText = "INSERT INTO geri_iade(fatura_id,personel_id,urun_id,geri_sebep)  VALUES (" +
                faturaId[faturaId.IndexOf(Int32.Parse(geri_faturaid.Text))] +", "+ salak.Text + ", "+ urunid + ", '" + richTextBox2.Text +"')";
            //richTextBox2.Text = "INSERT INTO geri_iade(fatura_id,personel_id,urun_id,geri_sebep)  VALUES (" +
            //    faturaId[faturaId.IndexOf(Int32.Parse(geri_faturaid.Text))] + ", " + salak.Text + ", " + urunid + ", '" + richTextBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            panel1.Visible = false;
            pnlFatura.Visible = true;
            panel2.Visible = false;
        }
    }
}
