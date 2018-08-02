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
            this.tabControlGeo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageGeo = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelNumStatuses = new System.Windows.Forms.Label();
            this.pictureBoxMostActiveUser = new System.Windows.Forms.PictureBox();
            this.labelMostActiveUser = new System.Windows.Forms.Label();
            this.labelMostActive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFriendCountMost = new System.Windows.Forms.Label();
            this.labelFriendCountLeast = new System.Windows.Forms.Label();
            this.labelLeastFriendsUser = new System.Windows.Forms.Label();
            this.labelMostFriendsUser = new System.Windows.Forms.Label();
            this.pictureBoxLeastFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostFriends = new System.Windows.Forms.PictureBox();
            this.labelMostFriends = new System.Windows.Forms.Label();
            this.labelLeastFriends = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDidntEnterBirthday = new System.Windows.Forms.Label();
            this.labelOldestAgeRange = new System.Windows.Forms.Label();
            this.labelAdultAgeRange = new System.Windows.Forms.Label();
            this.labelLowestAgeRange = new System.Windows.Forms.Label();
            this.labelMediumAgeRange = new System.Windows.Forms.Label();
            this.labelAgeRange = new System.Windows.Forms.Label();
            this.buttonCalcStats = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGenderLess = new System.Windows.Forms.Label();
            this.labelWomen = new System.Windows.Forms.Label();
            this.labelMen = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.listBoxFriendCheckins = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxFriendProfilePic = new System.Windows.Forms.PictureBox();
            this.buttonFetchGeo = new System.Windows.Forms.Button();
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
            this.tabPageGeo.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostActiveUser)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostFriends)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePic)).BeginInit();
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
            this.tabControlGeo.Controls.Add(this.tabPageGeo);
            this.tabControlGeo.Controls.Add(this.tabPage3);
            this.tabControlGeo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControlGeo.Location = new System.Drawing.Point(1, 2);
            this.tabControlGeo.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGeo.Name = "tabControlGeo";
            this.tabControlGeo.SelectedIndex = 0;
            this.tabControlGeo.Size = new System.Drawing.Size(1325, 599);
            this.tabControlGeo.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlGeo.TabIndex = 21;
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
            // tabPageGeo
            // 
            this.tabPageGeo.Controls.Add(this.panel5);
            this.tabPageGeo.Controls.Add(this.panel4);
            this.tabPageGeo.Controls.Add(this.panel3);
            this.tabPageGeo.Controls.Add(this.buttonCalcStats);
            this.tabPageGeo.Controls.Add(this.panel2);
            this.tabPageGeo.Controls.Add(this.panel1);
            this.tabPageGeo.Location = new System.Drawing.Point(4, 25);
            this.tabPageGeo.Name = "tabPageGeo";
            this.tabPageGeo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeo.Size = new System.Drawing.Size(1317, 570);
            this.tabPageGeo.TabIndex = 1;
            this.tabPageGeo.Text = "Geo";
            this.tabPageGeo.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelNumStatuses);
            this.panel5.Controls.Add(this.pictureBoxMostActiveUser);
            this.panel5.Controls.Add(this.labelMostActiveUser);
            this.panel5.Controls.Add(this.labelMostActive);
            this.panel5.Location = new System.Drawing.Point(397, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 196);
            this.panel5.TabIndex = 20;
            // 
            // labelNumStatuses
            // 
            this.labelNumStatuses.AutoSize = true;
            this.labelNumStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumStatuses.Location = new System.Drawing.Point(26, 65);
            this.labelNumStatuses.Name = "labelNumStatuses";
            this.labelNumStatuses.Size = new System.Drawing.Size(10, 15);
            this.labelNumStatuses.TabIndex = 6;
            this.labelNumStatuses.Text = "l";
            // 
            // pictureBoxMostActiveUser
            // 
            this.pictureBoxMostActiveUser.Location = new System.Drawing.Point(48, 84);
            this.pictureBoxMostActiveUser.Name = "pictureBoxMostActiveUser";
            this.pictureBoxMostActiveUser.Size = new System.Drawing.Size(128, 109);
            this.pictureBoxMostActiveUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostActiveUser.TabIndex = 5;
            this.pictureBoxMostActiveUser.TabStop = false;
            // 
            // labelMostActiveUser
            // 
            this.labelMostActiveUser.AutoSize = true;
            this.labelMostActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostActiveUser.Location = new System.Drawing.Point(26, 46);
            this.labelMostActiveUser.Name = "labelMostActiveUser";
            this.labelMostActiveUser.Size = new System.Drawing.Size(12, 17);
            this.labelMostActiveUser.TabIndex = 1;
            this.labelMostActiveUser.Text = "l";
            // 
            // labelMostActive
            // 
            this.labelMostActive.AutoSize = true;
            this.labelMostActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostActive.Location = new System.Drawing.Point(16, 19);
            this.labelMostActive.Name = "labelMostActive";
            this.labelMostActive.Size = new System.Drawing.Size(208, 20);
            this.labelMostActive.TabIndex = 0;
            this.labelMostActive.Text = "Who\'s the Most Active?\r\n";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelFriendCountMost);
            this.panel4.Controls.Add(this.labelFriendCountLeast);
            this.panel4.Controls.Add(this.labelLeastFriendsUser);
            this.panel4.Controls.Add(this.labelMostFriendsUser);
            this.panel4.Controls.Add(this.pictureBoxLeastFriends);
            this.panel4.Controls.Add(this.pictureBoxMostFriends);
            this.panel4.Controls.Add(this.labelMostFriends);
            this.panel4.Controls.Add(this.labelLeastFriends);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(996, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 327);
            this.panel4.TabIndex = 21;
            // 
            // labelFriendCountMost
            // 
            this.labelFriendCountMost.AutoSize = true;
            this.labelFriendCountMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendCountMost.Location = new System.Drawing.Point(26, 88);
            this.labelFriendCountMost.Name = "labelFriendCountMost";
            this.labelFriendCountMost.Size = new System.Drawing.Size(14, 15);
            this.labelFriendCountMost.TabIndex = 8;
            this.labelFriendCountMost.Text = "1";
            // 
            // labelFriendCountLeast
            // 
            this.labelFriendCountLeast.AutoSize = true;
            this.labelFriendCountLeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendCountLeast.Location = new System.Drawing.Point(26, 220);
            this.labelFriendCountLeast.Name = "labelFriendCountLeast";
            this.labelFriendCountLeast.Size = new System.Drawing.Size(14, 15);
            this.labelFriendCountLeast.TabIndex = 7;
            this.labelFriendCountLeast.Text = "1";
            // 
            // labelLeastFriendsUser
            // 
            this.labelLeastFriendsUser.AutoSize = true;
            this.labelLeastFriendsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLeastFriendsUser.Location = new System.Drawing.Point(26, 205);
            this.labelLeastFriendsUser.Name = "labelLeastFriendsUser";
            this.labelLeastFriendsUser.Size = new System.Drawing.Size(14, 15);
            this.labelLeastFriendsUser.TabIndex = 6;
            this.labelLeastFriendsUser.Text = "1";
            // 
            // labelMostFriendsUser
            // 
            this.labelMostFriendsUser.AutoSize = true;
            this.labelMostFriendsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostFriendsUser.Location = new System.Drawing.Point(26, 71);
            this.labelMostFriendsUser.Name = "labelMostFriendsUser";
            this.labelMostFriendsUser.Size = new System.Drawing.Size(14, 15);
            this.labelMostFriendsUser.TabIndex = 5;
            this.labelMostFriendsUser.Text = "2";
            // 
            // pictureBoxLeastFriends
            // 
            this.pictureBoxLeastFriends.Location = new System.Drawing.Point(50, 236);
            this.pictureBoxLeastFriends.Name = "pictureBoxLeastFriends";
            this.pictureBoxLeastFriends.Size = new System.Drawing.Size(87, 74);
            this.pictureBoxLeastFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeastFriends.TabIndex = 4;
            this.pictureBoxLeastFriends.TabStop = false;
            // 
            // pictureBoxMostFriends
            // 
            this.pictureBoxMostFriends.Location = new System.Drawing.Point(50, 110);
            this.pictureBoxMostFriends.Name = "pictureBoxMostFriends";
            this.pictureBoxMostFriends.Size = new System.Drawing.Size(87, 74);
            this.pictureBoxMostFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostFriends.TabIndex = 3;
            this.pictureBoxMostFriends.TabStop = false;
            // 
            // labelMostFriends
            // 
            this.labelMostFriends.AutoSize = true;
            this.labelMostFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostFriends.Location = new System.Drawing.Point(37, 55);
            this.labelMostFriends.Name = "labelMostFriends";
            this.labelMostFriends.Size = new System.Drawing.Size(117, 18);
            this.labelMostFriends.TabIndex = 2;
            this.labelMostFriends.Text = "Most Friends: ";
            // 
            // labelLeastFriends
            // 
            this.labelLeastFriends.AutoSize = true;
            this.labelLeastFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLeastFriends.Location = new System.Drawing.Point(37, 187);
            this.labelLeastFriends.Name = "labelLeastFriends";
            this.labelLeastFriends.Size = new System.Drawing.Size(115, 18);
            this.labelLeastFriends.TabIndex = 1;
            this.labelLeastFriends.Text = "Least Friends:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(25, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Socializing...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelDidntEnterBirthday);
            this.panel3.Controls.Add(this.labelOldestAgeRange);
            this.panel3.Controls.Add(this.labelAdultAgeRange);
            this.panel3.Controls.Add(this.labelLowestAgeRange);
            this.panel3.Controls.Add(this.labelMediumAgeRange);
            this.panel3.Controls.Add(this.labelAgeRange);
            this.panel3.Location = new System.Drawing.Point(703, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 283);
            this.panel3.TabIndex = 20;
            // 
            // labelDidntEnterBirthday
            // 
            this.labelDidntEnterBirthday.AutoSize = true;
            this.labelDidntEnterBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDidntEnterBirthday.Location = new System.Drawing.Point(25, 189);
            this.labelDidntEnterBirthday.Name = "labelDidntEnterBirthday";
            this.labelDidntEnterBirthday.Size = new System.Drawing.Size(101, 18);
            this.labelDidntEnterBirthday.TabIndex = 5;
            this.labelDidntEnterBirthday.Text = "Did\'nt Enter:";
            // 
            // labelOldestAgeRange
            // 
            this.labelOldestAgeRange.AutoSize = true;
            this.labelOldestAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelOldestAgeRange.Location = new System.Drawing.Point(25, 155);
            this.labelOldestAgeRange.Name = "labelOldestAgeRange";
            this.labelOldestAgeRange.Size = new System.Drawing.Size(46, 18);
            this.labelOldestAgeRange.TabIndex = 4;
            this.labelOldestAgeRange.Text = "61+: ";
            // 
            // labelAdultAgeRange
            // 
            this.labelAdultAgeRange.AutoSize = true;
            this.labelAdultAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAdultAgeRange.Location = new System.Drawing.Point(25, 122);
            this.labelAdultAgeRange.Name = "labelAdultAgeRange";
            this.labelAdultAgeRange.Size = new System.Drawing.Size(60, 18);
            this.labelAdultAgeRange.TabIndex = 3;
            this.labelAdultAgeRange.Text = "41-60: ";
            // 
            // labelLowestAgeRange
            // 
            this.labelLowestAgeRange.AutoSize = true;
            this.labelLowestAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLowestAgeRange.Location = new System.Drawing.Point(25, 58);
            this.labelLowestAgeRange.Name = "labelLowestAgeRange";
            this.labelLowestAgeRange.Size = new System.Drawing.Size(51, 18);
            this.labelLowestAgeRange.TabIndex = 2;
            this.labelLowestAgeRange.Text = "0-20: ";
            // 
            // labelMediumAgeRange
            // 
            this.labelMediumAgeRange.AutoSize = true;
            this.labelMediumAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMediumAgeRange.Location = new System.Drawing.Point(25, 89);
            this.labelMediumAgeRange.Name = "labelMediumAgeRange";
            this.labelMediumAgeRange.Size = new System.Drawing.Size(60, 18);
            this.labelMediumAgeRange.TabIndex = 1;
            this.labelMediumAgeRange.Text = "21-40: ";
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAgeRange.Location = new System.Drawing.Point(25, 19);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(172, 20);
            this.labelAgeRange.TabIndex = 0;
            this.labelAgeRange.Text = "How Old Are They?";
            // 
            // buttonCalcStats
            // 
            this.buttonCalcStats.Location = new System.Drawing.Point(424, 82);
            this.buttonCalcStats.Name = "buttonCalcStats";
            this.buttonCalcStats.Size = new System.Drawing.Size(122, 31);
            this.buttonCalcStats.TabIndex = 20;
            this.buttonCalcStats.Text = "Get Stats!";
            this.buttonCalcStats.UseVisualStyleBackColor = true;
            this.buttonCalcStats.Click += new System.EventHandler(this.buttonCalcStats_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelGenderLess);
            this.panel2.Controls.Add(this.labelWomen);
            this.panel2.Controls.Add(this.labelMen);
            this.panel2.Controls.Add(this.labelGender);
            this.panel2.Location = new System.Drawing.Point(416, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 196);
            this.panel2.TabIndex = 19;
            // 
            // labelGenderLess
            // 
            this.labelGenderLess.AutoSize = true;
            this.labelGenderLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGenderLess.Location = new System.Drawing.Point(25, 122);
            this.labelGenderLess.Name = "labelGenderLess";
            this.labelGenderLess.Size = new System.Drawing.Size(104, 18);
            this.labelGenderLess.TabIndex = 3;
            this.labelGenderLess.Text = "Genderless: ";
            // 
            // labelWomen
            // 
            this.labelWomen.AutoSize = true;
            this.labelWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWomen.Location = new System.Drawing.Point(25, 58);
            this.labelWomen.Name = "labelWomen";
            this.labelWomen.Size = new System.Drawing.Size(76, 18);
            this.labelWomen.TabIndex = 2;
            this.labelWomen.Text = "Women: ";
            // 
            // labelMen
            // 
            this.labelMen.AutoSize = true;
            this.labelMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMen.Location = new System.Drawing.Point(25, 89);
            this.labelMen.Name = "labelMen";
            this.labelMen.Size = new System.Drawing.Size(50, 18);
            this.labelMen.TabIndex = 1;
            this.labelMen.Text = "Men: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.Location = new System.Drawing.Point(25, 19);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(145, 20);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Men or Women?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.listBoxPhotos);
            this.panel1.Controls.Add(this.listBoxFriendCheckins);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBoxFriendProfilePic);
            this.panel1.Controls.Add(this.buttonFetchGeo);
            this.panel1.Controls.Add(this.labelFriendBio);
            this.panel1.Controls.Add(this.textBoxFriendBio);
            this.panel1.Controls.Add(this.listBoxFriends);
            this.panel1.Controls.Add(this.buttonFetchFriends);
            this.panel1.Location = new System.Drawing.Point(7, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 557);
            this.panel1.TabIndex = 18;
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 16;
            this.listBoxPhotos.Location = new System.Drawing.Point(261, 153);
            this.listBoxPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(143, 100);
            this.listBoxPhotos.TabIndex = 30;
            // 
            // listBoxFriendCheckins
            // 
            this.listBoxFriendCheckins.FormattingEnabled = true;
            this.listBoxFriendCheckins.ItemHeight = 16;
            this.listBoxFriendCheckins.Location = new System.Drawing.Point(261, 49);
            this.listBoxFriendCheckins.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriendCheckins.Name = "listBoxFriendCheckins";
            this.listBoxFriendCheckins.Size = new System.Drawing.Size(143, 100);
            this.listBoxFriendCheckins.TabIndex = 29;
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
            // pictureBoxFriendProfilePic
            // 
            this.pictureBoxFriendProfilePic.Location = new System.Drawing.Point(158, 49);
            this.pictureBoxFriendProfilePic.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFriendProfilePic.Name = "pictureBoxFriendProfilePic";
            this.pictureBoxFriendProfilePic.Size = new System.Drawing.Size(90, 91);
            this.pictureBoxFriendProfilePic.TabIndex = 27;
            this.pictureBoxFriendProfilePic.TabStop = false;
            // 
            // buttonFetchGeo
            // 
            this.buttonFetchGeo.Location = new System.Drawing.Point(417, 16);
            this.buttonFetchGeo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchGeo.Name = "buttonFetchGeo";
            this.buttonFetchGeo.Size = new System.Drawing.Size(78, 35);
            this.buttonFetchGeo.TabIndex = 24;
            this.buttonFetchGeo.UseVisualStyleBackColor = true;
         
            // 
            // labelFriendBio
            // 
            this.labelFriendBio.AutoSize = true;
            this.labelFriendBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendBio.Location = new System.Drawing.Point(10, 259);
            this.labelFriendBio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendBio.Name = "labelFriendBio";
            this.labelFriendBio.Size = new System.Drawing.Size(155, 18);
            this.labelFriendBio.TabIndex = 20;
            this.labelFriendBio.Text = "Selected Friend Bio";
            // 
            // textBoxFriendBio
            // 
            this.textBoxFriendBio.Location = new System.Drawing.Point(13, 290);
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
            this.listBoxFriends.Location = new System.Drawing.Point(11, 49);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(143, 164);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(13, 16);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(141, 29);
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
            this.Load += new System.EventHandler(this.tabPage3_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).EndInit();
            this.tabControlGeo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageGeo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostActiveUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostFriends)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePic)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageGeo;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox textBoxFriendBio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFriendBio;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAddNewAction;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.ListBox listBoxTasks;

        private System.Windows.Forms.PictureBox pictureBoxFriendProfilePic;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.ListBox listBoxFriendCheckins;
        private System.Windows.Forms.Button buttonFetchGeo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelWomen;
        private System.Windows.Forms.Label labelMen;
        private System.Windows.Forms.Button buttonCalcStats;
        private System.Windows.Forms.Label labelGenderLess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAdultAgeRange;
        private System.Windows.Forms.Label labelLowestAgeRange;
        private System.Windows.Forms.Label labelMediumAgeRange;
        private System.Windows.Forms.Label labelAgeRange;
        private System.Windows.Forms.Label labelOldestAgeRange;
        private System.Windows.Forms.Label labelDidntEnterBirthday;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxLeastFriends;
        private System.Windows.Forms.PictureBox pictureBoxMostFriends;
        private System.Windows.Forms.Label labelMostFriends;
        private System.Windows.Forms.Label labelLeastFriends;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLeastFriendsUser;
        private System.Windows.Forms.Label labelMostFriendsUser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelMostActive;
        private System.Windows.Forms.Label labelNumStatuses;
        private System.Windows.Forms.PictureBox pictureBoxMostActiveUser;
        private System.Windows.Forms.Label labelMostActiveUser;
        private System.Windows.Forms.Label labelFriendCountMost;
        private System.Windows.Forms.Label labelFriendCountLeast;
    }
}

