using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Kitap_Takip_Sistemi
{
    public partial class Kitap_Oku : Form
    {
        public Kitap_Oku()
        {
            InitializeComponent();
            listbx_kitaplar.DrawMode = DrawMode.OwnerDrawFixed;
            listbx_kitaplar.DrawItem += listbx_kitaplar_DrawItem;
        }
        string dosya_yolu;
        string[] dosya_listesi;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HBT7JNC\SQLEXPRESS;Initial Catalog=Kitap_Takip_Sistemi;Integrated Security=True");
        private void Kitap_Oku_Load(object sender, EventArgs e)
        {
            ISBN_Doldur();
            Kitapİsmi_Doldur();
        }
        private void ISBN_Doldur()
        {
            dosya_yolu = Application.StartupPath + @"\Kitaplar\"; // PDF dosyalarının bulunduğu klasörün yolu
            dosya_listesi = Directory.GetFiles(dosya_yolu, "*.pdf"); // Klasördeki tüm PDF dosyalarının listesi
            foreach (string dosya in dosya_listesi)
            {
                listbx_kitaplar.Items.Add(Path.GetFileNameWithoutExtension(dosya)); // ListBox'a her bir dosya adını ekle
            }
        }
        private void Kitapİsmi_Doldur()
        {
            for (int i = 0; i < listbx_kitaplar.Items.Count; i++)
            {
                string secilenISBN = listbx_kitaplar.Items[i].ToString();
                string kitapAdi;
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select adi from Kitap_Bilgileri where isbn = @isbn", con);
                cmd.Parameters.AddWithValue("@isbn", secilenISBN);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    kitapAdi = dr["adi"].ToString();
                    dr.Close();
                    con.Close();
                    listbx_kitaplar.Items[i] = kitapAdi;
                }
            }
        }
        private void listbx_kitaplar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string secilenKitapAdi = listbx_kitaplar.SelectedItem.ToString();
            string kitapISBN;

            DialogResult result = MessageBox.Show(secilenKitapAdi+ " kitabını okumak istiyor musunuz?", "Ceyhun Dirilce", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select isbn from Kitap_Bilgileri where adi = @adi", con);
                cmd.Parameters.AddWithValue("@adi", secilenKitapAdi);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    kitapISBN = dr["isbn"].ToString();
                    dr.Close();
                    con.Close();

                    if (listbx_kitaplar.SelectedIndex != -1)
                    {
                        string dosya_yolu = Path.Combine(Application.StartupPath, "Kitaplar", kitapISBN + ".pdf");
                        System.Diagnostics.Process.Start(dosya_yolu);
                    }
                }
            }
          
        }
        private void listbx_kitaplar_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index >= 0)
            {
                string itemText = listbx_kitaplar.Items[e.Index].ToString();
                SizeF textSize = e.Graphics.MeasureString(itemText, e.Font);
                float x = (e.Bounds.Width - textSize.Width) / 2;
                float y = e.Bounds.Y + (e.Bounds.Height - e.Font.Height) / 2;

                e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), x, y);
            }
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            Kitap_Takip_Sistemi Kitap_Takip_Sistemi = new Kitap_Takip_Sistemi();
            Kitap_Takip_Sistemi.Show();
            this.Hide();
        }
    }
}
