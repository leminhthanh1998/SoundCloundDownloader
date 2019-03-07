using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundcloud_Downloader
{
    public partial class Download : Form
    {
        public Download(List<string>dsFileName, List<string>dsLinkDownload, string namePlaylist, string nameTrack, double fileSize, bool isPlaylist, bool ckbAmbao)
        {
            InitializeComponent();
            _dsFileName = dsFileName;
            _dsLinkDownload = dsLinkDownload;
            _namePlaylist = namePlaylist;
            _nameTrack = nameTrack;
            _fileSize = fileSize;
            _isPlaylist = isPlaylist;
            _ckbAmBao = ckbAmbao;
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            wc2.DownloadProgressChanged += Wc2_DownloadProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.DoWork += Worker_DoWork;
            worker.WorkerSupportsCancellation = true;
        }

#region Worker
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            foreach (string item in _dsLinkDownload)
            {
                if (worker.CancellationPending == true) break;
                labelName.Invoke(new MethodInvoker(delegate { labelName.Text = _dsFileName[i]; }));
                
                wc2.DownloadFileAsync(new Uri(item), folderPath + "\\" + _dsFileName[i]);
                
                i++;
                while (wc2.IsBusy)
                {
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGo.Enabled=btnFolder.Enabled = true;
            btnCancel.Visible = false;
            if (_ckbAmBao)
            { player.Play(); }
            if (canceldownload)
            {
                MyMessage.ShowMessage("         Đã hủy tải về!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MyMessage.ShowMessage("        Đã tải về thành công!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Wc2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                double receive = double.Parse(e.BytesReceived.ToString());
                double totalSize = double.Parse(e.TotalBytesToReceive.ToString());
                double phanTram = receive / totalSize * 100;
                progress.Invoke(new MethodInvoker(delegate { progress.Value = int.Parse(Math.Truncate(phanTram).ToString()); }));
                labelDownloading.Invoke(new MethodInvoker(delegate { labelDownloading.Text = string.Format("{0:0.##} MB", receive / 1024 / 1024); }));
            }
            catch (Exception)
            {

            }
        }
#endregion

        #region Download
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnCancel.Visible = false;
            btnGo.Enabled=btnFolder.Enabled = true;
            if (_ckbAmBao) player.Play();
            if (canceldownload)
            {
                MyMessage.ShowMessage("         Đã hủy tải về!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MyMessage.ShowMessage("        Đã tải về thành công!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
            double receive = double.Parse(e.BytesReceived.ToString());
            labelDownloading.Invoke(new MethodInvoker(delegate { labelDownloading.Text = string.Format("{0:0.##} MB", receive / 1024 / 1024); }));
        }

#endregion

        #region var
        List<string> _dsLinkDownload = new List<string>();
        List<string> _dsFileName = new List<string>();
        string _namePlaylist;
        string _nameTrack;
        string folderPath;
        double _fileSize = 0;
        WebClient wc = new WebClient();
        WebClient wc2 = new WebClient();
        BackgroundWorker worker = new BackgroundWorker();
        SoundPlayer player = new SoundPlayer(Properties.Resources.beep_07);
        bool _isPlaylist;
        bool _ckbAmBao;
        bool canceldownload = false;
        #endregion

        private void Download_Load(object sender, EventArgs e)
        {
            labelName.MaximumSize = new Size(420, 0);
            labelName.AutoSize = true;
            if(_isPlaylist)
            {
                labelName.Text = _namePlaylist;
                labelSize.Text = string.Format("{0:0.00} MB, {1} tracks", _fileSize, _dsLinkDownload.Count);
            }
            else
            {
                labelName.Text = _nameTrack;
                labelSize.Text = string.Format("{0:0.00} MB", _fileSize, _dsLinkDownload.Count);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (folderPath != null)
            {
                btnGo.Enabled=btnFolder.Enabled = false;
                btnCancel.Visible = true;
                if (_isPlaylist)
                {
                    worker.RunWorkerAsync();
                }
                else
                {
                    wc.DownloadFileAsync(new Uri(_dsLinkDownload[0]), folderPath + "\\" + @_dsFileName[0]);
                }
            }
            else MyMessage.ShowMessage("    Bạn chưa chọn thư mục lưu!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dlg = new FolderSelectDialog();
            dlg.Title = "SoundCloud Downloader";
            if(dlg.ShowDialog()==true)
            {
                folderPath=txbPath.Text = dlg.FileName;
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canceldownload = true;
            wc.CancelAsync();
            worker.CancelAsync();
            wc2.CancelAsync();
        }
    }
}
