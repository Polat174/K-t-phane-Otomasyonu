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
using static System.Net.Mime.MediaTypeNames;

namespace kütüphane1
{

    public partial class EmanetKitapVerme : Form
    {
        public EmanetKitapVerme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void sepetlisteleme()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet", baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sepet(barkodno,kitapad,kitapyazar,yayınevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapad,@kitapyazar,@yayınevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", textBarkod.Text);
            komut.Parameters.AddWithValue("@kitapad", textKad.Text);
            komut.Parameters.AddWithValue("@kitapyazar", textyazar.Text);
            komut.Parameters.AddWithValue("@yayınevi", textyayınevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textsayfa.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", textKsayi.Text);
            komut.Parameters.AddWithValue("@teslimtarihi", teslim.Text);
            komut.Parameters.AddWithValue("@iadetarihi", iade.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepete Eklendi");
            daset.Clear();
            daset.Tables["Sepet"].Clear();
            sepetlisteleme();
            lblKitapsayısı.Text = "";
            kitapsayisi();
            foreach (Control item in Kitapbilgileri.Controls)
            {
                if(item != textKsayi)
                {
                    item.Text = "";
                }
            }
        }

        private void texttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like @tc", baglanti);
            komut.Parameters.AddWithValue("@tc","%"+texttc.Text+"%");
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textad.Text = read["adsoyad"].ToString();
                textyas.Text = read["yas"].ToString();
                texttelefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplar where tc='"+texttc.Text+"'", baglanti);
            object kitapSayisi = komut2.ExecuteScalar();
            lblKayıtlıkitap.Text = kitapSayisi != DBNull.Value ? kitapSayisi.ToString() : "0";
            baglanti.Close();

            if(texttc.Text == "")
            {
                foreach(Control item in groupBox1.Controls)
                {    
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                lblKayıtlıkitap.Text = "";
            }
        }

        private void textBarkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where barkodno like @barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", "%" + textBarkod.Text + "%");
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textKad.Text = read["kitapadi"].ToString();
                textyazar.Text = read["yazar"].ToString();
                textyayınevi.Text = read["yayınevi"].ToString();
                textsayfa.Text = read["sayfasayisi"].ToString();
            }
            baglanti.Close();
            if (texttc.Text == "")
            {
                foreach (Control item in Kitapbilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        if(item == textKsayi)
                        {
                            item.Text = "";
                            
                        }
                    }lblKitapsayısı.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet where barkodno = @barkodno ", baglanti);
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi yapıldı.","Silme işlemi");
            daset.Tables["Sepet"].Clear();
            sepetlisteleme();
            lblKitapsayısı.Text = "";
            kitapsayisi();
            }            
        }

        private void EmanetKitapVerme_Load(object sender, EventArgs e)
        {
            sepetlisteleme();
            kitapsayisi();
        }
        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from Sepet", baglanti);
            object sonuc = komut.ExecuteScalar();
            lblKitapsayısı.Text = sonuc != DBNull.Value ? sonuc.ToString() : "0";
            baglanti.Close();
        }

        private void btnteslim_Click(object sender, EventArgs e)
        {
            if (lblKitapsayısı.Text != "")
            {
                if ((lblKayıtlıkitap.Text == "" && int.Parse(lblKitapsayısı.Text) <= 3) ||
                    (lblKayıtlıkitap.Text != "" && int.Parse(lblKayıtlıkitap.Text) + int.Parse(lblKitapsayısı.Text) <= 3))
                {
                    if (texttc.Text != "" && textad.Text != "" && textyas.Text != "" && texttelefon.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].IsNewRow) continue;

                            baglanti.Open();

                            SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(TC,adsoyad,yas,telefon,barkodno,kitapad,yayinevi,kitapsayisi,yazar,teslimtarihi,sayfasayisi,iadetarihi) values(@TC,@adsoyad,@yas,@telefon,@barkodno,@kitapad,@yayinevi,@kitapsayisi,@yazar,@teslimtarihi,@sayfasayisi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", texttc.Text);
                            komut.Parameters.AddWithValue("@adsoyad", textad.Text);
                            komut.Parameters.AddWithValue("@yas", textyas.Text);
                            komut.Parameters.AddWithValue("@telefon", texttelefon.Text);
                            komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapad", dataGridView1.Rows[i].Cells["kitapad"].Value.ToString());
                            komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells[4].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("@yazar", dataGridView1.Rows[i].Cells["kitapyazar"].Value.ToString());
                            komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();

                            // Uye tablosundaki okunankitap değerini güncelle
                            SqlCommand komut2 = new SqlCommand("update Uye set okunankitap = okunankitap + @kitapsayisi where tc = @tc", baglanti);
                            komut2.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut2.Parameters.AddWithValue("@tc", texttc.Text);
                            komut2.ExecuteNonQuery();

                            // Kitap stoklarını güncelle (SQL injection'a karşı parametreli hale getirildi)
                            SqlCommand komut3 = new SqlCommand("update Kitap set stoksayisi = stoksayisi - @kitapsayisi where BarkodNo = @barkodno", baglanti);
                            komut3.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut3.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut3.ExecuteNonQuery();

                            baglanti.Close();
                        }

                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from Sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Kitaplar emanet verildi.");
                        daset.Tables["Sepet"].Clear();
                        sepetlisteleme();
                        texttc.Text = "";
                        lblKitapsayısı.Text = "";
                        kitapsayisi();
                        lblKayıtlıkitap.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekiyor.", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Üye 3'ten fazla kitap alamaz.", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblKayıtlıkitap_Click(object sender, EventArgs e)
        {

        }
    }
}
