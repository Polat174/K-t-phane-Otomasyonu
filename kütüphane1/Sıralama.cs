using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane1
{
    public partial class Sıralama : Form
    {
        public Sıralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();
        private void Sıralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Uye order by okunankitap", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            label2.Text = "";
            label4.Text = "";
            label2.Text= daset.Tables["Uye"].Rows[0]["adsoyad"].ToString()+"=";
            label2.Text += daset.Tables["Uye"].Rows[0]["OkunanKitap"].ToString();
            label4.Text = daset.Tables["Uye"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString()+"=";
            label4.Text += daset.Tables["Uye"].Rows[dataGridView1.Rows.Count - 2]["OkunanKitap"].ToString();
        }
    }
}
