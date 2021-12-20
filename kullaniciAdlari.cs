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
    public partial class kullaniciAdlari : UserControl
    {
        public kullaniciAdlari()
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

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM entry";

                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr.GetString(0);
                    dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);

                }
                rdr.Close();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) != true && String.IsNullOrEmpty(textBox2.Text))
            {
                var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
                using var con = new NpgsqlConnection(cs);
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO entry(username,password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM entry";
                //textBox1.Text = "INSERT INTO entry(username,password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                dataGridView1.Rows.Clear();
                using NpgsqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr.GetString(0);
                    dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);

                }
                rdr.Close();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DELETE FROM entry WHERE username = '"+textBox3.Text+"' AND password='"+textBox4.Text+"'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM entry";

            dataGridView1.Rows.Clear();
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = rdr.GetString(0);
                dataGridView1.Rows[n].Cells[1].Value = rdr.GetString(1);

            }
            rdr.Close();
            con.Close();
        }
    }
}
