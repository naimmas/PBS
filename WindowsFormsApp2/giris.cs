using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class giris : Form
    {
        
      
        public giris()
        {
            InitializeComponent();
            
            }

        private void giris_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pbs.mdf;Integrated Security=True");

            if (radioButton1.Checked == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM loginYonetici WHERE k_adi= '" + textBox1.Text + "' AND sifre= '" + textBox2.Text + "'", baglanti);
                SqlDataReader dr;
                dr = komut.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {

                    anasayfaYonetici frm = new anasayfaYonetici();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    string msj = "Kullanıcı Adınızı Ve Şifrenizi Kontrol Ediniz";
                    string title = "Hatalı Giriş";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBox.Show(msj, title, btn, icon);
                    textBox2.Clear();
                }
            }
            else if (radioButton2.Checked == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM loginPersonel WHERE k_adi= '" + textBox1.Text + "' AND sifre= '" + textBox2.Text + "'", baglanti);
                SqlDataReader dr; 
                dr = komut.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    anasayfaPersonel frm = new anasayfaPersonel();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    string msj = "Kullanıcı Adınızı Ve Şifrenizi Kontrol Ediniz";
                    string title = "Hatalı Giriş";
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    MessageBox.Show(msj, title, btn, icon);
                    textBox2.Clear();
                }
            }
            else MessageBox.Show("Yönetici - Personel Seçimini Yapınız");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SifremiUnuttumYonetici frm = new SifremiUnuttumYonetici();
                frm.ShowDialog();


            }
            if (radioButton2.Checked == true)
            {
                SifremiUnuttumPersonel frm = new SifremiUnuttumPersonel();
                frm.ShowDialog();

            }
        }
    }
}
