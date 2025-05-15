using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane1
{
    public partial class EmanetKitapListeleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();
        public EmanetKitapListeleme()
        {
            InitializeComponent();
        }

        private void EmanetKitapListeleme_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();   
			if (comboBox1.SelectedIndex == 0) 
            {
                EmanetListele();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE '"+DateTime.Now.ToShortTimeString()+"'>iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE '" + DateTime.Now.ToShortTimeString() + "'<iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }

        }
    }
}
