namespace downloader
{
    partial class YoutubeDowloaderAndConverter
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
            this.textURL = new System.Windows.Forms.TextBox();
            this.PasteTheLink = new System.Windows.Forms.Label();
            this.buttonDownloadM4 = new System.Windows.Forms.Button();
            this.DowloadYoutubeVideo = new System.Windows.Forms.Label();
            this.ConvertMP4ToMP3 = new System.Windows.Forms.Label();
            this.folderBrowserForConvertingVideo = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonDowloadMP3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserForSavingTheFile = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonToSaveThePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(221, 56);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(540, 22);
            this.textURL.TabIndex = 0;
            this.textURL.TextChanged += new System.EventHandler(this.textURL_TextChanged);
            // 
            // PasteTheLink
            // 
            this.PasteTheLink.AutoSize = true;
            this.PasteTheLink.Location = new System.Drawing.Point(12, 61);
            this.PasteTheLink.Name = "PasteTheLink";
            this.PasteTheLink.Size = new System.Drawing.Size(190, 17);
            this.PasteTheLink.TabIndex = 1;
            this.PasteTheLink.Text = "Paste The Link To Download";
            // 
            // buttonDownloadM4
            // 
            this.buttonDownloadM4.Location = new System.Drawing.Point(560, 128);
            this.buttonDownloadM4.Name = "buttonDownloadM4";
            this.buttonDownloadM4.Size = new System.Drawing.Size(197, 23);
            this.buttonDownloadM4.TabIndex = 2;
            this.buttonDownloadM4.Text = "Click To Download MP4";
            this.buttonDownloadM4.UseVisualStyleBackColor = true;
            this.buttonDownloadM4.Click += new System.EventHandler(this.buttonDownloadM4_Click);
            // 
            // DowloadYoutubeVideo
            // 
            this.DowloadYoutubeVideo.AutoSize = true;
            this.DowloadYoutubeVideo.Location = new System.Drawing.Point(333, 9);
            this.DowloadYoutubeVideo.Name = "DowloadYoutubeVideo";
            this.DowloadYoutubeVideo.Size = new System.Drawing.Size(159, 17);
            this.DowloadYoutubeVideo.TabIndex = 3;
            this.DowloadYoutubeVideo.Text = "Dowload Youtube Video";
            // 
            // ConvertMP4ToMP3
            // 
            this.ConvertMP4ToMP3.AutoSize = true;
            this.ConvertMP4ToMP3.Location = new System.Drawing.Point(333, 229);
            this.ConvertMP4ToMP3.Name = "ConvertMP4ToMP3";
            this.ConvertMP4ToMP3.Size = new System.Drawing.Size(142, 17);
            this.ConvertMP4ToMP3.TabIndex = 4;
            this.ConvertMP4ToMP3.Text = "Convert MP4 To MP3";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(560, 273);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(197, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Browse the Video to Convert";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(560, 337);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(201, 23);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Click To Convert the Video";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // buttonDowloadMP3
            // 
            this.buttonDowloadMP3.Location = new System.Drawing.Point(217, 128);
            this.buttonDowloadMP3.Name = "buttonDowloadMP3";
            this.buttonDowloadMP3.Size = new System.Drawing.Size(174, 23);
            this.buttonDowloadMP3.TabIndex = 7;
            this.buttonDowloadMP3.Text = "Click To Download MP3";
            this.buttonDowloadMP3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Videos will be saved to  path you have selected";
            // 
            // buttonToSaveThePath
            // 
            this.buttonToSaveThePath.Location = new System.Drawing.Point(300, 84);
            this.buttonToSaveThePath.Name = "buttonToSaveThePath";
            this.buttonToSaveThePath.Size = new System.Drawing.Size(243, 23);
            this.buttonToSaveThePath.TabIndex = 9;
            this.buttonToSaveThePath.Text = "browse the path to save the video";
            this.buttonToSaveThePath.UseVisualStyleBackColor = true;
            // 
            // YoutubeDowloaderAndConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToSaveThePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDowloadMP3);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.ConvertMP4ToMP3);
            this.Controls.Add(this.DowloadYoutubeVideo);
            this.Controls.Add(this.buttonDownloadM4);
            this.Controls.Add(this.PasteTheLink);
            this.Controls.Add(this.textURL);
            this.Name = "YoutubeDowloaderAndConverter";
            this.Text = "Youtube Dowloader And Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label PasteTheLink;
        private System.Windows.Forms.Button buttonDownloadM4;
        private System.Windows.Forms.Label DowloadYoutubeVideo;
        private System.Windows.Forms.Label ConvertMP4ToMP3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserForConvertingVideo;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonDowloadMP3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserForSavingTheFile;
        private System.Windows.Forms.Button buttonToSaveThePath;
    }
}

