using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundcloud_Downloader
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }
        public string MessageText
        {
            get { return labelText.Text; }
            set { labelText.Text = value; }
        }
        public string MessageTitle
        {
            get { return labelTieude.Text; }
            set { labelTieude.Text = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
