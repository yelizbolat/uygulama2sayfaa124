﻿namespace uygulama2sayfaa124
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListe = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(345, 103);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(134, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(653, 106);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(86, 41);
            this.btnListe.TabIndex = 2;
            this.btnListe.Text = "listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Items.AddRange(new object[] {
            " "});
            this.lbListe.Location = new System.Drawing.Point(502, 67);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 121);
            this.lbListe.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(211, 113);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(119, 20);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.TextBox txtAdSoyad;
    }
}

