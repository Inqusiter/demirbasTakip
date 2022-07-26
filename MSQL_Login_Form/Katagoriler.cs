﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MSQL_Login_Form
{
    public partial class Katagoriler : Form
    {
        public Katagoriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");



        private void btn_Kaydet_Click(object sender, EventArgs e)
        {



            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bilgiler kayıt edilsin mi?", "Kayıt", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Veri güncellendi");
                }
                catch
                {
                    MessageBox.Show("HATA!");
                }
            }
            else
            {
                MessageBox.Show("İşlem Yapılmadı!");
            }



        }

        private bool surukle = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void pnl_AnasayfaTop_MouseDown(object sender, MouseEventArgs e)
        {
            surukle = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnl_AnasayfaTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukle)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnl_AnasayfaTop_MouseUp(object sender, MouseEventArgs e)
        {
            surukle = false;
        }

        private void btn_AnasayfaCikis_Click(object sender, EventArgs e)
        {
            //komple kapatma
            Application.ExitThread();
        }

        private void btn_Profil_Rapor_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            lstBox_Katagoriler.Items.Clear();

            try
            {
                baglanti.Open();

                //SQL baglandık datayı tek tek atadık
                SqlDataAdapter katagoriler = new SqlDataAdapter("SELECT KATAGORI FROM katagoriler", baglanti);
                DataTable KatagorilerData = new DataTable();
                katagoriler.Fill(KatagorilerData);
                for (int i = 0; i < KatagorilerData.Rows.Count; i++)
                {
                    cmBox_Katagori.Items.Add(KatagorilerData.Rows[i]["KATAGORI"].ToString());
                    lstBox_Katagoriler.Items.Add(KatagorilerData.Rows[i]["KATAGORI"].ToString());

                }
                baglanti.Close();

            }
            catch (global::System.Exception)
            {
                MessageBox.Show("TRYCATCH HATASI");
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            if (txt_KatagoriEkle.Text != string.Empty)
            {
                try
                {

                    string veri = "INSERT INTO katagoriler (KATAGORI) VALUES (" + "'" + txt_KatagoriEkle.Text + "'" + " )";
                    SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");

                    // nesne oluşturduk sc ismi verdik ve sqlQuery deşikenini baglantı adlı database içinde çalıştırdık
                    SqlCommand sc = new SqlCommand(veri, baglanti);

                    //sql baglandik
                    baglanti.Open();
                    // sorgu sonucu bir şey beklemiyoruz bunu kullandık
                    sc.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt Başarılı", "Kaydedildi");

                }
                catch
                {
                    MessageBox.Show("TRYCATCH HATASI");
                }
            }
            else
            {
                MessageBox.Show("Boş katagori Eklenemez!","HATA!");
            }
 

        }
    }
}
