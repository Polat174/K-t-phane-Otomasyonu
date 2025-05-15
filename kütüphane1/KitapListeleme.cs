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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace kütüphane1
{
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");

        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            Kitaplistele();
        }
        DataSet daset = new DataSet();
        private void Kitaplistele()
        {
            if (baglanti.State != System.Data.ConnectionState.Closed)
            {
                baglanti.Close();
            }
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kitap set barkodno=@barkodno,kitapadi=@kitapadi,yazar=@yazar,yayınevi=@yayınevi,sayfasayisi=@sayfasayisi,turu=@turu,sotksayisi=@sotksayisi,aciklama=@aciklama,rafno=@rafno where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", textbarkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", textKitapad.Text);
            komut.Parameters.AddWithValue("@yazar", textyazar.Text);
            komut.Parameters.AddWithValue("@turu", comboBox1.Text);
            komut.Parameters.AddWithValue("@stoksayasi", textstok.Text);
            komut.Parameters.AddWithValue("@aciklama", textaçıklama.Text);
            komut.Parameters.AddWithValue("@rafno", textraf.Text);
            komut.Parameters.AddWithValue("@yayınevi", textyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textsayfa.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables.Clear();
            Kitaplistele();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Üye Silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Silindi");
                daset.Tables.Clear();
                Kitaplistele();
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where barkodno like '%" + txtbarkod.Text + "%'", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }

        private void textbarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodno like '" + textbarkod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textKitapad.Text = read["kitapadi"].ToString();
                textyazar.Text = read["yazar"].ToString();
                textyayinevi.Text = read["yayınevi"].ToString();
                textsayfa.Text = read["sayfasayisi"].ToString();
                comboBox1.Text = read["turu"].ToString();
                textstok.Text = read["stoksayisi"].ToString();
                textaçıklama.Text = read["aciklama"].ToString();
                textraf.Text = read["rafno"].ToString();

            }

            baglanti.Close();
        }
    }
}
