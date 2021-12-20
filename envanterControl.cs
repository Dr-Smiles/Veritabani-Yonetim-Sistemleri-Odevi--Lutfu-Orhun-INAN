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
    public partial class envanterControl : UserControl
    {
        List<int> markalar = new List<int>();
        List<int> saglayicilar = new List<int>();

        public envanterControl()
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

                string sql = "SELECT urun_id,urun_adi,urun_indirim_durumu,urun_sayisi,marka.marka_adi,saglayicilar.saglayici_adi FROM urunler INNER JOIN " +
                    "marka on marka.marka_id=urunler.urun_markasi INNER JOIN saglayicilar on saglayicilar.saglayici_id = urunler.urun_saglayicisi;";
                using var cmd = new NpgsqlCommand(sql, con);

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                    dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = rdr.GetBoolean(2);
                    dataGridView1.Rows[n].Cells[3].Value = rdr.GetInt32(3);
                    dataGridView1.Rows[n].Cells[4].Value = rdr.GetString(4);
                    //if (markalar.Contains(rdr.GetString(4)) != true) { listBox1.Items.Add(rdr.GetString(4)); markalar.Add(rdr.GetString(4)); }
                    dataGridView1.Rows[n].Cells[5].Value = rdr.GetString(5);
                    //if (saglayicilar.Contains(rdr.GetString(5)) != true) { listBox2.Items.Add(rdr.GetString(5)); saglayicilar.Add(rdr.GetString(5)); }

                }
                rdr.Close();
                cmd.Cancel();
                sql = "SELECT marka_id,marka_adi FROM marka";
                using var cmd2 = new NpgsqlCommand(sql, con);

                using NpgsqlDataReader rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    listBox1.Items.Add(rdr2.GetString(1));
                    markalar.Add(rdr2.GetInt32(0));
                }
                rdr2.Close();
                cmd2.Cancel();

                sql = "SELECT saglayici_id, saglayici_adi FROM saglayicilar";
                using var cmd3 = new NpgsqlCommand(sql, con);

                using NpgsqlDataReader rdr3 = cmd3.ExecuteReader();
                while (rdr3.Read())
                {
                    listBox2.Items.Add(rdr3.GetString(1));
                    saglayicilar.Add(rdr3.GetInt32(0));
                }
                rdr3.Close();

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "INSERT INTO \"urunler\"(\"urun_adi\",\"urun_indirim_durumu\",\"urun_sayisi\",\"urun_markasi\",\"urun_saglayicisi\",\"urun_turu\",\"urun_uretim_tarihi\") " +
               "VALUES ('"+txt_urunIsmi.Text+"',"+btn_indirim.Checked+","+Int32.Parse(txt_urunSayisi.Text)+","+markalar[listBox1.SelectedIndex]+","+saglayicilar[listBox2.SelectedIndex]+",'"+urunTuru.Text+"','"+uretimTarihi.Value.ToString("dd-MM-yyyy")+"')";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }


        private void txt_urunSayisi_KeyPress_1(object sender, KeyPressEventArgs e)
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
