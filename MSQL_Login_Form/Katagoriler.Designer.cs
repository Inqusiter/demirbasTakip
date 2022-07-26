
namespace MSQL_Login_Form
{
    partial class Katagoriler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Katagoriler));
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.pnl_AnasayfaTop = new System.Windows.Forms.Panel();
            this.btn_AnasayfaCikis = new System.Windows.Forms.Button();
            this.btn_AnasayfaKapat = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_RutbeIsaret = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.pnl_AnaSayfaMenu = new System.Windows.Forms.Panel();
            this.btn_Rapor_Rapor = new System.Windows.Forms.Button();
            this.btn_Profil_Rapor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmBox_Katagori = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_KatagoriEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.lstBox_Katagoriler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_AnasayfaTop.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RutbeIsaret)).BeginInit();
            this.pnl_AnaSayfaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(507, 142);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(70, 23);
            this.btn_Guncelle.TabIndex = 1;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // pnl_AnasayfaTop
            // 
            this.pnl_AnasayfaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.pnl_AnasayfaTop.Controls.Add(this.btn_AnasayfaCikis);
            this.pnl_AnasayfaTop.Controls.Add(this.btn_AnasayfaKapat);
            this.pnl_AnasayfaTop.Controls.Add(this.lbl_ID);
            this.pnl_AnasayfaTop.Location = new System.Drawing.Point(160, 0);
            this.pnl_AnasayfaTop.Name = "pnl_AnasayfaTop";
            this.pnl_AnasayfaTop.Size = new System.Drawing.Size(1040, 40);
            this.pnl_AnasayfaTop.TabIndex = 2;
            this.pnl_AnasayfaTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_AnasayfaTop_MouseDown);
            this.pnl_AnasayfaTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_AnasayfaTop_MouseMove);
            this.pnl_AnasayfaTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_AnasayfaTop_MouseUp);
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
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(6, 13);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 18);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_Ekle.Location = new System.Drawing.Point(602, 142);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(70, 23);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.num_RutbeIsaret);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(206, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 40);
            this.panel1.TabIndex = 10;
            // 
            // num_RutbeIsaret
            // 
            this.num_RutbeIsaret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.num_RutbeIsaret.ForeColor = System.Drawing.Color.White;
            this.num_RutbeIsaret.Location = new System.Drawing.Point(86, 12);
            this.num_RutbeIsaret.Name = "num_RutbeIsaret";
            this.num_RutbeIsaret.Size = new System.Drawing.Size(109, 20);
            this.num_RutbeIsaret.TabIndex = 2;
            this.num_RutbeIsaret.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "PersonelID";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_Kaydet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_Kaydet.Location = new System.Drawing.Point(416, 142);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(70, 23);
            this.btn_Kaydet.TabIndex = 18;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // pnl_AnaSayfaMenu
            // 
            this.pnl_AnaSayfaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.pnl_AnaSayfaMenu.Controls.Add(this.button1);
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Rapor_Rapor);
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Profil_Rapor);
            this.pnl_AnaSayfaMenu.Controls.Add(this.pictureBox1);
            this.pnl_AnaSayfaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_AnaSayfaMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_AnaSayfaMenu.Name = "pnl_AnaSayfaMenu";
            this.pnl_AnaSayfaMenu.Size = new System.Drawing.Size(160, 600);
            this.pnl_AnaSayfaMenu.TabIndex = 19;
            // 
            // btn_Rapor_Rapor
            // 
            this.btn_Rapor_Rapor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Rapor_Rapor.FlatAppearance.BorderSize = 0;
            this.btn_Rapor_Rapor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Rapor_Rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rapor_Rapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rapor_Rapor.ForeColor = System.Drawing.Color.White;
            this.btn_Rapor_Rapor.Location = new System.Drawing.Point(0, 217);
            this.btn_Rapor_Rapor.Name = "btn_Rapor_Rapor";
            this.btn_Rapor_Rapor.Size = new System.Drawing.Size(160, 59);
            this.btn_Rapor_Rapor.TabIndex = 2;
            this.btn_Rapor_Rapor.Text = "Rapor";
            this.btn_Rapor_Rapor.UseVisualStyleBackColor = true;
            // 
            // btn_Profil_Rapor
            // 
            this.btn_Profil_Rapor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Profil_Rapor.FlatAppearance.BorderSize = 0;
            this.btn_Profil_Rapor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Profil_Rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profil_Rapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Profil_Rapor.ForeColor = System.Drawing.Color.White;
            this.btn_Profil_Rapor.Location = new System.Drawing.Point(0, 152);
            this.btn_Profil_Rapor.Name = "btn_Profil_Rapor";
            this.btn_Profil_Rapor.Size = new System.Drawing.Size(160, 59);
            this.btn_Profil_Rapor.TabIndex = 1;
            this.btn_Profil_Rapor.Text = "Profil";
            this.btn_Profil_Rapor.UseVisualStyleBackColor = true;
            this.btn_Profil_Rapor.Click += new System.EventHandler(this.btn_Profil_Rapor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstBox_Katagoriler);
            this.panel3.Location = new System.Drawing.Point(206, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 346);
            this.panel3.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmBox_Katagori);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(206, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 40);
            this.panel5.TabIndex = 23;
            // 
            // cmBox_Katagori
            // 
            this.cmBox_Katagori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cmBox_Katagori.ForeColor = System.Drawing.Color.White;
            this.cmBox_Katagori.FormattingEnabled = true;
            this.cmBox_Katagori.Location = new System.Drawing.Point(86, 13);
            this.cmBox_Katagori.Name = "cmBox_Katagori";
            this.cmBox_Katagori.Size = new System.Drawing.Size(185, 21);
            this.cmBox_Katagori.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Katagoriler:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_KatagoriEkle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(602, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 40);
            this.panel2.TabIndex = 24;
            // 
            // txt_KatagoriEkle
            // 
            this.txt_KatagoriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txt_KatagoriEkle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KatagoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KatagoriEkle.ForeColor = System.Drawing.Color.White;
            this.txt_KatagoriEkle.Location = new System.Drawing.Point(100, 12);
            this.txt_KatagoriEkle.Name = "txt_KatagoriEkle";
            this.txt_KatagoriEkle.Size = new System.Drawing.Size(177, 19);
            this.txt_KatagoriEkle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Katagori Ekle:";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.ForeColor = System.Drawing.Color.Black;
            this.btn_Sil.Location = new System.Drawing.Point(507, 182);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(70, 23);
            this.btn_Sil.TabIndex = 25;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            // 
            // lstBox_Katagoriler
            // 
            this.lstBox_Katagoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lstBox_Katagoriler.ForeColor = System.Drawing.Color.White;
            this.lstBox_Katagoriler.FormattingEnabled = true;
            this.lstBox_Katagoriler.Location = new System.Drawing.Point(3, 3);
            this.lstBox_Katagoriler.Name = "lstBox_Katagoriler";
            this.lstBox_Katagoriler.Size = new System.Drawing.Size(673, 342);
            this.lstBox_Katagoriler.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Katagoriler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Katagoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.pnl_AnasayfaTop);
            this.Controls.Add(this.pnl_AnaSayfaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Katagoriler";
            this.Text = "Anasayfa";
            this.pnl_AnasayfaTop.ResumeLayout(false);
            this.pnl_AnasayfaTop.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RutbeIsaret)).EndInit();
            this.pnl_AnaSayfaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Panel pnl_AnasayfaTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private System.Windows.Forms.Button btn_AnasayfaKapat;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown num_RutbeIsaret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Panel pnl_AnaSayfaMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AnasayfaCikis;
        private System.Windows.Forms.Button btn_Profil_Rapor;
        private System.Windows.Forms.Button btn_Rapor_Rapor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmBox_Katagori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_KatagoriEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.ListBox lstBox_Katagoriler;
        private System.Windows.Forms.Button button1;
    }
}