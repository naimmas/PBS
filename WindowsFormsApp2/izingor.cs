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
    public partial class izingor : Form
    {

        public izingor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;



        void listele()
        {
            //baglanti = new SqlConnection(@"Data Source=DESKTOP-RQNK7GS\SQLEXPRESS;Initial Catalog=kisiler;Integrated Security=True");
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pbs.mdf;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM izin", baglanti);
            DataTable izin = new DataTable();
            da.Fill(izin);
            dataGridView1.DataSource = izin;
            baglanti.Close();
        }

            private void izingor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pbsDataSet.izin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.izinTableAdapter.Fill(this.pbsDataSet.izin);
            // TODO: This line of code loads data into the 'pbsDataSet.izin' table. You can move, or remove it, as needed.
            this.izinTableAdapter.Fill(this.pbsDataSet.izin);
            // TODO: This line of code loads data into the 'kisilerDataSet1.izin' table. You can move, or remove it, as needed.
            this.izinTableAdapter.Fill(this.pbsDataSet.izin);
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfaYonetici anasayfa = new anasayfaYonetici();
            anasayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE izin SET DURUM=@DURUM WHERE AD_SOYAD=@AD_SOYAD", baglanti);
            cmd.Parameters.AddWithValue("@DURUM", comboBox1.Text);
            cmd.Parameters.AddWithValue("@AD_SOYAD", label2.Text);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            listele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " Adlı Kişinin İzin Durumu";
        }
    }
}
