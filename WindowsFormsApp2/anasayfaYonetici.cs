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
    public partial class anasayfaYonetici : Form
    {
        public anasayfaYonetici()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            yoneticiGirisi frm = new yoneticiGirisi();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbs frm2 = new pbs();
            frm2.Show();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            liste liste = new liste();
            liste.ShowDialog();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PersonelGirisSifresi frm = new PersonelGirisSifresi();
            frm.ShowDialog();


        }
        private void izinListe_Click(object sender, EventArgs e)
        {
            izingor frm = new izingor();
            frm.Show();


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            izingor frm = new izingor();
            frm.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void pbs_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

        }

        private void pbs_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void personelListe_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;

        }

        private void personelListe_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;

        }

        private void PersonelGirisSifre_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;

        }

        private void PersonelGirisSifre_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;

        }

        private void yoneticiGirisAyar_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;

        }

        private void yoneticiGirisAyar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
