
namespace MSQL_Login_Form
{
    partial class Rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.pnl_AnasayfaTop = new System.Windows.Forms.Panel();
            this.btn_AnasayfaCikis = new System.Windows.Forms.Button();
            this.btn_AnasayfaKapat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_AnaSayfaMenu = new System.Windows.Forms.Panel();
            this.btn_Rapor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_AnasayfaTop.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_AnaSayfaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(361, 188);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(70, 23);
            this.btn_Guncelle.TabIndex = 1;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            // 
            // pnl_AnasayfaTop
            // 
            this.pnl_AnasayfaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
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
            this.btn_Ekle.Location = new System.Drawing.Point(209, 188);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(70, 23);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_Kaydet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_Kaydet.Location = new System.Drawing.Point(285, 188);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(70, 23);
            this.btn_Kaydet.TabIndex = 18;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 234);
            this.textBox1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(206, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 252);
            this.panel3.TabIndex = 21;
            // 
            // pnl_AnaSayfaMenu
            // 
            this.pnl_AnaSayfaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.pnl_AnaSayfaMenu.Controls.Add(this.btn_Rapor);
            this.pnl_AnaSayfaMenu.Controls.Add(this.pictureBox1);
            this.pnl_AnaSayfaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_AnaSayfaMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_AnaSayfaMenu.Name = "pnl_AnaSayfaMenu";
            this.pnl_AnaSayfaMenu.Size = new System.Drawing.Size(160, 600);
            this.pnl_AnaSayfaMenu.TabIndex = 22;
            // 
            // btn_Rapor
            // 
            this.btn_Rapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.btn_Rapor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Rapor.FlatAppearance.BorderSize = 0;
            this.btn_Rapor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.btn_Rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rapor.ForeColor = System.Drawing.Color.White;
            this.btn_Rapor.Location = new System.Drawing.Point(0, 145);
            this.btn_Rapor.Name = "btn_Rapor";
            this.btn_Rapor.Size = new System.Drawing.Size(160, 59);
            this.btn_Rapor.TabIndex = 6;
            this.btn_Rapor.Text = "Rapor";
            this.btn_Rapor.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_AnaSayfaMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.pnl_AnasayfaTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rapor";
            this.Text = "Anasayfa";
            this.pnl_AnasayfaTop.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_AnaSayfaMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Panel pnl_AnasayfaTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private System.Windows.Forms.Button btn_AnasayfaKapat;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_AnasayfaCikis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_AnaSayfaMenu;
        private System.Windows.Forms.Button btn_Rapor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}