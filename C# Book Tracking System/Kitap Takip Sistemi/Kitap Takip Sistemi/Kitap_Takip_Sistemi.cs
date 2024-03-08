using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QRCoder;
using System.IO;

namespace Kitap_Takip_Sistemi
{
    public partial class Kitap_Takip_Sistemi : Form
    {
        public Kitap_Takip_Sistemi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HBT7JNC\SQLEXPRESS;Initial Catalog=Kitap_Takip_Sistemi;Integrated Security=True");
        bool kitapOku=false;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViev_Doldur();
            kitapTur_Doldur();
            Kategori_Doldur();
        }
        private void DataGridViev_Doldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("select isbn as [ISBN], adi as [Kitap Adı], yazar as [Yazar], " +
                "yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür], " +
                "fiyat as [Fiyat], resimKonumu as [Resim Konumu] from Kitap_Bilgileri", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void KitapAra_Doldur()
        {
            SqlCommand cmd = new SqlCommand("select isbn from Kitap_Bilgileri", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_kitapAra.Items.Add(dr["isbn"]);
            }
            dr.Close();
            con.Close();
        }
        private void Kategori_Doldur()
        {
            SqlCommand cmd = new SqlCommand("select distinct tur from Kitap_Bilgileri", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_kategoriAra.Items.Add(dr["tur"]);
            }
            dr.Close();
            con.Close();
        }
        private void cmb_kitapAra_SelectedIndexChanged(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand("select isbn as [ISBN], adi as [Kitap Adı], yazar as [Yazar]," +
                "yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür]," +
                " fiyat as [Fiyat], resimKonumu as [Resim Konumu] from Kitap_Bilgileri where isbn=@isbn", con);
            cmd.Parameters.AddWithValue("@isbn", cmb_kitapAra.Text);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand("select*from Kitap_Bilgileri where isbn = @isbn", con);
            cmd.Parameters.AddWithValue("@isbn", cmb_kitapAra.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_kitapAdi.Text = dr["adi"].ToString();
                txt_kitapYazari.Text = dr["yazar"].ToString();
                txt_kitapISBN.Text = dr["isbn"].ToString();
                txt_kitapYayinevi.Text = dr["yayinevi"].ToString();
                txt_kitapBasimYili.Text = dr["basimYili"].ToString();
                txt_kitapSayfaSayisi.Text = dr["sayfaSayisi"].ToString();
                cmb_kitapTuru.Text = dr["tur"].ToString();
                txt_kitapKonusu.Text = dr["konu"].ToString();
                txt_kitapFiyati.Text = dr["fiyat"].ToString();
                txt_resimKonumu.Text = dr["resimKonumu"].ToString();

                if (txt_resimKonumu.Text != "")
                {
                    lbl_resimDosyasiMi.Text = "";
                    picturebx_kitapResmi.ImageLocation = txt_resimKonumu.Text;
                    btn_resimSec.Text = "KAPAĞI KALDIR";
                    string qrKonumu = @".\QR Codes\" + txt_kitapISBN.Text;
                    if (File.Exists(qrKonumu + ".png"))
                    {
                        picturebx_qrCode.ImageLocation = qrKonumu + ".png";
                    }
                }
                else
                {
                    txt_resimKonumu.Text = null;
                    picturebx_kitapResmi.ImageLocation = null;
                    btn_resimSec.Text = "KAPAK SEÇ..";
                }
            }
            dr.Close();
            con.Close();
        }
        private void cmb_kategoriAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select isbn as [ISBN], adi as [Kitap Adı], yazar as [Yazar]," +
              "yayinevi as [Yayınevi], basimYili as [Basım Yılı], sayfaSayisi as [Sayfa Sayısı], tur as [Tür]," +
              " fiyat as [Fiyat], resimKonumu as [Resim Konumu] from Kitap_Bilgileri where tur=@tur", con);
            cmd.Parameters.AddWithValue("@tur", cmb_kategoriAra.Text);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void cmb_kitapAra_TextChanged(object sender, EventArgs e)
        {
            if (cmb_kitapAra.Text.Length == 13)
            {
                cmb_kitapAra_SelectedIndexChanged(sender, e);
            }
            else if (cmb_kitapAra.Text.Length == 0)
            {
                DataGridViev_Doldur();
            }
        }
        private void cmb_kategoriAra_TextChanged(object sender, EventArgs e)
        {
            if (cmb_kategoriAra.Text.Length != 0)
            {
                cmb_kategoriAra_SelectedIndexChanged(sender, e);
            }
            else
            {
                DataGridViev_Doldur();
            }
        }
        public void kitapTur_Doldur()
        {
            cmb_kitapTuru.Items.Add("Anı");
            cmb_kitapTuru.Items.Add("Aşk");
            cmb_kitapTuru.Items.Add("Bilgi");
            cmb_kitapTuru.Items.Add("Bilim Kurgu");
            cmb_kitapTuru.Items.Add("Biyografi");
            cmb_kitapTuru.Items.Add("Çocuk");
            cmb_kitapTuru.Items.Add("Din");
            cmb_kitapTuru.Items.Add("Doğa");
            cmb_kitapTuru.Items.Add("Drama");
            cmb_kitapTuru.Items.Add("Felsefe");
            cmb_kitapTuru.Items.Add("Gezi");
            cmb_kitapTuru.Items.Add("Hikaye");
            cmb_kitapTuru.Items.Add("Korku");
            cmb_kitapTuru.Items.Add("Gerilim");
            cmb_kitapTuru.Items.Add("Macera");
            cmb_kitapTuru.Items.Add("Mizah");
            cmb_kitapTuru.Items.Add("Otobiyografi");
            cmb_kitapTuru.Items.Add("Roman");
            cmb_kitapTuru.Items.Add("Sanat");
            cmb_kitapTuru.Items.Add("Spor");
            cmb_kitapTuru.Items.Add("Şiir");
            cmb_kitapTuru.Items.Add("Tarih");
            cmb_kitapTuru.Items.Add("Psikoloji");
            cmb_kitapTuru.Items.Add("Seyahat");
            cmb_kitapTuru.Items.Add("Yemek");
            cmb_kitapTuru.Items.Add("Hobi");
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_kitapAdi.Text != "" && txt_kitapYazari.Text != "" && txt_kitapISBN.Text != "" && txt_kitapYayinevi.Text != "" && txt_kitapBasimYili.Text != "" && txt_kitapSayfaSayisi.Text != "" && cmb_kitapTuru.Text != "" && txt_kitapKonusu.Text != "" && txt_kitapFiyati.Text != "" && txt_resimKonumu.Text != "")
            {
                string resimUzantisi = Path.GetExtension(txt_resimKonumu.Text);
                if (resimUzantisi == ".png" || resimUzantisi == ".jpg" || resimUzantisi == ".jpeg")
                {
                    SqlCommand cmd = new SqlCommand("IF EXISTS (select * from Kitap_Bilgileri where isbn = @isbn) BEGIN SELECT 1 END ELSE BEGIN " +
                    "insert into Kitap_Bilgileri (adi, yazar, isbn, yayinevi, basimYili, sayfaSayisi, tur, konu, fiyat, resimKonumu) values" +
                    "(@adi, @yazar, @isbn, @yayinevi, @basimYili, @sayfaSayisi, @tur, @konu, @fiyat, @resimKonumu) SELECT 0 END", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@adi", txt_kitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txt_kitapYazari.Text);
                    cmd.Parameters.AddWithValue("@isbn", txt_kitapISBN.Text);
                    cmd.Parameters.AddWithValue("@yayinevi", txt_kitapYayinevi.Text);
                    cmd.Parameters.AddWithValue("@basimYili", txt_kitapBasimYili.Text);
                    cmd.Parameters.AddWithValue("@sayfaSayisi", txt_kitapSayfaSayisi.Text);
                    cmd.Parameters.AddWithValue("@tur", cmb_kitapTuru.Text);
                    cmd.Parameters.AddWithValue("@konu", txt_kitapKonusu.Text);
                    cmd.Parameters.AddWithValue("@fiyat", txt_kitapFiyati.Text);
                    cmd.Parameters.AddWithValue("@resimKonumu", txt_resimKonumu.Text);

                    int isbnControl = (int)cmd.ExecuteScalar();
                    if (isbnControl == 0)
                        txt_kitapISBN.BackColor = Color.Silver;
                    else
                        txt_kitapISBN.BackColor = Color.Red;

                    con.Close();

                    QR_Code();
                    Temizle();
                    DataGridViev_Doldur();
                    cmb_kitapAra.Items.Clear();
                    KitapAra_Doldur();
                }
                else
                {
                    lbl_resimDosyasiMi.Text = "PNG, JPG veya JPEG";
                    lbl_resimDosyasiMi.ForeColor = Color.Red;
                }
            }
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_kitapAdi.Text != "" && txt_kitapYazari.Text != "" && txt_kitapYayinevi.Text != "" && txt_kitapBasimYili.Text != "" && txt_kitapSayfaSayisi.Text != "" && cmb_kitapTuru.Text != "" && txt_kitapKonusu.Text != "" && txt_kitapFiyati.Text != "" && txt_resimKonumu.Text != "")
            {
                string resimUzantisi = Path.GetExtension(txt_resimKonumu.Text);
                if (resimUzantisi == ".png" || resimUzantisi == ".jpg" || resimUzantisi == ".jpeg")
                {
                    SqlCommand cmd = new SqlCommand("Update Kitap_Bilgileri set adi=@adi, yazar=@yazar, yayinevi=@yayinevi," +
                    "basimYili=@basimYili, sayfaSayisi=@sayfaSayisi, tur=@tur, konu=@konu, fiyat=@fiyat, resimKonumu=@resimKonumu where isbn=@isbn", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@adi", txt_kitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txt_kitapYazari.Text);
                    cmd.Parameters.AddWithValue("@isbn", txt_kitapISBN.Text);
                    cmd.Parameters.AddWithValue("@yayinevi", txt_kitapYayinevi.Text);
                    cmd.Parameters.AddWithValue("@basimYili", txt_kitapBasimYili.Text);
                    cmd.Parameters.AddWithValue("@sayfaSayisi", txt_kitapSayfaSayisi.Text);
                    cmd.Parameters.AddWithValue("@tur", cmb_kitapTuru.Text);
                    cmd.Parameters.AddWithValue("@konu", txt_kitapKonusu.Text);
                    cmd.Parameters.AddWithValue("@fiyat", txt_kitapFiyati.Text);
                    cmd.Parameters.AddWithValue("@resimKonumu", txt_resimKonumu.Text);
                    cmd.ExecuteReader();
                    con.Close();

                    cmb_kitapAra.Items.Clear();
                    KitapAra_Doldur();

                    QR_Code();
                    Temizle();
                    DataGridViev_Doldur();
                    cmb_kitapAra.Items.Clear();
                    KitapAra_Doldur();
                }
                else
                {
                    lbl_resimDosyasiMi.Text = "PNG, JPG veya JPEG";
                    lbl_resimDosyasiMi.ForeColor = Color.Red;
                }
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_kitapAdi.Text != "" && txt_kitapYazari.Text != "" && txt_kitapYayinevi.Text != "" && txt_kitapBasimYili.Text != "" && txt_kitapSayfaSayisi.Text != "" && cmb_kitapTuru.Text != "" && txt_kitapKonusu.Text != "" && txt_kitapFiyati.Text != "" && txt_resimKonumu.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Delete from Kitap_Bilgileri where isbn=@isbn", con);
                con.Open();
                cmd.Parameters.AddWithValue("@isbn", txt_kitapISBN.Text);
                cmd.ExecuteReader();
                con.Close();

                string dosyaYolu = @".\QR Codes\" + txt_kitapISBN.Text + ".png";
                if (File.Exists(dosyaYolu))
                {
                    File.Delete(dosyaYolu);
                    MessageBox.Show("QR Code klasörden başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("QR Code zaten klasörde yok!");
                }

                Temizle();
                DataGridViev_Doldur();
                cmb_kitapAra.Items.Clear();
                KitapAra_Doldur();
            }
        }
        private void txt_kitapISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_kitapBasimYili_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_kitapSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cmb_kitapTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void cmb_kitapAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_kitapFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_resimLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_qrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_kitapISBN_TextChanged(object sender, EventArgs e)
        {
            txt_qrName.Text = txt_kitapISBN.Text+".png";
        }
        private void txt_kitapKonusu_TextChanged(object sender, EventArgs e)
        {
            lbl_konuKarakterSayisi.Text = txt_kitapKonusu.TextLength + "/" + txt_kitapKonusu.MaxLength;
        }
        private void radiobtn_AraAc_CheckedChanged(object sender, EventArgs e)
        {
            cmb_kitapAra.Enabled = true;
            btn_ekle.Enabled = false;
            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
            txt_kitapISBN.Enabled = false;

            cmb_kitapAra.Items.Clear();
            KitapAra_Doldur();
        }
        private void radiobtn_AraKapat_CheckedChanged(object sender, EventArgs e)
        {
            cmb_kitapAra.Enabled = false;
            cmb_kitapAra.Text = null;
            btn_ekle.Enabled = true;
            btn_guncelle.Enabled = false;
            btn_sil.Enabled = false;
            txt_kitapISBN.Enabled = true;

            Temizle();
            DataGridViev_Doldur();
        }
        private void Temizle()
        {
            cmb_kitapAra.Text = null;
            cmb_kategoriAra.Text = null;
            txt_kitapAdi.Text = null;
            txt_kitapYazari.Text = null;
            txt_kitapISBN.Text = null;
            txt_kitapYayinevi.Text = null;
            txt_kitapBasimYili.Text = null;
            txt_kitapSayfaSayisi.Text = null;
            cmb_kitapTuru.Text = null;
            txt_kitapKonusu.Text = null;
            txt_kitapFiyati.Text = null;
            txt_resimKonumu.Text = null;
            picturebx_kitapResmi.ImageLocation = null;
            btn_resimSec.Text = "KAPAK SEÇ..";
            openFileDialog1.FileName = null;
            picturebx_qrCode.ImageLocation = null;
        }
        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            if (picturebx_kitapResmi.ImageLocation == null || txt_resimKonumu.Text == "")
            {
                openFileDialog1.ShowDialog();
                picturebx_kitapResmi.ImageLocation = openFileDialog1.FileName;
                txt_resimKonumu.Text = openFileDialog1.FileName;
                if (picturebx_kitapResmi.ImageLocation != "")
                {
                    btn_resimSec.Text = "KAPAĞI KALDIR";
                    openFileDialog1.FileName = null;
                }

            }
            else if (picturebx_kitapResmi.ImageLocation != "")
            {
                txt_resimKonumu.Text = null;
                btn_resimSec.Text = "KAPAK SEÇ..";
                openFileDialog1.FileName = null;
                picturebx_kitapResmi.ImageLocation = null;
            }
        }
        private void QR_Code()
        {
            lbl_resimDosyasiMi.Text = "";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("ISBN: " + txt_kitapISBN.Text + "\n" + "Kitap Adı: " + txt_kitapAdi.Text + "\n" + "Yazar: " + txt_kitapYazari.Text + "\n" + "Yayınevi: " + txt_kitapYayinevi.Text + "\n" + "Basım Yılı: " + txt_kitapBasimYili.Text + "\n" + "Sayfa Sayısı: " + txt_kitapSayfaSayisi.Text + "\n" + "Tür: " + cmb_kitapTuru.Text + "\n" + "Konu: " + txt_kitapKonusu.Text + "\n" + "Fiyat: " + txt_kitapFiyati.Text+" TL", QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            Bitmap logo = new Bitmap(txt_resimKonumu.Text);
            Graphics g = Graphics.FromImage(qrCodeImage);
            int logoSize = Convert.ToInt32(qrCodeImage.Width * 0.2);
            int x = (qrCodeImage.Width - logoSize) / 2;
            int y = (qrCodeImage.Height - logoSize) / 2;
            g.DrawImage(logo, new Rectangle(x, y, logoSize, logoSize));

            picturebx_qrCode.Image = qrCodeImage;

            string folderPath = Path.Combine(Application.StartupPath, "QR Codes");
            Directory.CreateDirectory(folderPath);

            using (Graphics graphics = Graphics.FromImage(qrCodeImage))
            {
                string bookTitle = txt_kitapISBN.Text;
                Font font = new Font("Arial", 40, FontStyle.Bold);
                SizeF textSize = graphics.MeasureString(bookTitle, font);
                PointF textPosition = new PointF(qrCodeImage.Width / 2 - textSize.Width / 2, qrCodeImage.Height - textSize.Height * 2+65);
                graphics.DrawString(bookTitle, font, Brushes.Black, textPosition);
            }

            string fileName = txt_qrName.Text;
            string filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show(txt_qrName.Text + " zaten var."+"\n"+ "Varolan QR code ile değiştirilsin mi?", "Ceyhun Dirilce", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    qrCodeImage.Save(filePath);
                }
                else
                {
                    MessageBox.Show("İşlem gerçekleşti ama dosya kaydedilmedi.");
                }
            }
            else
            {
                qrCodeImage.Save(filePath);
            }
        }

