using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void uyelisteleme_Click(object sender, EventArgs e)
        {
            ÜyeListeleme üyeListeleme = new ÜyeListeleme();
            üyeListeleme.ShowDialog();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme emanetkitap = new EmanetKitapVerme();
            emanetkitap.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmanetKitapListeleme emanetlistele = new EmanetKitapListeleme();
            emanetlistele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmanetKitapİade iade = new EmanetKitapİade();
            iade.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik();
            grafik.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sıralama sırala = new Sıralama();
            sırala.ShowDialog();
        }

        private void btnuyeEkle_Click(object sender, EventArgs e)
        {
            ÜyeEkleme üyeekle = new ÜyeEkleme();
            üyeekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KitapEkleme kitapEkle = new KitapEkleme();
            kitapEkle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapListeleme kitaplistele = new KitapListeleme();
            kitaplistele.ShowDialog();
        }
    }
}
