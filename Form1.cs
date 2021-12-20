using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTY_Ödev_test_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            closeEmAll();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void closeEmAll()
        {
            this.userControl11.Visible = false;
            this.envanterControl1.Visible = false;
            this.alimSatim1.Visible=false;
            this.geriIade1.Visible = false;
            this.kullaniciAdlari1.Visible = false;
            this.calismaSaatleri1.Visible = false;
        }


        private void btn_musteriler_Click_1(object sender, EventArgs e)
        {
            pnl_personelIsleri.Visible = false;
            pnl_musteriIsleri.Visible = true;
        }

        private void btn_personelIsleri_Click(object sender, EventArgs e)
        {
            pnl_personelIsleri.Visible = true;
            pnl_musteriIsleri.Visible=false;
        }

        private void btn_musteriVeri_Click(object sender, EventArgs e)
        {
            closeEmAll();
            this.userControl11.Visible = true;
        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
            closeEmAll();
            this.envanterControl1.Visible = true;
        }

        private void btn_urunSat_Click(object sender, EventArgs e)
        {
            closeEmAll();
            this.alimSatim1.Visible = true;
        }

        private void btn_geriIade_Click(object sender, EventArgs e)
        {
            closeEmAll();
            this.geriIade1.Visible = true;
        }


        private void btn_calismaSaatleri_Click(object sender, EventArgs e)
        {
            closeEmAll();
            this.calismaSaatleri1.Visible = true;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            closeEmAll();
            this.kullaniciAdlari1.Visible = true;
        }
    }
}
