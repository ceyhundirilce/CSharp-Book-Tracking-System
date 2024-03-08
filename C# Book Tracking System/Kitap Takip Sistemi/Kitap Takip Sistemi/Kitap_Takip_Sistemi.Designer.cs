namespace Kitap_Takip_Sistemi
{
    partial class Kitap_Takip_Sistemi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Takip_Sistemi));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kitapAdi = new System.Windows.Forms.TextBox();
            this.txt_kitapYazari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kitapISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapYayinevi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapBasimYili = new System.Windows.Forms.TextBox();
            this.txt_kitapSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_kitapTuru = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_kitapFiyati = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_kitapKonusu = new System.Windows.Forms.TextBox();
            this.lbl_konuKarakterSayisi = new System.Windows.Forms.Label();
            this.cmb_kitapAra = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radiobtn_AraAc = new System.Windows.Forms.RadioButton();
            this.radiobtn_AraKapat = new System.Windows.Forms.RadioButton();
            this.picturebx_kitapResmi = new System.Windows.Forms.PictureBox();
            this.txt_resimKonumu = new System.Windows.Forms.TextBox();
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.picturebx_qrCode = new System.Windows.Forms.PictureBox();
            this.txt_qrName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_resimDosyasiMi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_kitapOku = new System.Windows.Forms.Button();
            this.linklbl_kitapOku = new System.Windows.Forms.LinkLabel();
            this.timer_kitapOku = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_zoom = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_kategoriAra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_kitapResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_qrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Lime;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(12, 466);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(120, 39);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Enabled = false;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guncelle.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(139, 466);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(120, 39);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı:";
            // 
            // txt_kitapAdi
            // 
            this.txt_kitapAdi.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapAdi.Location = new System.Drawing.Point(165, 254);
            this.txt_kitapAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapAdi.MaxLength = 50;
            this.txt_kitapAdi.Name = "txt_kitapAdi";
            this.txt_kitapAdi.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapAdi.TabIndex = 5;
            // 
            // txt_kitapYazari
            // 
            this.txt_kitapYazari.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapYazari.Location = new System.Drawing.Point(165, 293);
            this.txt_kitapYazari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapYazari.MaxLength = 50;
            this.txt_kitapYazari.Name = "txt_kitapYazari";
            this.txt_kitapYazari.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapYazari.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // txt_kitapISBN
            // 
            this.txt_kitapISBN.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapISBN.Location = new System.Drawing.Point(165, 214);
            this.txt_kitapISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapISBN.MaxLength = 13;
            this.txt_kitapISBN.Name = "txt_kitapISBN";
            this.txt_kitapISBN.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapISBN.TabIndex = 9;
            this.txt_kitapISBN.TextChanged += new System.EventHandler(this.txt_kitapISBN_TextChanged);
            this.txt_kitapISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapISBN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ISBN:";
            // 
            // txt_kitapYayinevi
            // 
            this.txt_kitapYayinevi.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapYayinevi.Location = new System.Drawing.Point(165, 332);
            this.txt_kitapYayinevi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapYayinevi.MaxLength = 50;
            this.txt_kitapYayinevi.Name = "txt_kitapYayinevi";
            this.txt_kitapYayinevi.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapYayinevi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yayınevi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Basım Yılı:";
            // 
            // txt_kitapBasimYili
            // 
            this.txt_kitapBasimYili.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapBasimYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapBasimYili.Location = new System.Drawing.Point(165, 372);
            this.txt_kitapBasimYili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapBasimYili.MaxLength = 4;
            this.txt_kitapBasimYili.Name = "txt_kitapBasimYili";
            this.txt_kitapBasimYili.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapBasimYili.TabIndex = 13;
            this.txt_kitapBasimYili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapBasimYili_KeyPress);
            // 
            // txt_kitapSayfaSayisi
            // 
            this.txt_kitapSayfaSayisi.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapSayfaSayisi.Location = new System.Drawing.Point(165, 410);
            this.txt_kitapSayfaSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapSayfaSayisi.MaxLength = 4;
            this.txt_kitapSayfaSayisi.Name = "txt_kitapSayfaSayisi";
            this.txt_kitapSayfaSayisi.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapSayfaSayisi.TabIndex = 15;
            this.txt_kitapSayfaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapSayfaSayisi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(428, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tür:";
            // 
            // cmb_kitapTuru
            // 
            this.cmb_kitapTuru.BackColor = System.Drawing.Color.Silver;
            this.cmb_kitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kitapTuru.FormattingEnabled = true;
            this.cmb_kitapTuru.IntegralHeight = false;
            this.cmb_kitapTuru.ItemHeight = 20;
            this.cmb_kitapTuru.Location = new System.Drawing.Point(512, 214);
            this.cmb_kitapTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_kitapTuru.MaxDropDownItems = 5;
            this.cmb_kitapTuru.MaxLength = 50;
            this.cmb_kitapTuru.Name = "cmb_kitapTuru";
            this.cmb_kitapTuru.Size = new System.Drawing.Size(219, 28);
            this.cmb_kitapTuru.TabIndex = 17;
            this.cmb_kitapTuru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_kitapTuru_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(428, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Konu:";
            // 
            // txt_kitapFiyati
            // 
            this.txt_kitapFiyati.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapFiyati.Location = new System.Drawing.Point(512, 410);
            this.txt_kitapFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapFiyati.MaxLength = 4;
            this.txt_kitapFiyati.Name = "txt_kitapFiyati";
            this.txt_kitapFiyati.Size = new System.Drawing.Size(219, 26);
            this.txt_kitapFiyati.TabIndex = 21;
            this.txt_kitapFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapFiyati_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(428, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fiyat:";
            // 
            // txt_kitapKonusu
            // 
            this.txt_kitapKonusu.BackColor = System.Drawing.Color.Silver;
            this.txt_kitapKonusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapKonusu.Location = new System.Drawing.Point(512, 254);
            this.txt_kitapKonusu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kitapKonusu.MaxLength = 250;
            this.txt_kitapKonusu.Multiline = true;
            this.txt_kitapKonusu.Name = "txt_kitapKonusu";
            this.txt_kitapKonusu.Size = new System.Drawing.Size(219, 110);
            this.txt_kitapKonusu.TabIndex = 23;
            this.txt_kitapKonusu.TextChanged += new System.EventHandler(this.txt_kitapKonusu_TextChanged);
            // 
            // lbl_konuKarakterSayisi
            // 
            this.lbl_konuKarakterSayisi.AutoSize = true;
            this.lbl_konuKarakterSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_konuKarakterSayisi.ForeColor = System.Drawing.Color.Black;
            this.lbl_konuKarakterSayisi.Location = new System.Drawing.Point(507, 367);
            this.lbl_konuKarakterSayisi.Name = "lbl_konuKarakterSayisi";
            this.lbl_konuKarakterSayisi.Size = new System.Drawing.Size(55, 20);
            this.lbl_konuKarakterSayisi.TabIndex = 24;
            this.lbl_konuKarakterSayisi.Text = "0/250";
            // 
            // cmb_kitapAra
            // 
            this.cmb_kitapAra.BackColor = System.Drawing.Color.Silver;
            this.cmb_kitapAra.Enabled = false;
            this.cmb_kitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kitapAra.FormattingEnabled = true;
            this.cmb_kitapAra.IntegralHeight = false;
            this.cmb_kitapAra.ItemHeight = 20;
            this.cmb_kitapAra.Location = new System.Drawing.Point(165, 12);
            this.cmb_kitapAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_kitapAra.MaxDropDownItems = 5;
            this.cmb_kitapAra.MaxLength = 13;
            this.cmb_kitapAra.Name = "cmb_kitapAra";
            this.cmb_kitapAra.Size = new System.Drawing.Size(219, 28);
            this.cmb_kitapAra.TabIndex = 25;
            this.cmb_kitapAra.SelectedIndexChanged += new System.EventHandler(this.cmb_kitapAra_SelectedIndexChanged);
            this.cmb_kitapAra.TextChanged += new System.EventHandler(this.cmb_kitapAra_TextChanged);
            this.cmb_kitapAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_kitapAra_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "ISBN Ara:";
            // 
            // radiobtn_AraAc
            // 
            this.radiobtn_AraAc.AutoSize = true;
            this.radiobtn_AraAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiobtn_AraAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtn_AraAc.Location = new System.Drawing.Point(165, 46);
            this.radiobtn_AraAc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtn_AraAc.Name = "radiobtn_AraAc";
            this.radiobtn_AraAc.Size = new System.Drawing.Size(61, 22);
            this.radiobtn_AraAc.TabIndex = 27;
            this.radiobtn_AraAc.TabStop = true;
            this.radiobtn_AraAc.Text = "AÇIK";
            this.radiobtn_AraAc.UseVisualStyleBackColor = true;
            this.radiobtn_AraAc.CheckedChanged += new System.EventHandler(this.radiobtn_AraAc_CheckedChanged);
            // 
            // radiobtn_AraKapat
            // 
            this.radiobtn_AraKapat.AutoSize = true;
            this.radiobtn_AraKapat.Checked = true;
            this.radiobtn_AraKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiobtn_AraKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtn_AraKapat.Location = new System.Drawing.Point(307, 46);
            this.radiobtn_AraKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtn_AraKapat.Name = "radiobtn_AraKapat";
            this.radiobtn_AraKapat.Size = new System.Drawing.Size(77, 22);
            this.radiobtn_AraKapat.TabIndex = 28;
            this.radiobtn_AraKapat.TabStop = true;
            this.radiobtn_AraKapat.Text = "KAPALI";
            this.radiobtn_AraKapat.UseVisualStyleBackColor = true;
            this.radiobtn_AraKapat.CheckedChanged += new System.EventHandler(this.radiobtn_AraKapat_CheckedChanged);
            // 
            // picturebx_kitapResmi
            // 
            this.picturebx_kitapResmi.BackColor = System.Drawing.Color.Transparent;
            this.picturebx_kitapResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebx_kitapResmi.Location = new System.Drawing.Point(876, 220);
            this.picturebx_kitapResmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebx_kitapResmi.Name = "picturebx_kitapResmi";
            this.picturebx_kitapResmi.Size = new System.Drawing.Size(130, 184);
            this.picturebx_kitapResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebx_kitapResmi.TabIndex = 29;
            this.picturebx_kitapResmi.TabStop = false;
            // 
            // txt_resimKonumu
            // 
            this.txt_resimKonumu.BackColor = System.Drawing.Color.Silver;
            this.txt_resimKonumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_resimKonumu.Location = new System.Drawing.Point(831, 410);
            this.txt_resimKonumu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_resimKonumu.MaxLength = 50;
            this.txt_resimKonumu.Name = "txt_resimKonumu";
            this.txt_resimKonumu.Size = new System.Drawing.Size(219, 26);
            this.txt_resimKonumu.TabIndex = 30;
            this.txt_resimKonumu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_resimLocation_KeyPress);
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.BackColor = System.Drawing.Color.Silver;
            this.btn_resimSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_resimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resimSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resimSec.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_resimSec.Location = new System.Drawing.Point(851, 174);
            this.btn_resimSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(180, 39);
            this.btn_resimSec.TabIndex = 31;
            this.btn_resimSec.Text = "KAPAK SEÇ..";
            this.btn_resimSec.UseVisualStyleBackColor = false;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // picturebx_qrCode
            // 
            this.picturebx_qrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturebx_qrCode.Location = new System.Drawing.Point(1168, 222);
            this.picturebx_qrCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebx_qrCode.Name = "picturebx_qrCode";
            this.picturebx_qrCode.Size = new System.Drawing.Size(184, 184);
            this.picturebx_qrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebx_qrCode.TabIndex = 32;
            this.picturebx_qrCode.TabStop = false;
            // 
            // txt_qrName
            // 
            this.txt_qrName.BackColor = System.Drawing.Color.Silver;
            this.txt_qrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_qrName.Location = new System.Drawing.Point(1249, 410);
            this.txt_qrName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qrName.MaxLength = 13;
            this.txt_qrName.Name = "txt_qrName";
            this.txt_qrName.Size = new System.Drawing.Size(103, 26);
            this.txt_qrName.TabIndex = 33;
            this.txt_qrName.Text = ".png";
            this.txt_qrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qrName_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1164, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Kaydet:";
            // 
            // lbl_resimDosyasiMi
            // 
            this.lbl_resimDosyasiMi.AutoSize = true;
            this.lbl_resimDosyasiMi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resimDosyasiMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_resimDosyasiMi.ForeColor = System.Drawing.Color.Red;
            this.lbl_resimDosyasiMi.Location = new System.Drawing.Point(855, 438);
            this.lbl_resimDosyasiMi.Name = "lbl_resimDosyasiMi";
            this.lbl_resimDosyasiMi.Size = new System.Drawing.Size(0, 15);
            this.lbl_resimDosyasiMi.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(737, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "TL";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.Enabled = false;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(264, 466);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(120, 39);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 510);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 322);
            this.dataGridView1.TabIndex = 36;
            // 
            // btn_kitapOku
            // 
            this.btn_kitapOku.BackColor = System.Drawing.Color.Transparent;
            this.btn_kitapOku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kitapOku.BackgroundImage")));
            this.btn_kitapOku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kitapOku.FlatAppearance.BorderSize = 0;
            this.btn_kitapOku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kitapOku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_kitapOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapOku.Location = new System.Drawing.Point(1335, 15);
            this.btn_kitapOku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kitapOku.Name = "btn_kitapOku";
            this.btn_kitapOku.Size = new System.Drawing.Size(32, 32);
            this.btn_kitapOku.TabIndex = 38;
            this.btn_kitapOku.UseVisualStyleBackColor = false;
            this.btn_kitapOku.Click += new System.EventHandler(this.btn_kitapOku_Click);
            // 
            // linklbl_kitapOku
            // 
            this.linklbl_kitapOku.AutoSize = true;
            this.linklbl_kitapOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_kitapOku.Location = new System.Drawing.Point(1387, 20);
            this.linklbl_kitapOku.Name = "linklbl_kitapOku";
            this.linklbl_kitapOku.Size = new System.Drawing.Size(97, 20);
            this.linklbl_kitapOku.TabIndex = 39;
            this.linklbl_kitapOku.TabStop = true;
            this.linklbl_kitapOku.Text = "KİTAP OKU";
            this.linklbl_kitapOku.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_kitapOku_LinkClicked);
            // 
            // timer_kitapOku
            // 
            this.timer_kitapOku.Interval = 1;
            this.timer_kitapOku.Tick += new System.EventHandler(this.timer_kitapOku_Tick);
            // 
            // btn_zoom
            // 
            this.btn_zoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_zoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_zoom.BackgroundImage")));
            this.btn_zoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_zoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zoom.FlatAppearance.BorderSize = 0;
            this.btn_zoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_zoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoom.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_zoom.Location = new System.Drawing.Point(1312, 174);
            this.btn_zoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(40, 39);
            this.btn_zoom.TabIndex = 41;
            this.btn_zoom.UseVisualStyleBackColor = false;
            this.btn_zoom.Click += new System.EventHandler(this.btn_zoom_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(481, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Kategori Ara:";
            // 
            // cmb_kategoriAra
            // 
            this.cmb_kategoriAra.BackColor = System.Drawing.Color.Silver;
            this.cmb_kategoriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kategoriAra.FormattingEnabled = true;
            this.cmb_kategoriAra.IntegralHeight = false;
            this.cmb_kategoriAra.ItemHeight = 20;
            this.cmb_kategoriAra.Location = new System.Drawing.Point(647, 12);
            this.cmb_kategoriAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_kategoriAra.MaxDropDownItems = 5;
            this.cmb_kategoriAra.MaxLength = 13;
            this.cmb_kategoriAra.Name = "cmb_kategoriAra";
            this.cmb_kategoriAra.Size = new System.Drawing.Size(219, 28);
            this.cmb_kategoriAra.TabIndex = 42;
            this.cmb_kategoriAra.SelectedIndexChanged += new System.EventHandler(this.cmb_kategoriAra_SelectedIndexChanged);
            this.cmb_kategoriAra.TextChanged += new System.EventHandler(this.cmb_kategoriAra_TextChanged);
            // 
            // Kitap_Takip_Sistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1381, 844);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb_kategoriAra);
            this.Controls.Add(this.btn_zoom);
            this.Controls.Add(this.linklbl_kitapOku);
            this.Controls.Add(this.btn_kitapOku);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_qrName);
            this.Controls.Add(this.lbl_resimDosyasiMi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.picturebx_qrCode);
            this.Controls.Add(this.btn_resimSec);
            this.Controls.Add(this.txt_resimKonumu);
            this.Controls.Add(this.picturebx_kitapResmi);
            this.Controls.Add(this.radiobtn_AraKapat);
            this.Controls.Add(this.radiobtn_AraAc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_kitapAra);
            this.Controls.Add(this.lbl_konuKarakterSayisi);
            this.Controls.Add(this.txt_kitapKonusu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_kitapFiyati);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_kitapTuru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_kitapSayfaSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_kitapBasimYili);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_kitapYayinevi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kitapISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kitapYazari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kitapAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Kitap_Takip_Sistemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP TAKİP SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_kitapResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_qrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kitapAdi;
        private System.Windows.Forms.TextBox txt_kitapYazari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kitapISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapYayinevi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapBasimYili;
        private System.Windows.Forms.TextBox txt_kitapSayfaSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_kitapTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kitapFiyati;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_kitapKonusu;
        private System.Windows.Forms.Label lbl_konuKarakterSayisi;
        private System.Windows.Forms.ComboBox cmb_kitapAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radiobtn_AraAc;
        private System.Windows.Forms.RadioButton radiobtn_AraKapat;
        private System.Windows.Forms.PictureBox picturebx_kitapResmi;
        private System.Windows.Forms.TextBox txt_resimKonumu;
        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.PictureBox picturebx_qrCode;
        private System.Windows.Forms.TextBox txt_qrName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_resimDosyasiMi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_kitapOku;
        private System.Windows.Forms.LinkLabel linklbl_kitapOku;
        private System.Windows.Forms.Timer timer_kitapOku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_zoom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_kategoriAra;
    }
}

