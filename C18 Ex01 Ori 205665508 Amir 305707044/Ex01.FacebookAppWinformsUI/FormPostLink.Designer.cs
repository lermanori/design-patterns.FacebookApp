namespace Ex01.FacebookAppWinformsUI
{
    partial class FormPostLink
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
            this.buttonSubmitUrl = new System.Windows.Forms.Button();
            this.comboBoxWebBrowser = new System.Windows.Forms.ComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.labelUploadPhoto = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerPost = new System.Windows.Forms.DateTimePicker();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmitUrl
            // 
            this.buttonSubmitUrl.Location = new System.Drawing.Point(1122, 133);
            this.buttonSubmitUrl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitUrl.Name = "buttonSubmitUrl";
            this.buttonSubmitUrl.Size = new System.Drawing.Size(443, 39);
            this.buttonSubmitUrl.TabIndex = 26;
            this.buttonSubmitUrl.Text = "Submit URL";
            this.buttonSubmitUrl.UseVisualStyleBackColor = true;
            this.buttonSubmitUrl.Click += new System.EventHandler(this.buttonSubmitUrl_onClick);
            // 
            // comboBoxWebBrowser
            // 
            this.comboBoxWebBrowser.FormattingEnabled = true;
            this.comboBoxWebBrowser.Items.AddRange(new object[] {
            "http://www.google.com/",
            "http://www.facebook.com/",
            "http://www.youtube.com/",
            "http://www.giphy.com/",
            "http://www.soundcloud.com/"});
            this.comboBoxWebBrowser.Location = new System.Drawing.Point(74, 133);
            this.comboBoxWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWebBrowser.Name = "comboBoxWebBrowser";
            this.comboBoxWebBrowser.Size = new System.Drawing.Size(1036, 39);
            this.comboBoxWebBrowser.TabIndex = 25;
            this.comboBoxWebBrowser.Text = "choose from list or enter your own";
            this.comboBoxWebBrowser.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebBrowser_SelectedIndexChanged);
            this.comboBoxWebBrowser.Click += new System.EventHandler(this.comboBoxWebBrowser_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(74, 192);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.webBrowser.MinimumSize = new System.Drawing.Size(40, 38);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1491, 511);
            this.webBrowser.TabIndex = 24;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // labelUploadPhoto
            // 
            this.labelUploadPhoto.AutoSize = true;
            this.labelUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUploadPhoto.ForeColor = System.Drawing.Color.Black;
            this.labelUploadPhoto.Location = new System.Drawing.Point(420, 30);
            this.labelUploadPhoto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUploadPhoto.Name = "labelUploadPhoto";
            this.labelUploadPhoto.Size = new System.Drawing.Size(676, 39);
            this.labelUploadPhoto.TabIndex = 28;
            this.labelUploadPhoto.Text = "Choose A Link and choose time and date";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(74, 800);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(1491, 97);
            this.buttonSubmit.TabIndex = 32;
            this.buttonSubmit.Text = "submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dateTimePickerPost
            // 
            this.dateTimePickerPost.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePickerPost.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerPost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPost.Location = new System.Drawing.Point(798, 732);
            this.dateTimePickerPost.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerPost.Name = "dateTimePickerPost";
            this.dateTimePickerPost.Size = new System.Drawing.Size(767, 38);
            this.dateTimePickerPost.TabIndex = 31;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(74, 732);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(692, 38);
            this.textBoxTitle.TabIndex = 30;
            this.textBoxTitle.Text = "Enter Title";
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // FormPostLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 953);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dateTimePickerPost);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelUploadPhoto);
            this.Controls.Add(this.buttonSubmitUrl);
            this.Controls.Add(this.comboBoxWebBrowser);
            this.Controls.Add(this.webBrowser);
            this.Name = "FormPostLink";
            this.Text = "Post Link";
            this.Load += new System.EventHandler(this.FormPostLink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmitUrl;
        private System.Windows.Forms.ComboBox comboBoxWebBrowser;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelUploadPhoto;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerPost;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}