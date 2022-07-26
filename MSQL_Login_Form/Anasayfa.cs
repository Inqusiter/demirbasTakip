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
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {


            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");


        private void Kullanici_goster()
        {
            try
            {

                baglanti.Open();
                SqlDataAdapter demirbas_listele = new SqlDataAdapter
                    ("select TC AS[Personel TC], RUTBE AS[Rütbe], AD AS[Ad],SOYAD AS[Soy ad],RUTBEISARET AS[Rütbe Kodu]," +
                    " ROZETNUM AS[Rozet Numara],DURUM AS[Aktiflik], DISCORDID AS[Discord ID],UYARI AS[Uyarı], BUROID AS[Büro Kod], VESIKALIK   from demirbasbilgi Order By AD ASC", baglanti);
                DataTable dataTable = new DataTable();
                demirbas_listele.Fill(dataTable);
                dtbl_personel.DataSource = dataTable;
                baglanti.Close();



            }
            catch (global::System.Exception)
            {
                MessageBox.Show("error");
            }
        }



        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Kullanici_goster();

        }

        int i;
        private void dtbl_personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow satir = dtbl_personel.Rows[i];
            lbl_ID.Text = satir.Cells[0].Value.ToString();
            //txt_Kodu.Text = satir.Cells[1].Value.ToString();
            txt_Ad.Text = satir.Cells[2].Value.ToString();
            txt_Soyad.Text = satir.Cells[3].Value.ToString();
            int rozetNum = Convert.ToInt32(satir.Cells[4].Value.ToString());
            txt_Blok.Text = satir.Cells[5].Value.ToString();
            int aktiflik = Convert.ToInt32(satir.Cells[6].Value);
            txt_Grub.Text = satir.Cells[7].Value.ToString();
            txt_Marka.Text = satir.Cells[8].Value.ToString();
            txt_SeriNo.Text = satir.Cells[9].Value.ToString();
            string vesikalik = satir.Cells[10].Value.ToString();
            num_Kat.Value = rozetNum;

            try
            {
                if (vesikalik == "")
                {
                    pbox_Avatar.Load("https://cdn.discordapp.com/attachments/961697566263738430/963269339891523644/unknown.png");

                }
                else
                {
                    pbox_Avatar.Load("https://i.hizliresim.com/" + vesikalik);

                }
            }
            catch 
            {

                MessageBox.Show("Vesikalık bölümüne hızlı resim harici uzantı girilmiş!","Uyarı!");
            }







            if (aktiflik == 1)
            {
                chb_Kullanimda.Checked = true;
                MessageBox.Show("aktiflik 1");
            }
            else if (aktiflik == 0)
            {
                chb_Kullanimda.Checked = false;
                MessageBox.Show("aktiflik 0");
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string aktiflik;
            try
            {
               

                if (chb_Kullanimda.Checked == true)
                {
                    aktiflik = "1";
                }
                else
                {
                    aktiflik = "0";
                }


                string veri = "INSERT INTO personelbilgi (RUTBE, AD, SOYAD, RUTBEISARET, ROZETNUM, DURUM, DISCORDID, UYARI, BUROID, VESIKALIK) VALUES (" + "'"+txt_Ad.Text+"'" + "," + "'"+txt_Ad.Text+"'" + "," + "'" +txt_Soyad.Text+ "'" + "," + "'" +num_Kat.Value+"'" + "," + "'"+txt_Blok.Text+"'" + "," + "'"+aktiflik+"'" + "," + "'"+txt_Grub.Text+"'" + "," + "'"+txt_Marka.Text+"'" + "," + "'"+txt_SeriNo.Text+"'" + "," + "'"+txt_Vesikalik.Text+"'" + " )";
                SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");

                // nesne oluşturduk sc ismi verdik ve sqlQuery deşikenini baglantı adlı database içinde çalıştırdık
                SqlCommand sc = new SqlCommand(veri, baglanti);

                //sql baglandik
                baglanti.Open();
                // sorgu sonucu bir şey beklemiyoruz bunu kullandık
                sc.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı","Kaydedildi");
                Kullanici_goster();

            }
            catch 
            {

                MessageBox.Show("hata");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            {
            
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bilgiler silinsin mi?", "Silme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                {
                try
                {
                    string veri = "DELETE FROM personelbilgi WHERE ID =" + "'" +lbl_ID.Text+ "'" + "";

                    // nesne oluşturduk sc ismi verdik ve sqlQuery deşikenini baglantı adlı database içinde çalıştırdık
                    SqlCommand sc = new SqlCommand(veri, baglanti);

                    //sql baglandik
                    baglanti.Open();
                    // sorgu sonucu bir şey beklemiyoruz bunu kullandık
                    sc.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Silme işlemi başarılı", "Personel Silindi");
                    Kullanici_goster();

                }
                catch
                {

                    MessageBox.Show("hata");
                }
                }
            }
        }


        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string aktiflik;
            if (chb_Kullanimda.Checked == true)
            {
                aktiflik = "1";
            }
            else
            {
                aktiflik = "0";
            }


            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bilgiler kayıt edilsin mi?", "Kayıt", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=192.168.60.128;Initial Catalog=demirbas;User ID=sa;Password=Berat123456789");
                try
                {

                    string veriKaydet = "UPDATE  personelbilgi  SET RUTBE = '" + txt_Ad.Text + "' ,AD = '" + txt_Ad.Text + "' , SOYAD = '" + txt_Soyad.Text + "' , RUTBEISARET = '"+num_Kat.Value+"' , ROZETNUM = '"+txt_Blok.Text+"' , DURUM = '"+aktiflik+"'  WHERE ID = '" + lbl_ID.Text + "'";

                    SqlCommand sc2 = new SqlCommand(veriKaydet, baglanti);


                    //sql baglandik
                    baglanti.Open();

                    // sorgu sonucu bir şey okuttuk ve ekledik bunu kullandık
                    sc2.ExecuteNonQuery();
                    baglanti.Close();
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

        private void btn_Anasayfa_Rapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
            this.Hide();
        }
        private void btn_Anasayfa_Katagoriler_Click(object sender, EventArgs e)
        {
            Katagoriler katagoriler = new Katagoriler();
            katagoriler.Show();
            this.Hide();
        }

        private void CmboxBirimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_TopPersonelID.Text = Cmbox_Birimler.Text;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                //SQL baglandık datayı tek tek atadık
                SqlDataAdapter katagoriler = new SqlDataAdapter("SELECT KATAGORI FROM katagoriler", baglanti);
                DataTable KatagorilerData = new DataTable();
                katagoriler.Fill(KatagorilerData);
                for (int i = 0; i < KatagorilerData.Rows.Count; i++)
                {
                    cmBox_AnaSKatagori.Items.Add(KatagorilerData.Rows[i]["KATAGORI"].ToString());
                }

                baglanti.Close();

            }
            catch (global::System.Exception)
            {
                MessageBox.Show("error");
            }

        }

        private void btn_AnaSayfa_Hesap_Click(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            hesap.Show();
        }
    }
}
