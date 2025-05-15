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


namespace kütüphane1
{
    public partial class ÜyeEkleme : Form
    {
        
        public ÜyeEkleme()
        {
            InitializeComponent();
        }
       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        private void uyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okunankitap)" +
                "values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okunankitap)", baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@adsoyad", textBox2.Text);
            komut.Parameters.AddWithValue("@yas", textBox3.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@telefon", textBox4.Text);
            komut.Parameters.AddWithValue("@adres", textBox5.Text);
            komut.Parameters.AddWithValue("@email", textBox6.Text);
            komut.Parameters.AddWithValue("@okunankitap", textBox7.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlandı");

            foreach (Control item in Controls)
            {
                if (Controls is TextBox)
                {
                    if (item != txtokunan)
                    {
                        item.Text = "";
                    }
                    
                }
            }
        }

        private void ÜyeEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
