using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class izin : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        void listele()
        {
            
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pbs.mdf;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM izin", baglanti);
            DataTable izin = new DataTable();
            da.Fill(izin);
            baglanti.Close();
        }



        public izin()
        {
            InitializeComponent();
            

        }

        private void izin_Load(object sender, EventArgs e)
        {
            listele();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                string sorgu = "INSERT INTO izin(AD_SOYAD,TC,TARIH,SEBEP) VALUES (@AD_SOYAD,@TC,@TARIH,@SEBEP)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@AD_SOYAD", txtad.Text);
                komut.Parameters.AddWithValue("@TC", txttc.Text);
                komut.Parameters.AddWithValue("@TARIH", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@SEBEP", textBox1.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                txttc.Text = "";
                txtad.Text = "";
                textBox1.Text = "";
                MessageBox.Show("İsteğiniz Alınmıştır");
                anasayfaPersonel anasayfa = new anasayfaPersonel();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM izin WHERE AD_SOYAD= '" + txtad.Text + "' AND TC= '" + txttc.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
           

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txttc.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen Sadece Sayı Girin!");
                txttc.Text = txttc.Text.Remove(txttc.Text.Length - 1);
            }
            if (txttc.Text.Length != 11)
            {
                txttc.BackColor = Color.Red;
            }
            else if (txttc.Text.Length == 11)
                txttc.BackColor = Color.DarkSeaGreen;
            else
                txttc.BackColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                
                textBox1.Visible = false;
                label4.Visible = false;
                dataGridView1.Visible = true;
                button1.Text = "Sorgula";
                label3.Visible = false;
                dateTimePicker1.Visible = false;

            }
            else
            {
                label3.Visible = true;
                dateTimePicker1.Visible = true;
                textBox1.Visible = true;
                label4.Visible = true;
                dataGridView1.Visible = false;
                button1.Text = "Gönder";
            }
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            if (txtad.Text.Length >= 1)
                txtad.BackColor = Color.DarkSeaGreen;
            else
                txtad.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfaPersonel frm = new anasayfaPersonel();
            frm.Show();
            this.Hide();
        }
    }
}
