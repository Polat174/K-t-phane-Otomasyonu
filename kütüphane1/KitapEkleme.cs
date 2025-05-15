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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kütüphane1
{
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadi,yazar,yayınevi,sayfasayisi,turu,stoksayisi,aciklama,rafno,kayittarihi)" +
                "values(@barkodno,@kitapadi,@yazar,@yayınevi,@sayfasayisi,@turu,@stoksayisi,@aciklama,@rafno,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", textbarkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", textKitapad.Text);
            komut.Parameters.AddWithValue("@yazar", textyazar.Text);
            komut.Parameters.AddWithValue("@turu", comboBox1.Text);
            komut.Parameters.AddWithValue("@yayınevi", textyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textsayfa.Text);
            komut.Parameters.AddWithValue("@stoksayisi", int.Parse(textstok.Text));
            komut.Parameters.AddWithValue("@aciklama", textaçıklama.Text);
            komut.Parameters.AddWithValue("@rafno", textraf.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Tamamlandı");

            foreach (Control item in Controls)
            {
                if (Controls is TextBox)
                {
                    item.Text = "";

                }
            }
        }

        private void KitapEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
