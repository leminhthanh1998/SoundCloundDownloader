using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundcloud_Downloader
{
    class MyMessage
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            if (button == System.Windows.Forms.MessageBoxButtons.OK)
            {
                using (frmMessage frmMessage = new frmMessage())
                {
                    frmMessage.MessageTitle = caption;
                    frmMessage.MessageText = message;
                    switch (icon)
                    {
                        case System.Windows.Forms.MessageBoxIcon.Information:
                            frmMessage.MessageIcon = Properties.Resources.Information_96;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Error:
                            frmMessage.MessageIcon = Properties.Resources.Error_96;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Question:
                            frmMessage.MessageIcon = Properties.Resources.Ask_Question_96;
                            break;
                    }
                    dlgResult = frmMessage.ShowDialog();
                }
            }

            return dlgResult;
        }
    }
}
