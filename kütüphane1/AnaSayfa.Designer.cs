namespace kütüphane1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Üyelisteleme = new System.Windows.Forms.Button();
            this.btnuyeEkle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnkitaplistele = new System.Windows.Forms.Button();
            this.btnkitapekleme = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnsiralama = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnkitapiade = new System.Windows.Forms.Button();
            this.btnemanetlisteleme = new System.Windows.Forms.Button();
            this.btnemanetverme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Üyelisteleme);
            this.groupBox1.Controls.Add(this.btnuyeEkle);
            this.groupBox1.Location = new System.Drawing.Point(41, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemeleri";
            // 
            // Üyelisteleme
            // 
            this.Üyelisteleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Üyelisteleme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Üyelisteleme.Location = new System.Drawing.Point(51, 120);
            this.Üyelisteleme.Name = "Üyelisteleme";
            this.Üyelisteleme.Size = new System.Drawing.Size(233, 33);
            this.Üyelisteleme.TabIndex = 1;
            this.Üyelisteleme.Text = "Üye Listeleme İşlemleri";
            this.Üyelisteleme.UseVisualStyleBackColor = true;
            this.Üyelisteleme.Click += new System.EventHandler(this.uyelisteleme_Click);
            // 
            // btnuyeEkle
            // 
            this.btnuyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuyeEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnuyeEkle.Location = new System.Drawing.Point(51, 47);
            this.btnuyeEkle.Name = "btnuyeEkle";
            this.btnuyeEkle.Size = new System.Drawing.Size(233, 33);
            this.btnuyeEkle.TabIndex = 0;
            this.btnuyeEkle.Text = "Üye Ekleme İşlemerleri";
            this.btnuyeEkle.UseVisualStyleBackColor = true;
            this.btnuyeEkle.Click += new System.EventHandler(this.btnuyeEkle_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnkitaplistele);
            this.groupBox2.Controls.Add(this.btnkitapekleme);
            this.groupBox2.Location = new System.Drawing.Point(539, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnkitaplistele
            // 
            this.btnkitaplistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitaplistele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkitaplistele.Location = new System.Drawing.Point(53, 120);
            this.btnkitaplistele.Name = "btnkitaplistele";
            this.btnkitaplistele.Size = new System.Drawing.Size(229, 33);
            this.btnkitaplistele.TabIndex = 1;
            this.btnkitaplistele.Text = "Kitap Listeleme İşlemleri";
            this.btnkitaplistele.UseVisualStyleBackColor = true;
            this.btnkitaplistele.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnkitapekleme
            // 
            this.btnkitapekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitapekleme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkitapekleme.Location = new System.Drawing.Point(53, 47);
            this.btnkitapekleme.Name = "btnkitapekleme";
            this.btnkitapekleme.Size = new System.Drawing.Size(229, 33);
            this.btnkitapekleme.TabIndex = 0;
            this.btnkitapekleme.Text = "Kitap Ekleme İşlemleri";
            this.btnkitapekleme.UseVisualStyleBackColor = true;
            this.btnkitapekleme.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btngrafik);
            this.groupBox3.Controls.Add(this.btnsiralama);
            this.groupBox3.Location = new System.Drawing.Point(539, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 188);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sıralama ve Grafikler";
            // 
            // btngrafik
            // 
            this.btngrafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngrafik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngrafik.Location = new System.Drawing.Point(53, 130);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(229, 33);
            this.btngrafik.TabIndex = 1;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnsiralama
            // 
            this.btnsiralama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiralama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsiralama.Location = new System.Drawing.Point(53, 61);
            this.btnsiralama.Name = "btnsiralama";
            this.btnsiralama.Size = new System.Drawing.Size(229, 33);
            this.btnsiralama.TabIndex = 0;
            this.btnsiralama.Text = "Sıralama";
            this.btnsiralama.UseVisualStyleBackColor = true;
            this.btnsiralama.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnkitapiade);
            this.groupBox4.Controls.Add(this.btnemanetlisteleme);
            this.groupBox4.Controls.Add(this.btnemanetverme);
            this.groupBox4.Location = new System.Drawing.Point(41, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 188);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emanet Kitap İşlemleri";
            // 
            // btnkitapiade
            // 
            this.btnkitapiade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitapiade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkitapiade.Location = new System.Drawing.Point(51, 145);
            this.btnkitapiade.Name = "btnkitapiade";
            this.btnkitapiade.Size = new System.Drawing.Size(246, 33);
            this.btnkitapiade.TabIndex = 2;
            this.btnkitapiade.Text = "Kitap İade İşlemleri";
            this.btnkitapiade.UseVisualStyleBackColor = true;
            this.btnkitapiade.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnemanetlisteleme
            // 
            this.btnemanetlisteleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnemanetlisteleme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnemanetlisteleme.Location = new System.Drawing.Point(51, 90);
            this.btnemanetlisteleme.Name = "btnemanetlisteleme";
            this.btnemanetlisteleme.Size = new System.Drawing.Size(246, 33);
            this.btnemanetlisteleme.TabIndex = 1;
            this.btnemanetlisteleme.Text = "Emanet Listeleme İşlemleri";
            this.btnemanetlisteleme.UseVisualStyleBackColor = true;
            this.btnemanetlisteleme.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnemanetverme
            // 
            this.btnemanetverme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnemanetverme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnemanetverme.Location = new System.Drawing.Point(51, 33);
            this.btnemanetverme.Name = "btnemanetverme";
            this.btnemanetverme.Size = new System.Drawing.Size(246, 33);
            this.btnemanetverme.TabIndex = 0;
            this.btnemanetverme.Text = "Emanet Kitap Verme İşlemleri";
            this.btnemanetverme.UseVisualStyleBackColor = true;
            this.btnemanetverme.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Üyelisteleme;
        private System.Windows.Forms.Button btnuyeEkle;
        private System.Windows.Forms.Button btnkitaplistele;
        private System.Windows.Forms.Button btnkitapekleme;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnsiralama;
        private System.Windows.Forms.Button btnkitapiade;
        private System.Windows.Forms.Button btnemanetlisteleme;
        private System.Windows.Forms.Button btnemanetverme;
    }
}

