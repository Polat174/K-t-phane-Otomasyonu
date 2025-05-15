namespace kütüphane1
{
    partial class ÜyeListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtokunan = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.Label();
            this.txtcinsiyet = new System.Windows.Forms.Label();
            this.txtyaş = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(287, 409);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 35;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(176, 409);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(91, 23);
            this.btnguncelle.TabIndex = 34;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comboBox1.Location = new System.Drawing.Point(176, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(176, 360);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 22);
            this.textBox7.TabIndex = 32;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(176, 309);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 22);
            this.textBox6.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 260);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 22);
            this.textBox5.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtokunan
            // 
            this.txtokunan.AutoSize = true;
            this.txtokunan.Location = new System.Drawing.Point(0, 366);
            this.txtokunan.Name = "txtokunan";
            this.txtokunan.Size = new System.Drawing.Size(129, 16);
            this.txtokunan.TabIndex = 25;
            this.txtokunan.Text = "Okunan Kitap Sayısı:";
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(81, 315);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(48, 16);
            this.txtemail.TabIndex = 24;
            this.txtemail.Text = "E-mail:";
            // 
            // txtadres
            // 
            this.txtadres.AutoSize = true;
            this.txtadres.Location = new System.Drawing.Point(83, 266);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(46, 16);
            this.txtadres.TabIndex = 23;
            this.txtadres.Text = "Adres:";
            // 
            // txttelefon
            // 
            this.txttelefon.AutoSize = true;
            this.txttelefon.Location = new System.Drawing.Point(73, 220);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(56, 16);
            this.txttelefon.TabIndex = 22;
            this.txttelefon.Text = "Telefon:";
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.AutoSize = true;
            this.txtcinsiyet.Location = new System.Drawing.Point(72, 179);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(57, 16);
            this.txtcinsiyet.TabIndex = 21;
            this.txtcinsiyet.Text = "Cinsiyet:";
            // 
            // txtyaş
            // 
            this.txtyaş.AutoSize = true;
            this.txtyaş.Location = new System.Drawing.Point(95, 141);
            this.txtyaş.Name = "txtyaş";
            this.txtyaş.Size = new System.Drawing.Size(34, 16);
            this.txtyaş.TabIndex = 20;
            this.txtyaş.Text = "Yaş:";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.AutoSize = true;
            this.txtadsoyad.Location = new System.Drawing.Point(59, 101);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(70, 16);
            this.txtadsoyad.TabIndex = 19;
            this.txtadsoyad.Text = "Ad Soyad:";
            // 
            // txttc
            // 
            this.txttc.AutoSize = true;
            this.txttc.Location = new System.Drawing.Point(101, 61);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(28, 16);
            this.txttc.TabIndex = 18;
            this.txttc.Text = "TC:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(485, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 22);
            this.textBox8.TabIndex = 37;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "TC Ara:";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(893, 72);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 38;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // ÜyeListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtokunan);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtcinsiyet);
            this.Controls.Add(this.txtyaş);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜyeListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜyeListeleme";
            this.Load += new System.EventHandler(this.ÜyeListeleme_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtokunan;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtadres;
        private System.Windows.Forms.Label txttelefon;
        private System.Windows.Forms.Label txtcinsiyet;
        private System.Windows.Forms.Label txtyaş;
        private System.Windows.Forms.Label txtadsoyad;
        private System.Windows.Forms.Label txttc;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
    }
}