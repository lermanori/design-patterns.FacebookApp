namespace Ex01.FacebookAppWinformsUI
{
    partial class Alm
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
            this.tabControlGeo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxPictures = new System.Windows.Forms.TextBox();
            this.textBoxCheckins = new System.Windows.Forms.TextBox();
            this.buttonFetchGeo = new System.Windows.Forms.Button();
            this.gMapUserFriends = new GMap.NET.WindowsForms.GMapControl();
            this.labelFriendBio = new System.Windows.Forms.Label();
            this.textBoxFriendBio = new System.Windows.Forms.TextBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.buttonAddNewAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).BeginInit();
            this.tabControlGeo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1234, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLoginClick);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(30, 43);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(168, 164);
            this.listBoxGroups.TabIndex = 2;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Enabled = false;
            this.buttonLogOut.Location = new System.Drawing.Point(1234, 74);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 37);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1012, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(626, 117);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(219, 38);
            this.buttonPostStatus.TabIndex = 5;
            this.buttonPostStatus.Text = "post status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_click);
            // 
            // textBoxUploadPost
            // 
            this.textBoxUploadPost.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxUploadPost.Location = new System.Drawing.Point(626, 21);
            this.textBoxUploadPost.Multiline = true;
            this.textBoxUploadPost.Name = "textBoxUploadPost";
            this.textBoxUploadPost.Size = new System.Drawing.Size(219, 90);
            this.textBoxUploadPost.TabIndex = 6;
            this.textBoxUploadPost.Text = "enter post here";
            this.textBoxUploadPost.Click += new System.EventHandler(this.textBoxUploadPost_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Enabled = false;
            this.buttonFetchGroups.Location = new System.Drawing.Point(435, 43);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(113, 35);
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
            this.textBoxTitle.Location = new System.Drawing.Point(1141, 378);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(149, 22);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Enter Title";
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // buttonPostPhoto
            // 
            this.buttonPostPhoto.Enabled = false;
            this.buttonPostPhoto.Location = new System.Drawing.Point(1141, 525);
            this.buttonPostPhoto.Name = "buttonPostPhoto";
            this.buttonPostPhoto.Size = new System.Drawing.Size(103, 36);
            this.buttonPostPhoto.TabIndex = 8;
            this.buttonPostPhoto.Text = "Post Photo";
            this.buttonPostPhoto.UseVisualStyleBackColor = true;
            this.buttonPostPhoto.Click += new System.EventHandler(this.buttonPostPhoto_Click);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Enabled = false;
            this.buttonChoosePhoto.Location = new System.Drawing.Point(1141, 267);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(114, 29);
            this.buttonChoosePhoto.TabIndex = 11;
            this.buttonChoosePhoto.Text = "Choose Photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // pictureBoxPostPhotoPreviewImage
            // 
            this.pictureBoxPostPhotoPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPostPhotoPreviewImage.Location = new System.Drawing.Point(824, 267);
            this.pictureBoxPostPhotoPreviewImage.Name = "pictureBoxPostPhotoPreviewImage";
            this.pictureBoxPostPhotoPreviewImage.Size = new System.Drawing.Size(311, 294);
            this.pictureBoxPostPhotoPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPhotoPreviewImage.TabIndex = 12;
            this.pictureBoxPostPhotoPreviewImage.TabStop = false;
            // 
            // labelPostPhotoPreview
            // 
            this.labelPostPhotoPreview.AutoSize = true;
            this.labelPostPhotoPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostPhotoPreview.Location = new System.Drawing.Point(821, 242);
            this.labelPostPhotoPreview.Name = "labelPostPhotoPreview";
            this.labelPostPhotoPreview.Size = new System.Drawing.Size(57, 17);
            this.labelPostPhotoPreview.TabIndex = 13;
            this.labelPostPhotoPreview.Text = "Preview";
            // 
            // buttonPostLink
            // 
            this.buttonPostLink.Enabled = false;
            this.buttonPostLink.Location = new System.Drawing.Point(644, 231);
            this.buttonPostLink.Name = "buttonPostLink";
            this.buttonPostLink.Size = new System.Drawing.Size(124, 28);
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
            this.checkBoxRememberUser.Location = new System.Drawing.Point(1187, 127);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberUser.TabIndex = 16;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(23, 267);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(745, 250);
            this.webBrowser.TabIndex = 15;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // textBoxDescriptionOfGroup
            // 
            this.textBoxDescriptionOfGroup.Location = new System.Drawing.Point(214, 43);
            this.textBoxDescriptionOfGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescriptionOfGroup.Multiline = true;
            this.textBoxDescriptionOfGroup.Name = "textBoxDescriptionOfGroup";
            this.textBoxDescriptionOfGroup.Size = new System.Drawing.Size(204, 164);
            this.textBoxDescriptionOfGroup.TabIndex = 16;
            // 
            // labelDescriptionOfGroups
            // 
            this.labelDescriptionOfGroups.AutoSize = true;
            this.labelDescriptionOfGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescriptionOfGroups.Location = new System.Drawing.Point(211, 17);
            this.labelDescriptionOfGroups.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionOfGroups.Name = "labelDescriptionOfGroups";
            this.labelDescriptionOfGroups.Size = new System.Drawing.Size(79, 17);
            this.labelDescriptionOfGroups.TabIndex = 17;
            this.labelDescriptionOfGroups.Text = "Description";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroups.Location = new System.Drawing.Point(27, 17);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(55, 17);
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
            this.comboBoxWebBrowser.Location = new System.Drawing.Point(23, 231);
            this.comboBoxWebBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWebBrowser.Name = "comboBoxWebBrowser";
            this.comboBoxWebBrowser.Size = new System.Drawing.Size(616, 24);
            this.comboBoxWebBrowser.TabIndex = 19;
            this.comboBoxWebBrowser.Text = "choose from list or enter your own";
            this.comboBoxWebBrowser.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebBrowser_SelectedIndexChanged);
            this.comboBoxWebBrowser.Click += new System.EventHandler(this.comboBoxWebBrowser_Click);
            // 
            // buttonSubmitUrl
            // 
            this.buttonSubmitUrl.Location = new System.Drawing.Point(499, 195);
            this.buttonSubmitUrl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmitUrl.Name = "buttonSubmitUrl";
            this.buttonSubmitUrl.Size = new System.Drawing.Size(92, 32);
            this.buttonSubmitUrl.TabIndex = 20;
            this.buttonSubmitUrl.Text = "submit url";
            this.buttonSubmitUrl.UseVisualStyleBackColor = true;
            this.buttonSubmitUrl.Click += new System.EventHandler(this.buttonSubmitUrl_onClick);
            // 
            // tabControlGeo
            // 
            this.tabControlGeo.Controls.Add(this.tabPage1);
            this.tabControlGeo.Controls.Add(this.tabPage2);
            this.tabControlGeo.Controls.Add(this.tabPage3);
            this.tabControlGeo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControlGeo.Location = new System.Drawing.Point(1, 2);
            this.tabControlGeo.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGeo.Name = "tabControlGeo";
            this.tabControlGeo.SelectedIndex = 0;
            this.tabControlGeo.Size = new System.Drawing.Size(1325, 599);
            this.tabControlGeo.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlGeo.TabIndex = 21;
            this.tabControlGeo.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.buttonLogOut);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.checkBoxRememberUser);
            this.tabPage1.Controls.Add(this.buttonSubmitUrl);
            this.tabPage1.Controls.Add(this.buttonPostStatus);
            this.tabPage1.Controls.Add(this.textBoxUploadPost);
            this.tabPage1.Controls.Add(this.labelGroups);
            this.tabPage1.Controls.Add(this.labelDescriptionOfGroups);
            this.tabPage1.Controls.Add(this.labelPostPhotoPreview);
            this.tabPage1.Controls.Add(this.buttonPostLink);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.buttonChoosePhoto);
            this.tabPage1.Controls.Add(this.pictureBoxPostPhotoPreviewImage);
            this.tabPage1.Controls.Add(this.comboBoxWebBrowser);
            this.tabPage1.Controls.Add(this.buttonPostPhoto);
            this.tabPage1.Controls.Add(this.textBoxDescriptionOfGroup);
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Controls.Add(this.buttonFetchGroups);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1317, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1317, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxPictures);
            this.panel1.Controls.Add(this.textBoxCheckins);
            this.panel1.Controls.Add(this.buttonFetchGeo);
            this.panel1.Controls.Add(this.gMapUserFriends);
            this.panel1.Controls.Add(this.labelFriendBio);
            this.panel1.Controls.Add(this.textBoxFriendBio);
            this.panel1.Controls.Add(this.listBoxFriends);
            this.panel1.Controls.Add(this.buttonFetchFriends);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 557);
            this.panel1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 16);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(158, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 105);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxPictures
            // 
            this.textBoxPictures.Location = new System.Drawing.Point(261, 131);
            this.textBoxPictures.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPictures.Multiline = true;
            this.textBoxPictures.Name = "textBoxPictures";
            this.textBoxPictures.Size = new System.Drawing.Size(153, 68);
            this.textBoxPictures.TabIndex = 26;
            // 
            // textBoxCheckins
            // 
            this.textBoxCheckins.Location = new System.Drawing.Point(261, 49);
            this.textBoxCheckins.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCheckins.Multiline = true;
            this.textBoxCheckins.Name = "textBoxCheckins";
            this.textBoxCheckins.Size = new System.Drawing.Size(153, 68);
            this.textBoxCheckins.TabIndex = 25;
            // 
            // buttonFetchGeo
            // 
            this.buttonFetchGeo.Location = new System.Drawing.Point(411, 16);
            this.buttonFetchGeo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchGeo.Name = "buttonFetchGeo";
            this.buttonFetchGeo.Size = new System.Drawing.Size(60, 17);
            this.buttonFetchGeo.TabIndex = 24;
            this.buttonFetchGeo.Text = "iSpy";
            this.buttonFetchGeo.UseVisualStyleBackColor = true;
            // 
            // gMapUserFriends
            // 
            this.gMapUserFriends.Bearing = 0F;
            this.gMapUserFriends.CanDragMap = true;
            this.gMapUserFriends.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapUserFriends.GrayScaleMode = false;
            this.gMapUserFriends.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapUserFriends.LevelsKeepInMemmory = 5;
            this.gMapUserFriends.Location = new System.Drawing.Point(534, 29);
            this.gMapUserFriends.Margin = new System.Windows.Forms.Padding(2);
            this.gMapUserFriends.MarkersEnabled = true;
            this.gMapUserFriends.MaxZoom = 18;
            this.gMapUserFriends.MinZoom = 2;
            this.gMapUserFriends.MouseWheelZoomEnabled = true;
            this.gMapUserFriends.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapUserFriends.Name = "gMapUserFriends";
            this.gMapUserFriends.NegativeMode = false;
            this.gMapUserFriends.PolygonsEnabled = true;
            this.gMapUserFriends.RetryLoadTile = 0;
            this.gMapUserFriends.RoutesEnabled = true;
            this.gMapUserFriends.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapUserFriends.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapUserFriends.ShowTileGridLines = true;
            this.gMapUserFriends.Size = new System.Drawing.Size(308, 271);
            this.gMapUserFriends.TabIndex = 21;
            this.gMapUserFriends.Zoom = 5D;
            // 
            // labelFriendBio
            // 
            this.labelFriendBio.AutoSize = true;
            this.labelFriendBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendBio.Location = new System.Drawing.Point(11, 117);
            this.labelFriendBio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendBio.Name = "labelFriendBio";
            this.labelFriendBio.Size = new System.Drawing.Size(155, 18);
            this.labelFriendBio.TabIndex = 20;
            this.labelFriendBio.Text = "Selected Friend Bio";
            // 
            // textBoxFriendBio
            // 
            this.textBoxFriendBio.Location = new System.Drawing.Point(13, 131);
            this.textBoxFriendBio.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFriendBio.Multiline = true;
            this.textBoxFriendBio.Name = "textBoxFriendBio";
            this.textBoxFriendBio.Size = new System.Drawing.Size(143, 106);
            this.textBoxFriendBio.TabIndex = 17;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(13, 10);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(143, 100);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(13, 308);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(76, 21);
            this.buttonFetchFriends.TabIndex = 2;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxTasks);
            this.tabPage3.Controls.Add(this.listBoxActions);
            this.tabPage3.Controls.Add(this.buttonAddNewAction);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1317, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(24, 22);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(816, 484);
            this.listBoxTasks.TabIndex = 4;
            // 
            // listBoxActions
            // 
            this.listBoxActions.DisplayMember = "text";
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.ItemHeight = 16;
            this.listBoxActions.Location = new System.Drawing.Point(896, 22);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(254, 292);
            this.listBoxActions.TabIndex = 3;
            // 
            // buttonAddNewAction
            // 
            this.buttonAddNewAction.Location = new System.Drawing.Point(896, 425);
            this.buttonAddNewAction.Name = "buttonAddNewAction";
            this.buttonAddNewAction.Size = new System.Drawing.Size(254, 81);
            this.buttonAddNewAction.TabIndex = 2;
            this.buttonAddNewAction.Text = "Add New Action";
            this.buttonAddNewAction.UseVisualStyleBackColor = true;
            this.buttonAddNewAction.Click += new System.EventHandler(this.buttonAddNewCommand_Click);
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1328, 612);
            this.Controls.Add(this.tabControlGeo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormFacebookApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tabPage3_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).EndInit();
            this.tabControlGeo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControlGeo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox textBoxFriendBio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFriendBio;
        private GMap.NET.WindowsForms.GMapControl gMapUserFriends;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAddNewAction;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.ListBox listBoxTasks;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPictures;
        private System.Windows.Forms.TextBox textBoxCheckins;
        private System.Windows.Forms.Button buttonFetchGeo;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}

