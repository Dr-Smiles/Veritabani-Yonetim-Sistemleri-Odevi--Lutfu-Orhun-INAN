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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && !Disposing)
            {
                var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
                using var con = new NpgsqlConnection(cs);
                con.Open();

                string sql = "SELECT \"musteri_id\",\"iller\".\"il\",\"musteri_adi\",\"musteri_soyadi\" FROM \"musteriler\" INNER JOIN \"iller\" on \"musteriler\".\"musteri_il_id\"=\"iller\".\"il_id\"";
                using var cmd = new NpgsqlCommand(sql, con);

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                    dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(3);
                }

                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT \"musteri_id\",\"iller\".\"il\",\"musteri_adi\",\"musteri_soyadi\" FROM \"musteriler\" INNER JOIN \"iller\" on \"musteriler\".\"musteri_il_id\"=\"iller\".\"il_id\" WHERE ";

            int querySayisi = 0;

            if (String.IsNullOrEmpty(searchIsım.Text) != true)
            {
                string arananisim = searchIsım.Text;
                sql = sql + "(\"musteri_adi\" = '" + arananisim + "')";
                querySayisi++;
            }

            
            if (String.IsNullOrEmpty(searchSoyisim.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "musteri_soyadi = '" + searchSoyisim.Text + "'";
                querySayisi++;
            }

            if (String.IsNullOrEmpty(searchId.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "musteri_id = '" + searchId.Text + "'";
                querySayisi++;
            }

            if (String.IsNullOrEmpty(searchIl.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "iller.il = '" + searchIl.Text + "'";
                querySayisi++;
            }

            if (querySayisi == 0)
            {
                sql = "SELECT \"musteri_id\",\"iller\".\"il\",\"musteri_adi\",\"musteri_soyadi\" FROM \"musteriler\" INNER JOIN \"iller\" on \"musteriler\".\"musteri_il_id\"=\"iller\".\"il_id\"";
            }

            this.dataGridView1.Rows.Clear();
            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(2);
                dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(3);
                dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(1);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT \"musteri_id\",\"iller\".\"il\",\"musteri_adi\",\"musteri_soyadi\" FROM \"musteriler\" INNER JOIN \"iller\" on \"musteriler\".\"musteri_il_id\"=\"iller\".\"il_id\" WHERE ";

            int querySayisi = 0;

            if (String.IsNullOrEmpty(searchSilAd.Text) != true)
            {
                string arananisim = searchSilAd.Text;
                sql = sql + "(\"musteri_adi\" = '" + arananisim + "')";
                querySayisi++;
            }


            if (String.IsNullOrEmpty(SearchSilSoyad.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "musteri_soyadi = '" + SearchSilSoyad.Text + "'";
                querySayisi++;
            }

            if (String.IsNullOrEmpty(searchSilId.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "musteri_id = '" + searchSilId.Text + "'";
                querySayisi++;
            }

            if (String.IsNullOrEmpty(searchSilIl.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "iller.il = '" + searchSilIl.Text + "'";
                querySayisi++;
            }

            if (querySayisi == 0)
            {
                //sql = "SELECT \"musteri_id\",\"iller\".\"il\",\"musteri_adi\",\"musteri_soyadi\" FROM \"musteriler\" INNER JOIN \"iller\" on \"musteriler\".\"musteri_il_id\"=\"iller\".\"il_id\"";
            }

            this.dataGridView1.Rows.Clear();
            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            int toBeDeleted = 0;

            while (rdr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(2);
                dataGridView1.Rows[n].Cells[2].Value = rdr.GetString(3);
                dataGridView1.Rows[n].Cells[3].Value = rdr.GetString(1);
                toBeDeleted++;

            }

            if (toBeDeleted != 0)
            {
            panel2.Visible = true;
                aboutToBeDeleted.Text = toBeDeleted + " adet üye silinecektir.";
                //aboutToBeDeleted.Text = sql;
            }

            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "DELETE FROM \"musteriler\" WHERE ";

            int querySayisi = 0;

            if (String.IsNullOrEmpty(searchSilAd.Text) != true)
            {
                string arananisim = searchSilAd.Text;
                sql = sql + "(\"musteri_adi\" = '" + arananisim + "')";
                querySayisi++;
            }


            if (String.IsNullOrEmpty(SearchSilSoyad.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "musteri_soyadi = '" + SearchSilSoyad.Text + "'";
                querySayisi++;
            }

            if (String.IsNullOrEmpty(searchSilId.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "musteri_id = '" + searchSilId.Text + "'";
                querySayisi++;
            }

            if (String.IsNullOrEmpty(searchSilIl.Text) != true)
            {
                if (querySayisi != 0) { sql = sql + " AND "; }
                sql = sql + "iller.il = '" + searchSilIl.Text + "'";
                querySayisi++;
            }

            if (querySayisi != 0)
            {
            this.dataGridView1.Rows.Clear();
            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();                
            }

            con.Close();
            panel2.Visible = false;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            uyariMusteriVar.Visible = false;
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            bool doit = false;

            string sql = "SELECT \"musteri_id\",\"iller\".\"il\",\"musteri_adi\",\"musteri_soyadi\" FROM \"musteriler\" INNER JOIN \"iller\" on \"musteriler\".\"musteri_il_id\"=\"iller\".\"il_id\"";
            using var cmd = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr = cmd.ExecuteReader();
            List<String> kullaniciAdlari = new List<String>();
            List<String> kullaniciSoyadlari = new List<String>();

            while (rdr.Read())
            {
                kullaniciAdlari.Add(rdr.GetString(2));
                kullaniciSoyadlari.Add(rdr.GetString(3));
            }

            if (String.IsNullOrEmpty(ekleAd.Text) || String.IsNullOrEmpty(ekleSoyad.Text) || String.IsNullOrEmpty(eklePlaka.Text))
            {
                uyariMusteriVar.Visible = true;
                uyariMusteriVar.Text = "Bütün Kutucukları Doldurun!";
            }
            else
            {
                if (((kullaniciAdlari.Contains(ekleAd.Text) != true ^ kullaniciSoyadlari.Contains(ekleSoyad.Text) != true) || (kullaniciAdlari.IndexOf(ekleAd.Text) != kullaniciSoyadlari.IndexOf(ekleSoyad.Text))) 
                    && (1 <= Int32.Parse(eklePlaka.Text) && Int32.Parse(eklePlaka.Text) <= 81)) doit = true;
                else if (String.IsNullOrEmpty(ekleAd.Text)) {
                    uyariMusteriVar.Visible = true;
                    uyariMusteriVar.Text = uyariMusteriVar.Text + "İsim Kısmı Yazılmalıdır.";
                }
                else if (String.IsNullOrEmpty(ekleSoyad.Text))
                {
                    uyariMusteriVar.Visible = true;
                    uyariMusteriVar.Text = uyariMusteriVar.Text + "Soyisim Kısmı Yazılmalıdır.";
                }
                else if ((1 <= Int32.Parse(eklePlaka.Text) && Int32.Parse(eklePlaka.Text) <= 81) != true)
                {
                    uyariMusteriVar.Visible = true;
                    uyariMusteriVar.Text = uyariMusteriVar.Text + "Plaka Değeri İstenen Arada Olmalıdır.";
                }
            }

            //uyariMusteriVar.Visible = true;
            //uyariMusteriVar.Text = " " + doit;

            if (doit)
            {
                //uyariMusteriVar.Visible = true;
                rdr.Close();
                cmd.Cancel();
                cmd.CommandText = "INSERT INTO musteriler(musteri_adi, musteri_soyadi, musteri_il_id) VALUES ('" + ekleAd.Text + "','"+ ekleSoyad.Text+"', " + Int64.Parse(eklePlaka.Text) + ")";
                //uyariMusteriVar.Text = "INSERT INTO musteriler(musteri_adi, musteri_soyadi, musteri_il_id) VALUES ('" + ekleAd.Text + "','" + ekleSoyad.Text + "', " + Int64.Parse(eklePlaka.Text) + ")";
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        private void eklePlaka_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
