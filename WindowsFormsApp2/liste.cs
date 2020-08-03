using DGVPrinterHelper;
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
    public partial class liste : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;



        void listele()
        {
            //baglanti = new SqlConnection(@"Data Source=DESKTOP-RQNK7GS\SQLEXPRESS;Initial Catalog=kisiler;Integrated Security=True");
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\pbs.mdf;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM personel", baglanti);
            DataTable personel = new DataTable();
            da.Fill(personel);
            dataGridView1.DataSource = personel;
            baglanti.Close();


        }
        public liste()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kisilerDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.PbsDataSet.personel);
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Rapor";
            printer.SubTitle = string.Format("Tarih: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(dataGridView1);
        }

        private void anasa_Click(object sender, EventArgs e)
        {
            anasayfaPersonel anasayfa = new anasayfaPersonel();
            anasayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
