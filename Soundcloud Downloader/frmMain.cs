using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace Soundcloud_Downloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.DoWork += Worker_DoWork;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                GetLinkStream();
                GetLinkDownload();
            }
            catch (Exception)
            {
               
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGo.Enabled = btnPaste.Enabled = true;
            progress.animated = pictureBoxSoundCloud.Visible = false;
            if (!error && dsLinkDownload.Count>0)
            {
                Download download = new Download(dsFileName, dsLinkDownload, namePlaylist, nameTrack, fileSize, isPlaylist, ckbAmbao.Checked);
                download.ShowDialog();
            }
        }

        #region Var
        string linkSoundCloud;
        List<string> dsLinkDownload = new List<string>();
        List<string> dsLinkStream = new List<string>();
        List<string> dsTitle = new List<string>();
        List<string> dsFileName = new List<string>();
        string clientID = "06e3e204bdd61a0a41d8eaab895cb7df";
        string namePlaylist;
        string nameTrack;
        double fileSize = 0;
        WebClient wc = new WebClient();
        bool isPlaylist=true;
        bool error = false;
        BackgroundWorker worker = new BackgroundWorker();
        #endregion

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().StartsWith("https://soundcloud.com/"))
            {
                txbLink.Text = linkSoundCloud = Clipboard.GetText();
                if (linkSoundCloud.Contains("sets")) isPlaylist = true;
                else isPlaylist = false;
            }
            else MyMessage.ShowMessage("Link bạn nhập không đúng!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// Lay link stream cua cac bai hat
        /// </summary>
        private void GetLinkStream()
        {
            dynamic json;
            string sourceWeb;
            string link = "http://api.soundcloud.com/resolve.json?url=" + linkSoundCloud + "&client_id=" + clientID;
            wc.Encoding = Encoding.UTF8;
            try
            {
                sourceWeb= wc.DownloadString(link);
            }
            catch (Exception)
            {
                MyMessage.ShowMessage("Không thể tải track về từ link này!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }
            
            try
            {
                json = JObject.Parse(sourceWeb);
            }
            catch (Exception)
            {
                if(isPlaylist)
                    MyMessage.ShowMessage("Không thể tải Playlist này về!\nHãy thử tải từng track riêng xem!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MyMessage.ShowMessage("Không thể tải track về từ link này!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                return;
            }
            
            if(!isPlaylist)
            {
                if(json["kind"]=="user")
                {
                    MyMessage.ShowMessage("Đây là link đến tài khoản người dùng!\nKhông thể tải track về từ link này!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                    return;
                }
                if (Convert.ToString((string)json["stream_url"]).Contains("stream"))
                {
                    nameTrack = (string)json["title"];
                    dsTitle.Add((string)json["title"] + ".mp3");
                    dsLinkStream.Add((string)json["stream_url"]);
                }
                else
                {
                    MyMessage.ShowMessage("Không thể tải về từ link này!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                    return;
                }
            }
            else
            {
                if (json["kind"] == "user")
                {
                    MyMessage.ShowMessage("Đây là link đến tài khoản người dùng!\nKhông thể tải track về từ link này!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                    return;
                }
                namePlaylist = (string)json["title"];
                try
                {
                    for (int i = 0; i < json["tracks"].Count; i++)
                    {
                        if (!Convert.ToString((string)json["tracks"][i]["stream_url"]).Contains("stream"))
                            continue;
                        dsTitle.Add((string)json["tracks"][i]["title"] + ".mp3");
                        dsLinkStream.Add((string)json["tracks"][i]["stream_url"]);
                    }
                }
                catch (Exception)
                {
                    MyMessage.ShowMessage("Không thể tải Playlist này về!\nHãy thử tải từng track riêng xem!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                    return;
                }
            }
        }

        private void GetLinkDownload()
        {
            double filesize = 0;
            if (dsLinkStream.Count > 0 && dsTitle.Count > 0)
            {
                for (int i = 0; i < dsLinkStream.Count; i++)
                {
                    string linkdownload = dsLinkStream[i] + ".json?client_id=" + clientID;
                    filesize = GetFileSize(linkdownload) / 1024 / 1024;
                    if (filesize > 0)
                    {
                        dsLinkDownload.Add(linkdownload);
                        dsFileName.Add(dsTitle[i]);
                        fileSize += filesize;
                    }
                }
                dsFileName = ChuanHoaFileName(dsFileName);
            }
            else throw new Exception("Link tải đã có lỗi!");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(txbLink.Text.StartsWith("https://soundcloud.com/"))
            {
                fileSize = 0;
                error = false;
                dsLinkDownload.Clear(); dsLinkStream.Clear(); dsTitle.Clear(); dsFileName.Clear();
                linkSoundCloud = txbLink.Text;
                if (linkSoundCloud.Contains("sets")) isPlaylist = true;
                else isPlaylist = false;
                btnGo.Enabled=btnPaste.Enabled = false;
                progress.animated=pictureBoxSoundCloud.Visible = true;
                worker.RunWorkerAsync();
            }
            else MyMessage.ShowMessage("    Link bạn nhập không đúng!", "SoundCloud Downloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private double GetFileSize(string link)
        {
            System.Net.WebRequest req = System.Net.HttpWebRequest.Create(link);
            req.Method = "HEAD";
            using (System.Net.WebResponse resp = req.GetResponse())
            {
                double ContentLength;
                if (double.TryParse(resp.Headers.Get("Content-Length"), out ContentLength))
                {
                    return ContentLength;
                }
            }
            return 0;
        }

        private List<string> ChuanHoaFileName(List<string> fileName)
        {
            List<string> result = new List<string>();
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            foreach (string filename in fileName)
            {
                Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                result.Add(r.Replace(filename, ""));
            }

            return result;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYoutbe_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCaEKcwDSrMBHxGA-aCOoSoQ");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:leminhthanh1998@outlook.com");
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Process.Start("http://lêminhthành.vn");
        }
    }
}
