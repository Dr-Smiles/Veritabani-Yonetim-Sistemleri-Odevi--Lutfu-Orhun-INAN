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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private bool shallYouPass()
        {
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            string sql = "SELECT \"username\",\"password\" FROM \"entry\"";

            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();
            bool x = false;

            while (rdr.Read())
            {
                if (rdr.GetString(0) == textBox1.Text && rdr.GetString(1) == textBox2.Text) x=true;
            }

            return x;
            con.Close();
        }

        private void joinOurClub()
        {
            sifreHatali.Visible = false;
            var cs = "Host=localhost;Username=postgres;Password=sifre;Database=Test";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT \"username\",\"password\" FROM \"entry\"";
            bool doit = false;

            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            List<String> kullaniciAdlari = new List<String>();

            while (rdr.Read())
            {
                kullaniciAdlari.Add(rdr.GetString(0));
            }

            if (kullaniciAdlari.Contains(textBox1.Text))
            {
                itExists.Visible = true;
            }
            else if (kullaniciAdlari.Contains(textBox1.Text) != true && String.IsNullOrEmpty(textBox2.Text) != true && textBox2.Text != "şifre Yazılmalı!")
            {
                kayitYapildi.Visible = true;
                itExists.Visible = false;
                doit = true;
            }
            else
            {
                textBox2.Text = "şifre Yazılmalı!";
            }

            rdr.Close();

            if (doit == true)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                cmd.Cancel();
                cmd.CommandText = "INSERT INTO entry(username, \"password\") VALUES ('" + username + "','" + password + "')";
                cmd.ExecuteNonQuery();
            }

            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itExists.Visible = false;
            sifreHatali.Visible = false;
            kayitYapildi.Visible = false;
            if (shallYouPass()) { Close(); }
            else { sifreHatali.Visible = true; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            joinOurClub();
        }
    }
}
