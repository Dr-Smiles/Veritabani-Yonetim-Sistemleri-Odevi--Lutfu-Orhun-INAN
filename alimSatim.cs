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
    public partial class alimSatim : UserControl
    {
        public alimSatim()
        {
            InitializeComponent();
        }

        int sayac = 0,lastuser_id = 0,active_sepet = 0;
        List<int> kargo_id = new List<int>();
        List<int> urun_id = new List<int>();
        List<int> urun_sayisi = new List<int>();

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            sayac = 0;
            lastuser_id = 0;
            active_sepet = 0;

            if (Visible && !Disposing)
            {
                var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
                using var con = new NpgsqlConnection(cs);
                con.Open();

                string sql = "SELECT kargo_id,kargo_ad FROM kargo_sirketi";
                using var cmd = new NpgsqlCommand(sql, con);

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr.GetString(1));
                    kargo_id.Add(rdr.GetInt32(0));
                }

                cmd.Cancel();
                rdr.Close();

                sql = "SELECT urun_id,urun_sayisi,urun_adi FROM urunler";
                using var cmd2 = new NpgsqlCommand(sql, con);
                using var rdr2 = cmd2.ExecuteReader();

                while (rdr2.Read())
                {
                    listBox2.Items.Add(rdr2.GetString(2)+" adet: "+ rdr2.GetInt32(1));
                    urun_id.Add(rdr2.GetInt32(0));
                    urun_sayisi.Add(rdr2.GetInt32(1));
                }
                
                rdr2.Close();
                cmd2.Cancel();

                sql = "SELECT musteri_id,musteri_adi,musteri_soyadi FROM musteriler";
                using var cmd3 = new NpgsqlCommand(sql, con);
                using var rdr3 = cmd3.ExecuteReader();

                while (rdr3.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr3.GetInt32(0);
                    dataGridView1.Rows[n].Cells[1].Value = rdr3.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = rdr3.GetString(2);
                }
                rdr3.Close();
                cmd3.Cancel();

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.Clear();
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE fatura SET active = FALSE WHERE musteri_id = " + lastuser_id;
            cmd.ExecuteNonQuery();
            //textBox1.Text = lastuser_id + "";
            con.Close();

            textBox2.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.Clear();
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            if (sayac == 0 || Int32.Parse(textBox2.Text) != lastuser_id)
            {
                cmd.CommandText = "INSERT INTO fatura(kargo_sirketi,musteri_id,active) VALUES(" + kargo_id[listBox1.SelectedIndex] + "," + Int32.Parse(textBox2.Text) + ",true)";
                cmd.ExecuteNonQuery();
                lastuser_id = Int32.Parse(textBox2.Text);

                cmd.CommandText = "SELECT sepet_id FROM fatura WHERE musteri_id = " + Int32.Parse(textBox2.Text) + " AND active = true";
                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    active_sepet = rdr.GetInt32(0);
                    //textBox2.Text = active_sepet + "";
                }
                rdr.Close();
                cmd.Cancel();
                sayac++;
            }

            textBox2.ReadOnly = true;
            //errorProvider1.SetError(textBox1, active_sepet + " " + lastuser_id);

            if (urun_sayisi[listBox2.SelectedIndex] >= Int32.Parse(textBox1.Text))
            {
                cmd.CommandText = "INSERT INTO sepet(sepet_id,urun_id,urun_sayisi) VALUES("+ active_sepet + ", "+urun_id[listBox2.SelectedIndex]+", "+ Int32.Parse(textBox1.Text)+")";
                cmd.ExecuteNonQuery();
            }
            else if (urun_sayisi[listBox2.SelectedIndex] < Int32.Parse(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Alınan ürün Sayısı envanterdeki ürün sayısından fazla!");
            }

            cmd.CommandText = "SELECT urunler.urun_adi,sepet.urun_sayisi FROM sepet INNER JOIN urunler ON urunler.urun_id = sepet.urun_id WHERE sepet_id = " + active_sepet;
            using NpgsqlDataReader rdr2 = cmd.ExecuteReader();
            while (rdr2.Read())
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = rdr2.GetString(0);
                dataGridView2.Rows[n].Cells[1].Value = textBox1.Text;

                //textBox2.Text = rdr2.GetString(0);
            }
            con.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
