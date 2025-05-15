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
    public partial class ÜyeListeleme : Form
    {
        public ÜyeListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JT7OLF;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc like '"+txttc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                txtyaş.Text = read["yas"].ToString();
                txtcinsiyet.Text = read["cinsiyet"].ToString();
                txttelefon.Text = read["telefon"].ToString();
                txtadres.Text = read["adres"].ToString();
                txtemail.Text = read["email"].ToString();
                txtokunan.Text = read["okunankitap"].ToString();
            }

            baglanti.Close();
        }
        DataSet daset = new DataSet();
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye where tc like '%" + textBox8.Text + "%'", baglanti);
            adtr.Fill(daset,"Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Üye Silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
             baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Uye where tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            MessageBox.Show("Üye Silindi");
            daset.Tables.Clear();
            uyelistele();
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            } 
            }
           
        }

        private void uyelistele()
        {
            if (baglanti.State != System.Data.ConnectionState.Closed)
            {
                baglanti.Close();
            }
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uye", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();

        }
        private void ÜyeListeleme_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Uye set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet," +
                "telefon=@telefon,adres=@adres,email=@email,okunankitap=@okunankitap where tc=@tc",baglanti);
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
            daset.Tables.Clear();
            uyelistele();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void ÜyeListeleme_Load_1(object sender, EventArgs e)
        {

        }
    }
}
