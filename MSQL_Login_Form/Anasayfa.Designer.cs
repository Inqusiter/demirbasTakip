
namespace MSQL_Login_Form
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.pnl_AnasayfaTop = new System.Windows.Forms.Panel();
            this.lbl_TopPersonelRutbe = new System.Windows.Forms.Label();
            this.btn_AnasayfaCikis = new System.Windows.Forms.Button();
            this.btn_AnasayfaKapat = new System.Windows.Forms.Button();
            this.pnl_AnaSayfaMenu = new System.Windows.Forms.Panel();
            this.btn_Anasayfa_Yonetici = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Anasayfa_ZimmetGiris = new System.Windows.Forms.Button();
            this.btn_AnaSayfa_Profil = new System.Windows.Forms.Button();
            this.btn_Anasayfa_Katagoriler = new System.Windows.Forms.Button();
            this.btn_Anasayfa_Rapor = new System.Windows.Forms.Button();
            this.lbl_UrunToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_AnasayfaTop.SuspendLayout();
            this.pnl_AnaSayfaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AnasayfaTop
            // 
            this.pnl_AnasayfaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.pnl_AnasayfaTop.Controls.Add(this.lbl_TopPersonelRutbe);
            this.pnl_AnasayfaTop.Controls.Add(this.btn_AnasayfaCikis);
            this.pnl_AnasayfaTop.Controls.Add(this.btn_AnasayfaKapat);
            this.pnl_AnasayfaTop.Location = new System.Drawing.Point(160, 0);
            this.pnl_AnasayfaTop.Name = "pnl_AnasayfaTop";
            this.pnl_AnasayfaTop.Size = new System.Drawing.Size(1040, 40);
            this.pnl_AnasayfaTop.TabIndex = 2;
            this.pnl_AnasayfaTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_AnasayfaTop_MouseDown);
            this.pnl_AnasayfaTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_AnasayfaTop_MouseMove);
            this.pnl_AnasayfaTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_AnasayfaTop_MouseUp);
            // 
            // lbl_TopPersonelRutbe
            // 
            this.lbl_TopPersonelRutbe.AutoSize = true;
            this.lbl_TopPersonelRutbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TopPersonelRutbe.ForeColor = System.Drawing.Color.White;
            this.lbl_TopPersonelRutbe.Location = new System.Drawing.Point(192, 13);
            this.lbl_TopPersonelRutbe.Name = "lbl_TopPersonelRutbe";
            this.lbl_TopPersonelRutbe.Size = new System.Drawing.Size(645, 18);
            this.lbl_TopPersonelRutbe.TabIndex = 22;
            this.lbl_TopPersonelRutbe.Text = "Mahmut Yazılım Demirbaş Ofis Çözümleri 7/24 Destek Demirbaş Takip Programı Versiy" +
    "onn 0.0.1";
            // 
            // btn_AnasayfaCikis
            // 
            this.btn_AnasayfaCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_AnasayfaCikis.FlatAppearance.BorderSize = 0;
            this.btn_AnasayfaCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_AnasayfaCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnasayfaCikis.ForeColor = System.Drawing.Color.White;
            this.btn_AnasayfaCikis.Location = new System.Drawing.Point(978, 0);
            this.btn_AnasayfaCikis.Name = "btn_AnasayfaCikis";
            this.btn_AnasayfaCikis.Size = new System.Drawing.Size(62, 37);
            this.btn_AnasayfaCikis.TabIndex = 11;
            this.btn_AnasayfaCikis.Text = "Kapat";
            this.btn_AnasayfaCikis.UseVisualStyleBackColor = false;
            this.btn_AnasayfaCikis.Click += new System.EventHandler(this.btn_AnasayfaCikis_Click);
            // 
            // btn_AnasayfaKapat
            // 
            this.btn_AnasayfaKapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnasayfaKapat.FlatAppearance.BorderSize = 0;
            this.btn_AnasayfaKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_AnasayfaKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnasayfaKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnasayfaKapat.ForeColor = System.Drawing.Color.White;
            this.btn_AnasayfaKapat.Location = new System.Drawing.Point(1173, 8);
            this.btn_AnasayfaKapat.Name = "btn_AnasayfaKapat";
            this.btn_AnasayfaKapat.Size = new System.Drawing.Size(24, 23);
            this.btn_AnasayfaKapat.TabIndex = 10;
            this.btn_AnasayfaKapat.Text = "X";
            this.btn_AnasayfaKapat.UseVisualStyleBackColor = false;
            // 
            // pnl_AnaSayfaMenu
            // 
            this.pnl_AnaSayfaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Anasayfa_Yonetici);
            this.pnl_AnaSayfaMenu.Controls.Add(this.pictureBox2);
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Anasayfa_ZimmetGiris);
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_AnaSayfa_Profil);
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Anasayfa_Katagoriler);
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Anasayfa_Rapor);
            this.pnl_AnaSayfaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_AnaSayfaMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_AnaSayfaMenu.Name = "pnl_AnaSayfaMenu";
            this.pnl_AnaSayfaMenu.Size = new System.Drawing.Size(160, 600);
            this.pnl_AnaSayfaMenu.TabIndex = 19;
            // 
            // btn_Anasayfa_Yonetici
            // 
            this.btn_Anasayfa_Yonetici.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_Yonetici.FlatAppearance.BorderSize = 0;
            this.btn_Anasayfa_Yonetici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_Yonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anasayfa_Yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Anasayfa_Yonetici.ForeColor = System.Drawing.Color.White;
            this.btn_Anasayfa_Yonetici.Location = new System.Drawing.Point(0, 369);
            this.btn_Anasayfa_Yonetici.Name = "btn_Anasayfa_Yonetici";
            this.btn_Anasayfa_Yonetici.Size = new System.Drawing.Size(160, 59);
            this.btn_Anasayfa_Yonetici.TabIndex = 8;
            this.btn_Anasayfa_Yonetici.Text = "Yönetici";
            this.btn_Anasayfa_Yonetici.UseVisualStyleBackColor = true;
            this.btn_Anasayfa_Yonetici.Click += new System.EventHandler(this.btn_Anasayfa_Yonetici_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Anasayfa_ZimmetGiris
            // 
            this.btn_Anasayfa_ZimmetGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_ZimmetGiris.FlatAppearance.BorderSize = 0;
            this.btn_Anasayfa_ZimmetGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_ZimmetGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anasayfa_ZimmetGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Anasayfa_ZimmetGiris.ForeColor = System.Drawing.Color.White;
            this.btn_Anasayfa_ZimmetGiris.Location = new System.Drawing.Point(3, 252);
            this.btn_Anasayfa_ZimmetGiris.Name = "btn_Anasayfa_ZimmetGiris";
            this.btn_Anasayfa_ZimmetGiris.Size = new System.Drawing.Size(160, 59);
            this.btn_Anasayfa_ZimmetGiris.TabIndex = 6;
            this.btn_Anasayfa_ZimmetGiris.Text = "Zimmet Giris";
            this.btn_Anasayfa_ZimmetGiris.UseVisualStyleBackColor = true;
            this.btn_Anasayfa_ZimmetGiris.Click += new System.EventHandler(this.btn_Anasayfa_ZimmetGiris_Click);
            // 
            // btn_AnaSayfa_Profil
            // 
            this.btn_AnaSayfa_Profil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_AnaSayfa_Profil.FlatAppearance.BorderSize = 0;
            this.btn_AnaSayfa_Profil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_AnaSayfa_Profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnaSayfa_Profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaSayfa_Profil.ForeColor = System.Drawing.Color.White;
            this.btn_AnaSayfa_Profil.Location = new System.Drawing.Point(0, 147);
            this.btn_AnaSayfa_Profil.Name = "btn_AnaSayfa_Profil";
            this.btn_AnaSayfa_Profil.Size = new System.Drawing.Size(160, 59);
            this.btn_AnaSayfa_Profil.TabIndex = 4;
            this.btn_AnaSayfa_Profil.Text = "Profil";
            this.btn_AnaSayfa_Profil.UseVisualStyleBackColor = true;
            this.btn_AnaSayfa_Profil.Click += new System.EventHandler(this.btn_AnaSayfa_Hesap_Click);
            // 
            // btn_Anasayfa_Katagoriler
            // 
            this.btn_Anasayfa_Katagoriler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_Katagoriler.FlatAppearance.BorderSize = 0;
            this.btn_Anasayfa_Katagoriler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_Katagoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anasayfa_Katagoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Anasayfa_Katagoriler.ForeColor = System.Drawing.Color.White;
            this.btn_Anasayfa_Katagoriler.Location = new System.Drawing.Point(0, 193);
            this.btn_Anasayfa_Katagoriler.Name = "btn_Anasayfa_Katagoriler";
            this.btn_Anasayfa_Katagoriler.Size = new System.Drawing.Size(160, 59);
            this.btn_Anasayfa_Katagoriler.TabIndex = 3;
            this.btn_Anasayfa_Katagoriler.Text = "Katagoriler";
            this.btn_Anasayfa_Katagoriler.UseVisualStyleBackColor = true;
            this.btn_Anasayfa_Katagoriler.Click += new System.EventHandler(this.btn_Anasayfa_Katagoriler_Click);
            // 
            // btn_Anasayfa_Rapor
            // 
            this.btn_Anasayfa_Rapor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_Rapor.FlatAppearance.BorderSize = 0;
            this.btn_Anasayfa_Rapor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Anasayfa_Rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anasayfa_Rapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Anasayfa_Rapor.ForeColor = System.Drawing.Color.White;
            this.btn_Anasayfa_Rapor.Location = new System.Drawing.Point(0, 304);
            this.btn_Anasayfa_Rapor.Name = "btn_Anasayfa_Rapor";
            this.btn_Anasayfa_Rapor.Size = new System.Drawing.Size(160, 59);
            this.btn_Anasayfa_Rapor.TabIndex = 2;
            this.btn_Anasayfa_Rapor.Text = "Rapor";
            this.btn_Anasayfa_Rapor.UseVisualStyleBackColor = true;
            this.btn_Anasayfa_Rapor.Click += new System.EventHandler(this.btn_Anasayfa_Rapor_Click);
            // 
            // lbl_UrunToplam
            // 
            this.lbl_UrunToplam.AutoSize = true;
            this.lbl_UrunToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunToplam.ForeColor = System.Drawing.Color.White;
            this.lbl_UrunToplam.Location = new System.Drawing.Point(407, 110);
            this.lbl_UrunToplam.Name = "lbl_UrunToplam";
            this.lbl_UrunToplam.Size = new System.Drawing.Size(86, 31);
            this.lbl_UrunToplam.TabIndex = 20;
            this.lbl_UrunToplam.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Toplam Demirbaş:";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_UrunToplam);
            this.Controls.Add(this.pnl_AnasayfaTop);
            this.Controls.Add(this.pnl_AnaSayfaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.pnl_AnasayfaTop.ResumeLayout(false);
            this.pnl_AnasayfaTop.PerformLayout();
            this.pnl_AnaSayfaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_AnasayfaTop;
        private System.Windows.Forms.Button btn_AnasayfaKapat;
        private System.Windows.Forms.Panel pnl_AnaSayfaMenu;
        private System.Windows.Forms.Button btn_AnasayfaCikis;
        private System.Windows.Forms.Button btn_Anasayfa_Rapor;
        public System.Windows.Forms.Label lbl_TopPersonelRutbe;
        private System.Windows.Forms.Button btn_Anasayfa_Katagoriler;
        private System.Windows.Forms.Button btn_AnaSayfa_Profil;
        private System.Windows.Forms.Button btn_Anasayfa_ZimmetGiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Anasayfa_Yonetici;
        private System.Windows.Forms.Label lbl_UrunToplam;
        private System.Windows.Forms.Label label1;
    }
}