        private void btn_kitapOku_Click(object sender, EventArgs e)
        {
            timer_kitapOku.Start();
        }

        private void timer_kitapOku_Tick(object sender, EventArgs e)
        {
            if (kitapOku==false)
            {
                btn_kitapOku.Enabled = false;
                btn_kitapOku.Left -= 10;
                linklbl_kitapOku.Left = btn_kitapOku.Left + 40;
                if (btn_kitapOku.Location.X <= 900)
                {
                    kitapOku = true;
                    btn_kitapOku.Enabled = true;
                    timer_kitapOku.Stop();
                }
            }
            else
            {
                btn_kitapOku.Enabled = false;
                btn_kitapOku.Left += 10;
                linklbl_kitapOku.Left = btn_kitapOku.Left + 40;
                if (btn_kitapOku.Location.X >= 1000)
                {
                    kitapOku = false;
                    btn_kitapOku.Enabled = true;
                    timer_kitapOku.Stop();
                }
            }
        }

        private void linklbl_kitapOku_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kitap_Oku kitapOku = new Kitap_Oku();
            kitapOku.Show();
            this.Hide();
        }

        private void btn_zoom_Click(object sender, EventArgs e)
        {
            if (picturebx_qrCode.Image!=null)
            {
                QR_Zoom QR_Zoom = new QR_Zoom();
                QR_Zoom.zoom = picturebx_qrCode.Image;
                QR_Zoom.Show();
            }
           
        }
       
    }
}
