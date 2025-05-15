namespace kütüphane1
{
    partial class KitapListeleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.textaçıklama = new System.Windows.Forms.TextBox();
            this.textraf = new System.Windows.Forms.TextBox();
            this.textstok = new System.Windows.Forms.TextBox();
            this.textsayfa = new System.Windows.Forms.TextBox();
            this.textyayinevi = new System.Windows.Forms.TextBox();
            this.textyazar = new System.Windows.Forms.TextBox();
            this.textKitapad = new System.Windows.Forms.TextBox();
            this.textbarkod = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(147, 376);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 38;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textaçıklama
            // 
            this.textaçıklama.Location = new System.Drawing.Point(147, 315);
            this.textaçıklama.Name = "textaçıklama";
            this.textaçıklama.Size = new System.Drawing.Size(178, 22);
            this.textaçıklama.TabIndex = 37;
            // 
            // textraf
            // 
            this.textraf.Location = new System.Drawing.Point(147, 281);
            this.textraf.Name = "textraf";
            this.textraf.Size = new System.Drawing.Size(178, 22);
            this.textraf.TabIndex = 36;
            // 
            // textstok
            // 
            this.textstok.Location = new System.Drawing.Point(147, 247);
            this.textstok.Name = "textstok";
            this.textstok.Size = new System.Drawing.Size(178, 22);
            this.textstok.TabIndex = 35;
            // 
            // textsayfa
            // 
            this.textsayfa.Location = new System.Drawing.Point(147, 213);
            this.textsayfa.Name = "textsayfa";
            this.textsayfa.Size = new System.Drawing.Size(178, 22);
            this.textsayfa.TabIndex = 34;
            // 
            // textyayinevi
            // 
            this.textyayinevi.Location = new System.Drawing.Point(147, 179);
            this.textyayinevi.Name = "textyayinevi";
            this.textyayinevi.Size = new System.Drawing.Size(178, 22);
            this.textyayinevi.TabIndex = 33;
            // 
            // textyazar
            // 
            this.textyazar.Location = new System.Drawing.Point(147, 109);
            this.textyazar.Name = "textyazar";
            this.textyazar.Size = new System.Drawing.Size(178, 22);
            this.textyazar.TabIndex = 32;
            // 
            // textKitapad
            // 
            this.textKitapad.Location = new System.Drawing.Point(147, 75);
            this.textKitapad.Name = "textKitapad";
            this.textKitapad.Size = new System.Drawing.Size(178, 22);
            this.textKitapad.TabIndex = 31;
            // 
            // textbarkod
            // 
            this.textbarkod.Location = new System.Drawing.Point(147, 41);
            this.textbarkod.Name = "textbarkod";
            this.textbarkod.Size = new System.Drawing.Size(178, 22);
            this.textbarkod.TabIndex = 30;
            this.textbarkod.TextChanged += new System.EventHandler(this.textbarkod_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masal",
            "Hikaye",
            "Roman",
            "Tarih",
            "Ansiklopedi",
            "Bilim",
            "Sanat"});
            this.comboBox1.Location = new System.Drawing.Point(147, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Raf No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Stok Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Yayın Evi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "K.Barkod No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 358);
            this.dataGridView1.TabIndex = 40;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(844, 442);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(164, 38);
            this.btnsil.TabIndex = 41;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(632, 13);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(178, 22);
            this.txtbarkod.TabIndex = 43;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "K.Barkod No:";
            // 
            // KitapListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 544);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.textaçıklama);
            this.Controls.Add(this.textraf);
            this.Controls.Add(this.textstok);
            this.Controls.Add(this.textsayfa);
            this.Controls.Add(this.textyayinevi);
            this.Controls.Add(this.textyazar);
            this.Controls.Add(this.textKitapad);
            this.Controls.Add(this.textbarkod);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapListeleme";
            this.Load += new System.EventHandler(this.KitapListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox textaçıklama;
        private System.Windows.Forms.TextBox textraf;
        private System.Windows.Forms.TextBox textstok;
        private System.Windows.Forms.TextBox textsayfa;
        private System.Windows.Forms.TextBox textyayinevi;
        private System.Windows.Forms.TextBox textyazar;
        private System.Windows.Forms.TextBox textKitapad;
        private System.Windows.Forms.TextBox textbarkod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label label10;
    }
}