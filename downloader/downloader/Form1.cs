using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;

namespace downloader
{
    public partial class YoutubeDowloaderAndConverter : Form
    {
        string pathToSaveVideos;

        public YoutubeDowloaderAndConverter()
        {
            InitializeComponent();
        }

        private void textURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool Check()
        {
            if (string.IsNullOrEmpty(textURL.Text))
            {
                MessageBox.Show("paste the link");
            }
            if (string.IsNullOrEmpty(pathToSaveVideos))
            {
                MessageBox.Show("Browse the path to save videos");
            }

            if(!string.IsNullOrEmpty(textURL.Text)&&!string.IsNullOrEmpty(textURL.Text))
            {
                return true;
            }
            return false;
        }
        

        private void buttonToSaveThePath_Click(object sender, EventArgs e)
        {
            if(folderBrowserForConvertingVideo.ShowDialog()==DialogResult.OK)
            {
                pathToSaveVideos = folderBrowserForConvertingVideo.SelectedPath;
            }
        }
        private async Task DownloadAsync(string type)
        {
            if (Check())
            {
                var client = new YoutubeClient();
                var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(textURL.Text);
                var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();
                await client.DownloadMediaStreamAsync(streamInfo, pathToSaveVideos + streamInfo.ToString() + "."+type);
            }
        }
        private void Show()
        {
            if(Check())
            MessageBox.Show("Downloaded!!" + pathToSaveVideos);
        }
        private async void buttonDownloadMp4_ClickAsync(object sender, EventArgs e)
        {
            await DownloadAsync("mp4");
            Show();
        }

        private async void buttonDowloadMp3_ClickAsync(object sender, EventArgs e)
        {
            await DownloadAsync("mp3");
            Show();
        }
    }
}
