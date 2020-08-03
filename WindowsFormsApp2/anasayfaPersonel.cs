using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class anasayfaPersonel : Form
    {
        public anasayfaPersonel()
        {
            InitializeComponent();
        }

        private void personelEkle_Click(object sender, EventArgs e)
        {
            pbsEkle frm = new pbsEkle();
            frm.Show();
            this.Hide();
        }

        private void izinAl_Click(object sender, EventArgs e)
        {
            izin frm = new izin();
            frm.Show();
            this.Hide();

        }

        private void PerosnelListe_Click(object sender, EventArgs e)
        {
            liste frm = new liste();
            frm.ShowDialog();
        }

        private void ext_Click(object sender, EventArgs e)
        {
            
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void ext_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void ext_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void PerosnelListe_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void PerosnelListe_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

        }

        private void personelEkle_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;

        }
        

        private void izinAl_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

        }
        

        private void personelEkle_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;

        }

        private void izinAl_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void anasayfaPersonel_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
