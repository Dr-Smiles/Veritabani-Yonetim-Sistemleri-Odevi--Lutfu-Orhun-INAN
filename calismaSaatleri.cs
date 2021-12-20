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
    public partial class calismaSaatleri : UserControl
    {
        public calismaSaatleri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && !Disposing)
            {
                var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
                using var con = new NpgsqlConnection(cs);
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT personel.personel_no, personel.personel_ad,personel.personel_soyad,baslangic_saat,bitis_saat FROM per_calisma_saatleri " +
                    "INNER JOIN personel ON personel.personel_no = per_calisma_saatleri.personel_id";

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                    dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = rdr.GetBoolean(2);
                    dataGridView1.Rows[n].Cells[3].Value = rdr.GetInt32(3);
                    dataGridView1.Rows[n].Cells[4].Value = rdr.GetInt32(4);

                }
                rdr.Close();
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

            cmd.CommandText = "INSERT INTO per_calisma_saatleri(personel_id,baslangic_saat,bitis_saat) " +
                "VALUES("+Int32.Parse(textBox1.Text)+", " + Int32.Parse(textBox2.Text) + "," + Int32.Parse(textBox3.Text) + ")";
            cmd.ExecuteNonQuery();

            dataGridView1.Rows.Clear();

            cmd.CommandText = "SELECT personel.personel_no, personel.personel_ad,personel.personel_soyad,baslangic_saat,bitis_saat FROM per_calisma_saatleri " +
                    "INNER JOIN personel ON personel.personel_no = per_calisma_saatleri.personel_id";

            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = rdr.GetInt32(0);
                dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);
                dataGridView1.Rows[n].Cells[2].Value = rdr.GetBoolean(2);
                dataGridView1.Rows[n].Cells[3].Value = rdr.GetInt32(3);
                dataGridView1.Rows[n].Cells[4].Value = rdr.GetInt32(4);

            }
            rdr.Close();
            con.Close();
        }
    }
}
