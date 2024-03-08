
namespace Kitap_Takip_Sistemi
{
    partial class Kitap_Oku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Oku));
            this.listbx_kitaplar = new System.Windows.Forms.ListBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbx_kitaplar
            // 
            this.listbx_kitaplar.BackColor = System.Drawing.Color.Moccasin;
            this.listbx_kitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbx_kitaplar.Font = new System.Drawing.Font("Cascadia Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbx_kitaplar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbx_kitaplar.FormattingEnabled = true;
            this.listbx_kitaplar.ItemHeight = 33;
            this.listbx_kitaplar.Location = new System.Drawing.Point(0, 0);
            this.listbx_kitaplar.Name = "listbx_kitaplar";
            this.listbx_kitaplar.Size = new System.Drawing.Size(434, 462);
            this.listbx_kitaplar.TabIndex = 1;
            this.listbx_kitaplar.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listbx_kitaplar_DrawItem);
            this.listbx_kitaplar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbx_kitaplar_MouseDoubleClick);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Red;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(156, 518);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(120, 39);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Kitap_Oku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(432, 568);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.listbx_kitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitap_Oku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP OKU";
            this.Load += new System.EventHandler(this.Kitap_Oku_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbx_kitaplar;
        private System.Windows.Forms.Button btn_geri;
    }
}