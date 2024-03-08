using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_Takip_Sistemi
{
    public partial class QR_Zoom : Form
    {
        public QR_Zoom()
        {
            InitializeComponent();
        }
        public static Image zoom;
        private void QR_Zoom_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = zoom;
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
