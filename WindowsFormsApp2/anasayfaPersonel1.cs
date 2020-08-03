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
    public partial class anasayfaPersonel1 : Form
    {
        public anasayfaPersonel1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşçakalın :)");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris frm2 = new giris();
            frm2.Show();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            liste liste = new liste();
            liste.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            izin izin = new izin();
            izin.Show();
            this.Hide();

        }
    }
}
