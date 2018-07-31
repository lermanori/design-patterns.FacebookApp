namespace Ex01.FacebookAppWinformsUI
{
    partial class FormFacebookApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxUploadPost = new System.Windows.Forms.TextBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonPostPhoto = new System.Windows.Forms.Button();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.pictureBoxPostPhotoPreviewImage = new System.Windows.Forms.PictureBox();
            this.labelPostPhotoPreview = new System.Windows.Forms.Label();
            this.buttonPostLink = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxDescriptionOfGroup = new System.Windows.Forms.TextBox();
            this.labelDescriptionOfGroups = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.comboBoxWebBrowser = new System.Windows.Forms.ComboBox();
            this.buttonSubmitUrl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1872, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLoginClick);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 25;
            this.listBoxGroups.Location = new System.Drawing.Point(18, 41);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(250, 179);
            this.listBoxGroups.TabIndex = 2;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Enabled = false;
            this.buttonLogOut.Location = new System.Drawing.Point(1872, 141);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(112, 58);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1632, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(1220, 72);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(328, 59);
            this.buttonPostStatus.TabIndex = 5;
            this.buttonPostStatus.Text = "post status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_click);
            // 
            // textBox2
            // 
            this.textBoxUploadPost.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxUploadPost.Location = new System.Drawing.Point(1220, 169);
            this.textBoxUploadPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUploadPost.Multiline = true;
            this.textBoxUploadPost.Name = "textBox2";
            this.textBoxUploadPost.Size = new System.Drawing.Size(326, 90);
            this.textBoxUploadPost.TabIndex = 6;
            this.textBoxUploadPost.Text = "enter post here";
            this.textBoxUploadPost.Click += new System.EventHandler(this.textBoxUploadPost_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Enabled = false;
            this.buttonFetchGroups.Location = new System.Drawing.Point(608, 41);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(170, 55);
            this.buttonFetchGroups.TabIndex = 7;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(1658, 508);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(244, 31);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Enter Title";
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // buttonPostPhoto
            // 
            this.buttonPostPhoto.Enabled = false;
            this.buttonPostPhoto.Location = new System.Drawing.Point(1672, 672);
            this.buttonPostPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPostPhoto.Name = "buttonPostPhoto";
            this.buttonPostPhoto.Size = new System.Drawing.Size(210, 56);
            this.buttonPostPhoto.TabIndex = 8;
            this.buttonPostPhoto.Text = "Post Photo";
            this.buttonPostPhoto.UseVisualStyleBackColor = true;
            this.buttonPostPhoto.Click += new System.EventHandler(this.buttonPostPhoto_Click);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Enabled = false;
            this.buttonChoosePhoto.Location = new System.Drawing.Point(1658, 427);
            this.buttonChoosePhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(250, 72);
            this.buttonChoosePhoto.TabIndex = 11;
            this.buttonChoosePhoto.Text = "Choose Photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // pictureBoxPostPhotoPreviewImage
            // 
            this.pictureBoxPostPhotoPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPostPhotoPreviewImage.Location = new System.Drawing.Point(1293, 422);
            this.pictureBoxPostPhotoPreviewImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPostPhotoPreviewImage.Name = "pictureBoxPostPhotoPreviewImage";
            this.pictureBoxPostPhotoPreviewImage.Size = new System.Drawing.Size(337, 304);
            this.pictureBoxPostPhotoPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPhotoPreviewImage.TabIndex = 12;
            this.pictureBoxPostPhotoPreviewImage.TabStop = false;
            // 
            // labelPostPhotoPreview
            // 
            this.labelPostPhotoPreview.AutoSize = true;
            this.labelPostPhotoPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostPhotoPreview.Location = new System.Drawing.Point(1288, 391);
            this.labelPostPhotoPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostPhotoPreview.Name = "labelPostPhotoPreview";
            this.labelPostPhotoPreview.Size = new System.Drawing.Size(88, 25);
            this.labelPostPhotoPreview.TabIndex = 13;
            this.labelPostPhotoPreview.Text = "Preview";
            // 
            // buttonPostLink
            // 
            this.buttonPostLink.Location = new System.Drawing.Point(902, 716);
            this.buttonPostLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPostLink.Name = "buttonPostLink";
            this.buttonPostLink.Size = new System.Drawing.Size(170, 66);
            this.buttonPostLink.TabIndex = 14;
            this.buttonPostLink.Text = "Post Link";
            this.buttonPostLink.UseVisualStyleBackColor = true;
            this.buttonPostLink.Click += new System.EventHandler(this.buttonPostLink_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxRememberUser.Enabled = false;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(1248, 133);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(184, 29);
            this.checkBoxRememberUser.TabIndex = 16;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(18, 316);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1218, 390);
            this.webBrowser.TabIndex = 15;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // textBoxDescriptionOfGroup
            // 
            this.textBoxDescriptionOfGroup.Location = new System.Drawing.Point(312, 41);
            this.textBoxDescriptionOfGroup.Multiline = true;
            this.textBoxDescriptionOfGroup.Name = "textBoxDescriptionOfGroup";
            this.textBoxDescriptionOfGroup.Size = new System.Drawing.Size(254, 179);
            this.textBoxDescriptionOfGroup.TabIndex = 16;
            // 
            // labelDescriptionOfGroups
            // 
            this.labelDescriptionOfGroups.AutoSize = true;
            this.labelDescriptionOfGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescriptionOfGroups.Location = new System.Drawing.Point(321, 13);
            this.labelDescriptionOfGroups.Name = "labelDescriptionOfGroups";
            this.labelDescriptionOfGroups.Size = new System.Drawing.Size(120, 25);
            this.labelDescriptionOfGroups.TabIndex = 17;
            this.labelDescriptionOfGroups.Text = "Description";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroups.Location = new System.Drawing.Point(13, 13);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(82, 25);
            this.labelGroups.TabIndex = 18;
            this.labelGroups.Text = "Groups";
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
            this.comboBoxWebBrowser.Location = new System.Drawing.Point(28, 242);
            this.comboBoxWebBrowser.Name = "comboBoxWebBrowser";
            this.comboBoxWebBrowser.Size = new System.Drawing.Size(1161, 33);
            this.comboBoxWebBrowser.TabIndex = 19;
            this.comboBoxWebBrowser.Text = "choose from list or enter your own";
            this.comboBoxWebBrowser.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebBrowser_SelectedIndexChanged);
            this.comboBoxWebBrowser.Click += new System.EventHandler(this.comboBoxWebBrowser_Click);
            // 
            // buttonSubmitUrl
            // 
            this.buttonSubmitUrl.Location = new System.Drawing.Point(1051, 170);
            this.buttonSubmitUrl.Name = "buttonSubmitUrl";
            this.buttonSubmitUrl.Size = new System.Drawing.Size(138, 50);
            this.buttonSubmitUrl.TabIndex = 20;
            this.buttonSubmitUrl.Text = "submit url";
            this.buttonSubmitUrl.UseVisualStyleBackColor = true;
            this.buttonSubmitUrl.Click += new System.EventHandler(this.buttonSubmitUrl_onClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1970, 977);
            this.Controls.Add(this.buttonSubmitUrl);
            this.Controls.Add(this.comboBoxWebBrowser);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelDescriptionOfGroups);
            this.Controls.Add(this.textBoxDescriptionOfGroup);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonPostLink);
            this.Controls.Add(this.labelPostPhotoPreview);
            this.Controls.Add(this.pictureBoxPostPhotoPreviewImage);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonPostPhoto);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.textBoxUploadPost);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxUploadPost;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonPostPhoto;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPostPhotoPreviewImage;
        private System.Windows.Forms.Label labelPostPhotoPreview;
        private System.Windows.Forms.Button buttonPostLink;

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox textBoxDescriptionOfGroup;
        private System.Windows.Forms.Label labelDescriptionOfGroups;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.ComboBox comboBoxWebBrowser;
        private System.Windows.Forms.Button buttonSubmitUrl;

        private System.Windows.Forms.CheckBox checkBoxRememberUser;

    }
}

