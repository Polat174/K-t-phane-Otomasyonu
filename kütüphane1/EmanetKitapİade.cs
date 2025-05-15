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
    public partial class EmanetKitapİade : Form
    {
        public EmanetKitapİade()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapİade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textTCara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE tc like '%" + textTCara.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if(textTCara.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void textBarkodNo_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE tc like '%" + textBarkodNo.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (textBarkodNo.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc",dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi = stoksayisi + @kitapsayisi where barkodno = @barkodno", baglanti);
            komut2.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString()));
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İade işlemi başarılı bir şekilde gerçekleşti.");
            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }
    }
}
