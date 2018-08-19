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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxUploadPost = new System.Windows.Forms.TextBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonPostPhoto = new System.Windows.Forms.Button();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.labelPostPhotoPreview = new System.Windows.Forms.Label();
            this.buttonPostLink = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBoxDescriptionOfGroup = new System.Windows.Forms.TextBox();
            this.labelDescriptionOfGroups = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.comboBoxWebBrowser = new System.Windows.Forms.ComboBox();
            this.buttonSubmitUrl = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.labelUploadLink = new System.Windows.Forms.Label();
            this.labelUploadPhoto = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxPostPhotoPreviewImage = new System.Windows.Forms.PictureBox();
            this.tabPageStatsAndShook = new System.Windows.Forms.TabPage();
            this.labelGetStatistics = new System.Windows.Forms.Label();
            this.panelShickOShook = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShook = new System.Windows.Forms.Button();
            this.buttonShik = new System.Windows.Forms.Button();
            this.labelTellYourFriends = new System.Windows.Forms.Label();
            this.pictureBoxFriendPhotoShickOShook = new System.Windows.Forms.PictureBox();
            this.buttonActivateShickOShook = new System.Windows.Forms.Button();
            this.labelShickOShookFeatureDescription = new System.Windows.Forms.Label();
            this.labelShickOShookTitle = new System.Windows.Forms.Label();
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
            this.tabPageAutomate = new System.Windows.Forms.TabPage();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.buttonAddNewAction = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).BeginInit();
            this.tabPageStatsAndShook.SuspendLayout();
            this.panelShickOShook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhotoShickOShook)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostActiveUser)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostFriends)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageAutomate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(2416, 41);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(149, 73);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLoginClick);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 31;
            this.listBoxGroups.Location = new System.Drawing.Point(60, 83);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(332, 314);
            this.listBoxGroups.TabIndex = 2;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Enabled = false;
            this.buttonLogOut.Location = new System.Drawing.Point(2416, 126);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(149, 72);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(1269, 241);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(704, 73);
            this.buttonPostStatus.TabIndex = 5;
            this.buttonPostStatus.Text = "Post a Status!";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_click);
            // 
            // textBoxUploadPost
            // 
            this.textBoxUploadPost.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxUploadPost.Location = new System.Drawing.Point(1269, 41);
            this.textBoxUploadPost.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUploadPost.Multiline = true;
            this.textBoxUploadPost.Name = "textBoxUploadPost";
            this.textBoxUploadPost.Size = new System.Drawing.Size(700, 170);
            this.textBoxUploadPost.TabIndex = 6;
            this.textBoxUploadPost.Text = "What\'s On Your Mind?...";
            this.textBoxUploadPost.Click += new System.EventHandler(this.textBoxUploadPost_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Enabled = false;
            this.buttonFetchGroups.Location = new System.Drawing.Point(845, 83);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(227, 68);
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
            this.textBoxTitle.Location = new System.Drawing.Point(2260, 644);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(295, 38);
            this.textBoxTitle.TabIndex = 9;
            this.textBoxTitle.Text = "Enter Title";
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // buttonPostPhoto
            // 
            this.buttonPostPhoto.Enabled = false;
            this.buttonPostPhoto.Location = new System.Drawing.Point(2260, 1017);
            this.buttonPostPhoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonPostPhoto.Name = "buttonPostPhoto";
            this.buttonPostPhoto.Size = new System.Drawing.Size(205, 69);
            this.buttonPostPhoto.TabIndex = 8;
            this.buttonPostPhoto.Text = "Post Photo";
            this.buttonPostPhoto.UseVisualStyleBackColor = true;
            this.buttonPostPhoto.Click += new System.EventHandler(this.buttonPostPhoto_Click);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Enabled = false;
            this.buttonChoosePhoto.Location = new System.Drawing.Point(2260, 575);
            this.buttonChoosePhoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(228, 56);
            this.buttonChoosePhoto.TabIndex = 11;
            this.buttonChoosePhoto.Text = "Choose Photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // labelPostPhotoPreview
            // 
            this.labelPostPhotoPreview.AutoSize = true;
            this.labelPostPhotoPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostPhotoPreview.Location = new System.Drawing.Point(1628, 537);
            this.labelPostPhotoPreview.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPostPhotoPreview.Name = "labelPostPhotoPreview";
            this.labelPostPhotoPreview.Size = new System.Drawing.Size(111, 31);
            this.labelPostPhotoPreview.TabIndex = 13;
            this.labelPostPhotoPreview.Text = "Preview";
            // 
            // buttonPostLink
            // 
            this.buttonPostLink.Enabled = false;
            this.buttonPostLink.Location = new System.Drawing.Point(1288, 507);
            this.buttonPostLink.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonPostLink.Name = "buttonPostLink";
            this.buttonPostLink.Size = new System.Drawing.Size(248, 55);
            this.buttonPostLink.TabIndex = 14;
            this.buttonPostLink.Text = "Post Link";
            this.buttonPostLink.UseVisualStyleBackColor = true;
            this.buttonPostLink.Click += new System.EventHandler(this.buttonPostLink_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRememberUser.Enabled = false;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(2363, 246);
            this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(238, 36);
            this.checkBoxRememberUser.TabIndex = 16;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(45, 575);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.webBrowser.MinimumSize = new System.Drawing.Size(40, 38);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1491, 511);
            this.webBrowser.TabIndex = 15;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // textBoxDescriptionOfGroup
            // 
            this.textBoxDescriptionOfGroup.Location = new System.Drawing.Point(428, 83);
            this.textBoxDescriptionOfGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescriptionOfGroup.Multiline = true;
            this.textBoxDescriptionOfGroup.Name = "textBoxDescriptionOfGroup";
            this.textBoxDescriptionOfGroup.Size = new System.Drawing.Size(404, 314);
            this.textBoxDescriptionOfGroup.TabIndex = 16;
            // 
            // labelDescriptionOfGroups
            // 
            this.labelDescriptionOfGroups.AutoSize = true;
            this.labelDescriptionOfGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescriptionOfGroups.Location = new System.Drawing.Point(421, 33);
            this.labelDescriptionOfGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionOfGroups.Name = "labelDescriptionOfGroups";
            this.labelDescriptionOfGroups.Size = new System.Drawing.Size(151, 31);
            this.labelDescriptionOfGroups.TabIndex = 17;
            this.labelDescriptionOfGroups.Text = "Description";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroups.Location = new System.Drawing.Point(53, 33);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(103, 31);
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
            this.comboBoxWebBrowser.Location = new System.Drawing.Point(45, 507);
            this.comboBoxWebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxWebBrowser.Name = "comboBoxWebBrowser";
            this.comboBoxWebBrowser.Size = new System.Drawing.Size(1036, 39);
            this.comboBoxWebBrowser.TabIndex = 19;
            this.comboBoxWebBrowser.Text = "choose from list or enter your own";
            this.comboBoxWebBrowser.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebBrowser_SelectedIndexChanged);
            this.comboBoxWebBrowser.Click += new System.EventHandler(this.comboBoxWebBrowser_Click);
            // 
            // buttonSubmitUrl
            // 
            this.buttonSubmitUrl.Location = new System.Drawing.Point(1093, 507);
            this.buttonSubmitUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmitUrl.Name = "buttonSubmitUrl";
            this.buttonSubmitUrl.Size = new System.Drawing.Size(184, 55);
            this.buttonSubmitUrl.TabIndex = 20;
            this.buttonSubmitUrl.Text = "Submit URL";
            this.buttonSubmitUrl.UseVisualStyleBackColor = true;
            this.buttonSubmitUrl.Click += new System.EventHandler(this.buttonSubmitUrl_onClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBasic);
            this.tabControl.Controls.Add(this.tabPageStatsAndShook);
            this.tabControl.Controls.Add(this.tabPageAutomate);
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(3, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2651, 1161);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 21;
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPageBasic.Controls.Add(this.labelUploadLink);
            this.tabPageBasic.Controls.Add(this.labelUploadPhoto);
            this.tabPageBasic.Controls.Add(this.listBoxGroups);
            this.tabPageBasic.Controls.Add(this.buttonLogin);
            this.tabPageBasic.Controls.Add(this.buttonLogOut);
            this.tabPageBasic.Controls.Add(this.pictureBoxProfilePicture);
            this.tabPageBasic.Controls.Add(this.checkBoxRememberUser);
            this.tabPageBasic.Controls.Add(this.buttonSubmitUrl);
            this.tabPageBasic.Controls.Add(this.buttonPostStatus);
            this.tabPageBasic.Controls.Add(this.textBoxUploadPost);
            this.tabPageBasic.Controls.Add(this.labelGroups);
            this.tabPageBasic.Controls.Add(this.labelDescriptionOfGroups);
            this.tabPageBasic.Controls.Add(this.labelPostPhotoPreview);
            this.tabPageBasic.Controls.Add(this.buttonPostLink);
            this.tabPageBasic.Controls.Add(this.textBoxTitle);
            this.tabPageBasic.Controls.Add(this.buttonChoosePhoto);
            this.tabPageBasic.Controls.Add(this.pictureBoxPostPhotoPreviewImage);
            this.tabPageBasic.Controls.Add(this.comboBoxWebBrowser);
            this.tabPageBasic.Controls.Add(this.buttonPostPhoto);
            this.tabPageBasic.Controls.Add(this.textBoxDescriptionOfGroup);
            this.tabPageBasic.Controls.Add(this.webBrowser);
            this.tabPageBasic.Controls.Add(this.buttonFetchGroups);
            this.tabPageBasic.Location = new System.Drawing.Point(10, 48);
            this.tabPageBasic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageBasic.Size = new System.Drawing.Size(2631, 1103);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "General Tab";
            // 
            // labelUploadLink
            // 
            this.labelUploadLink.AutoSize = true;
            this.labelUploadLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUploadLink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUploadLink.Location = new System.Drawing.Point(340, 455);
            this.labelUploadLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUploadLink.Name = "labelUploadLink";
            this.labelUploadLink.Size = new System.Drawing.Size(277, 46);
            this.labelUploadLink.TabIndex = 22;
            this.labelUploadLink.Text = "Upload a Link";
            // 
            // labelUploadPhoto
            // 
            this.labelUploadPhoto.AutoSize = true;
            this.labelUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUploadPhoto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelUploadPhoto.Location = new System.Drawing.Point(1768, 455);
            this.labelUploadPhoto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUploadPhoto.Name = "labelUploadPhoto";
            this.labelUploadPhoto.Size = new System.Drawing.Size(311, 46);
            this.labelUploadPhoto.TabIndex = 21;
            this.labelUploadPhoto.Text = "Upload a Photo";
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(2024, 41);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(296, 269);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 4;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // pictureBoxPostPhotoPreviewImage
            // 
            this.pictureBoxPostPhotoPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPostPhotoPreviewImage.Location = new System.Drawing.Point(1635, 575);
            this.pictureBoxPostPhotoPreviewImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxPostPhotoPreviewImage.Name = "pictureBoxPostPhotoPreviewImage";
            this.pictureBoxPostPhotoPreviewImage.Size = new System.Drawing.Size(617, 504);
            this.pictureBoxPostPhotoPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPhotoPreviewImage.TabIndex = 12;
            this.pictureBoxPostPhotoPreviewImage.TabStop = false;
            // 
            // tabPageStatsAndShook
            // 
            this.tabPageStatsAndShook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(71)))), ((int)(((byte)(93)))));
            this.tabPageStatsAndShook.Controls.Add(this.labelGetStatistics);
            this.tabPageStatsAndShook.Controls.Add(this.panelShickOShook);
            this.tabPageStatsAndShook.Controls.Add(this.panel5);
            this.tabPageStatsAndShook.Controls.Add(this.panel4);
            this.tabPageStatsAndShook.Controls.Add(this.panel3);
            this.tabPageStatsAndShook.Controls.Add(this.buttonCalcStats);
            this.tabPageStatsAndShook.Controls.Add(this.panel2);
            this.tabPageStatsAndShook.Location = new System.Drawing.Point(10, 48);
            this.tabPageStatsAndShook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageStatsAndShook.Name = "tabPageStatsAndShook";
            this.tabPageStatsAndShook.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageStatsAndShook.Size = new System.Drawing.Size(2631, 1103);
            this.tabPageStatsAndShook.TabIndex = 1;
            this.tabPageStatsAndShook.Text = "Get Stats And Rate Your Friends!";
            // 
            // labelGetStatistics
            // 
            this.labelGetStatistics.AutoSize = true;
            this.labelGetStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGetStatistics.ForeColor = System.Drawing.Color.White;
            this.labelGetStatistics.Location = new System.Drawing.Point(1304, 58);
            this.labelGetStatistics.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGetStatistics.Name = "labelGetStatistics";
            this.labelGetStatistics.Size = new System.Drawing.Size(273, 72);
            this.labelGetStatistics.TabIndex = 25;
            this.labelGetStatistics.Text = "Get Statistics\r\nabout your friends";
            // 
            // panelShickOShook
            // 
            this.panelShickOShook.BackColor = System.Drawing.Color.Transparent;
            this.panelShickOShook.BackgroundImage = global::Ex01.FacebookAppWinformsUI.Properties.Resources.ShickOShook;
            this.panelShickOShook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelShickOShook.Controls.Add(this.label1);
            this.panelShickOShook.Controls.Add(this.buttonShook);
            this.panelShickOShook.Controls.Add(this.buttonShik);
            this.panelShickOShook.Controls.Add(this.labelTellYourFriends);
            this.panelShickOShook.Controls.Add(this.pictureBoxFriendPhotoShickOShook);
            this.panelShickOShook.Controls.Add(this.buttonActivateShickOShook);
            this.panelShickOShook.Controls.Add(this.labelShickOShookFeatureDescription);
            this.panelShickOShook.Controls.Add(this.labelShickOShookTitle);
            this.panelShickOShook.Location = new System.Drawing.Point(35, 51);
            this.panelShickOShook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelShickOShook.Name = "panelShickOShook";
            this.panelShickOShook.Size = new System.Drawing.Size(1204, 810);
            this.panelShickOShook.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 692);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 64);
            this.label1.TabIndex = 25;
            this.label1.Text = "Clicking On Friend Picture \r\nWill Browse The Picture ";
            this.label1.Visible = false;
            // 
            // buttonShook
            // 
            this.buttonShook.BackColor = System.Drawing.Color.Red;
            this.buttonShook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShook.Location = new System.Drawing.Point(668, 560);
            this.buttonShook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonShook.Name = "buttonShook";
            this.buttonShook.Size = new System.Drawing.Size(229, 104);
            this.buttonShook.TabIndex = 24;
            this.buttonShook.Text = "Shook!";
            this.buttonShook.UseVisualStyleBackColor = false;
            this.buttonShook.Click += new System.EventHandler(this.buttonShook_Click);
            // 
            // buttonShik
            // 
            this.buttonShik.BackColor = System.Drawing.Color.Green;
            this.buttonShik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonShik.ForeColor = System.Drawing.Color.White;
            this.buttonShik.Location = new System.Drawing.Point(909, 560);
            this.buttonShik.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonShik.Name = "buttonShik";
            this.buttonShik.Size = new System.Drawing.Size(229, 104);
            this.buttonShik.TabIndex = 23;
            this.buttonShik.Text = "Shik!";
            this.buttonShik.UseVisualStyleBackColor = false;
            this.buttonShik.Click += new System.EventHandler(this.buttonShik_Click);
            // 
            // labelTellYourFriends
            // 
            this.labelTellYourFriends.AutoSize = true;
            this.labelTellYourFriends.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTellYourFriends.Location = new System.Drawing.Point(741, 498);
            this.labelTellYourFriends.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTellYourFriends.Name = "labelTellYourFriends";
            this.labelTellYourFriends.Size = new System.Drawing.Size(286, 32);
            this.labelTellYourFriends.TabIndex = 5;
            this.labelTellYourFriends.Text = "labellTellYourFriends";
            this.labelTellYourFriends.Visible = false;
            // 
            // pictureBoxFriendPhotoShickOShook
            // 
            this.pictureBoxFriendPhotoShickOShook.Location = new System.Drawing.Point(32, 273);
            this.pictureBoxFriendPhotoShickOShook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxFriendPhotoShickOShook.Name = "pictureBoxFriendPhotoShickOShook";
            this.pictureBoxFriendPhotoShickOShook.Size = new System.Drawing.Size(352, 392);
            this.pictureBoxFriendPhotoShickOShook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendPhotoShickOShook.TabIndex = 3;
            this.pictureBoxFriendPhotoShickOShook.TabStop = false;
            this.pictureBoxFriendPhotoShickOShook.Click += new System.EventHandler(this.pictureBoxFriendPhotoShickOShook_Click);
            // 
            // buttonActivateShickOShook
            // 
            this.buttonActivateShickOShook.Location = new System.Drawing.Point(45, 179);
            this.buttonActivateShickOShook.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonActivateShickOShook.Name = "buttonActivateShickOShook";
            this.buttonActivateShickOShook.Size = new System.Drawing.Size(301, 82);
            this.buttonActivateShickOShook.TabIndex = 2;
            this.buttonActivateShickOShook.Text = "Shick O Shook??";
            this.buttonActivateShickOShook.UseVisualStyleBackColor = true;
            this.buttonActivateShickOShook.Click += new System.EventHandler(this.buttonActivateShikOShook_Click);
            // 
            // labelShickOShookFeatureDescription
            // 
            this.labelShickOShookFeatureDescription.AutoSize = true;
            this.labelShickOShookFeatureDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelShickOShookFeatureDescription.ForeColor = System.Drawing.Color.White;
            this.labelShickOShookFeatureDescription.Location = new System.Drawing.Point(636, 113);
            this.labelShickOShookFeatureDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelShickOShookFeatureDescription.Name = "labelShickOShookFeatureDescription";
            this.labelShickOShookFeatureDescription.Size = new System.Drawing.Size(487, 93);
            this.labelShickOShookFeatureDescription.TabIndex = 1;
            this.labelShickOShookFeatureDescription.Text = "Get a random friend from your list,\r\nand rate their appearance!\r\nClicking will ma" +
    "ke a post by your name!";
            // 
            // labelShickOShookTitle
            // 
            this.labelShickOShookTitle.AutoSize = true;
            this.labelShickOShookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelShickOShookTitle.ForeColor = System.Drawing.Color.White;
            this.labelShickOShookTitle.Location = new System.Drawing.Point(381, 29);
            this.labelShickOShookTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelShickOShookTitle.Name = "labelShickOShookTitle";
            this.labelShickOShookTitle.Size = new System.Drawing.Size(347, 54);
            this.labelShickOShookTitle.TabIndex = 0;
            this.labelShickOShookTitle.Text = "Shik O Shook?";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelNumStatuses);
            this.panel5.Controls.Add(this.pictureBoxMostActiveUser);
            this.panel5.Controls.Add(this.labelMostActiveUser);
            this.panel5.Controls.Add(this.labelMostActive);
            this.panel5.Location = new System.Drawing.Point(1604, 671);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 379);
            this.panel5.TabIndex = 20;
            // 
            // labelNumStatuses
            // 
            this.labelNumStatuses.AutoSize = true;
            this.labelNumStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumStatuses.ForeColor = System.Drawing.Color.White;
            this.labelNumStatuses.Location = new System.Drawing.Point(52, 126);
            this.labelNumStatuses.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNumStatuses.Name = "labelNumStatuses";
            this.labelNumStatuses.Size = new System.Drawing.Size(19, 29);
            this.labelNumStatuses.TabIndex = 6;
            this.labelNumStatuses.Text = "l";
            // 
            // pictureBoxMostActiveUser
            // 
            this.pictureBoxMostActiveUser.Location = new System.Drawing.Point(96, 162);
            this.pictureBoxMostActiveUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxMostActiveUser.Name = "pictureBoxMostActiveUser";
            this.pictureBoxMostActiveUser.Size = new System.Drawing.Size(256, 211);
            this.pictureBoxMostActiveUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostActiveUser.TabIndex = 5;
            this.pictureBoxMostActiveUser.TabStop = false;
            // 
            // labelMostActiveUser
            // 
            this.labelMostActiveUser.AutoSize = true;
            this.labelMostActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostActiveUser.ForeColor = System.Drawing.Color.White;
            this.labelMostActiveUser.Location = new System.Drawing.Point(52, 89);
            this.labelMostActiveUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMostActiveUser.Name = "labelMostActiveUser";
            this.labelMostActiveUser.Size = new System.Drawing.Size(21, 31);
            this.labelMostActiveUser.TabIndex = 1;
            this.labelMostActiveUser.Text = "l";
            // 
            // labelMostActive
            // 
            this.labelMostActive.AutoSize = true;
            this.labelMostActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostActive.ForeColor = System.Drawing.Color.White;
            this.labelMostActive.Location = new System.Drawing.Point(32, 37);
            this.labelMostActive.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMostActive.Name = "labelMostActive";
            this.labelMostActive.Size = new System.Drawing.Size(391, 39);
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
            this.panel4.Location = new System.Drawing.Point(2115, 58);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 605);
            this.panel4.TabIndex = 21;
            // 
            // labelFriendCountMost
            // 
            this.labelFriendCountMost.AutoSize = true;
            this.labelFriendCountMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendCountMost.ForeColor = System.Drawing.Color.White;
            this.labelFriendCountMost.Location = new System.Drawing.Point(52, 171);
            this.labelFriendCountMost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFriendCountMost.Name = "labelFriendCountMost";
            this.labelFriendCountMost.Size = new System.Drawing.Size(26, 29);
            this.labelFriendCountMost.TabIndex = 8;
            this.labelFriendCountMost.Text = "1";
            // 
            // labelFriendCountLeast
            // 
            this.labelFriendCountLeast.AutoSize = true;
            this.labelFriendCountLeast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendCountLeast.ForeColor = System.Drawing.Color.White;
            this.labelFriendCountLeast.Location = new System.Drawing.Point(52, 427);
            this.labelFriendCountLeast.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFriendCountLeast.Name = "labelFriendCountLeast";
            this.labelFriendCountLeast.Size = new System.Drawing.Size(26, 29);
            this.labelFriendCountLeast.TabIndex = 7;
            this.labelFriendCountLeast.Text = "1";
            // 
            // labelLeastFriendsUser
            // 
            this.labelLeastFriendsUser.AutoSize = true;
            this.labelLeastFriendsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLeastFriendsUser.ForeColor = System.Drawing.Color.White;
            this.labelLeastFriendsUser.Location = new System.Drawing.Point(52, 397);
            this.labelLeastFriendsUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLeastFriendsUser.Name = "labelLeastFriendsUser";
            this.labelLeastFriendsUser.Size = new System.Drawing.Size(26, 29);
            this.labelLeastFriendsUser.TabIndex = 6;
            this.labelLeastFriendsUser.Text = "1";
            // 
            // labelMostFriendsUser
            // 
            this.labelMostFriendsUser.AutoSize = true;
            this.labelMostFriendsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostFriendsUser.ForeColor = System.Drawing.Color.White;
            this.labelMostFriendsUser.Location = new System.Drawing.Point(52, 138);
            this.labelMostFriendsUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMostFriendsUser.Name = "labelMostFriendsUser";
            this.labelMostFriendsUser.Size = new System.Drawing.Size(26, 29);
            this.labelMostFriendsUser.TabIndex = 5;
            this.labelMostFriendsUser.Text = "2";
            // 
            // pictureBoxLeastFriends
            // 
            this.pictureBoxLeastFriends.Location = new System.Drawing.Point(100, 458);
            this.pictureBoxLeastFriends.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxLeastFriends.Name = "pictureBoxLeastFriends";
            this.pictureBoxLeastFriends.Size = new System.Drawing.Size(173, 144);
            this.pictureBoxLeastFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeastFriends.TabIndex = 4;
            this.pictureBoxLeastFriends.TabStop = false;
            // 
            // pictureBoxMostFriends
            // 
            this.pictureBoxMostFriends.Location = new System.Drawing.Point(100, 213);
            this.pictureBoxMostFriends.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxMostFriends.Name = "pictureBoxMostFriends";
            this.pictureBoxMostFriends.Size = new System.Drawing.Size(173, 144);
            this.pictureBoxMostFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostFriends.TabIndex = 3;
            this.pictureBoxMostFriends.TabStop = false;
            // 
            // labelMostFriends
            // 
            this.labelMostFriends.AutoSize = true;
            this.labelMostFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMostFriends.ForeColor = System.Drawing.Color.White;
            this.labelMostFriends.Location = new System.Drawing.Point(75, 107);
            this.labelMostFriends.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMostFriends.Name = "labelMostFriends";
            this.labelMostFriends.Size = new System.Drawing.Size(218, 36);
            this.labelMostFriends.TabIndex = 2;
            this.labelMostFriends.Text = "Most Friends: ";
            // 
            // labelLeastFriends
            // 
            this.labelLeastFriends.AutoSize = true;
            this.labelLeastFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLeastFriends.ForeColor = System.Drawing.Color.White;
            this.labelLeastFriends.Location = new System.Drawing.Point(75, 362);
            this.labelLeastFriends.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLeastFriends.Name = "labelLeastFriends";
            this.labelLeastFriends.Size = new System.Drawing.Size(217, 36);
            this.labelLeastFriends.TabIndex = 1;
            this.labelLeastFriends.Text = "Least Friends:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 39);
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
            this.panel3.Location = new System.Drawing.Point(1604, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 600);
            this.panel3.TabIndex = 20;
            // 
            // labelDidntEnterBirthday
            // 
            this.labelDidntEnterBirthday.AutoSize = true;
            this.labelDidntEnterBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDidntEnterBirthday.ForeColor = System.Drawing.Color.White;
            this.labelDidntEnterBirthday.Location = new System.Drawing.Point(51, 366);
            this.labelDidntEnterBirthday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDidntEnterBirthday.Name = "labelDidntEnterBirthday";
            this.labelDidntEnterBirthday.Size = new System.Drawing.Size(191, 36);
            this.labelDidntEnterBirthday.TabIndex = 5;
            this.labelDidntEnterBirthday.Text = "Did\'nt Enter:";
            // 
            // labelOldestAgeRange
            // 
            this.labelOldestAgeRange.AutoSize = true;
            this.labelOldestAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelOldestAgeRange.ForeColor = System.Drawing.Color.White;
            this.labelOldestAgeRange.Location = new System.Drawing.Point(51, 300);
            this.labelOldestAgeRange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOldestAgeRange.Name = "labelOldestAgeRange";
            this.labelOldestAgeRange.Size = new System.Drawing.Size(87, 36);
            this.labelOldestAgeRange.TabIndex = 4;
            this.labelOldestAgeRange.Text = "61+: ";
            // 
            // labelAdultAgeRange
            // 
            this.labelAdultAgeRange.AutoSize = true;
            this.labelAdultAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAdultAgeRange.ForeColor = System.Drawing.Color.White;
            this.labelAdultAgeRange.Location = new System.Drawing.Point(51, 237);
            this.labelAdultAgeRange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAdultAgeRange.Name = "labelAdultAgeRange";
            this.labelAdultAgeRange.Size = new System.Drawing.Size(116, 36);
            this.labelAdultAgeRange.TabIndex = 3;
            this.labelAdultAgeRange.Text = "41-60: ";
            // 
            // labelLowestAgeRange
            // 
            this.labelLowestAgeRange.AutoSize = true;
            this.labelLowestAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLowestAgeRange.ForeColor = System.Drawing.Color.White;
            this.labelLowestAgeRange.Location = new System.Drawing.Point(51, 113);
            this.labelLowestAgeRange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLowestAgeRange.Name = "labelLowestAgeRange";
            this.labelLowestAgeRange.Size = new System.Drawing.Size(98, 36);
            this.labelLowestAgeRange.TabIndex = 2;
            this.labelLowestAgeRange.Text = "0-20: ";
            // 
            // labelMediumAgeRange
            // 
            this.labelMediumAgeRange.AutoSize = true;
            this.labelMediumAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMediumAgeRange.ForeColor = System.Drawing.Color.White;
            this.labelMediumAgeRange.Location = new System.Drawing.Point(51, 172);
            this.labelMediumAgeRange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMediumAgeRange.Name = "labelMediumAgeRange";
            this.labelMediumAgeRange.Size = new System.Drawing.Size(116, 36);
            this.labelMediumAgeRange.TabIndex = 1;
            this.labelMediumAgeRange.Text = "21-40: ";
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAgeRange.ForeColor = System.Drawing.Color.White;
            this.labelAgeRange.Location = new System.Drawing.Point(51, 37);
            this.labelAgeRange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(331, 39);
            this.labelAgeRange.TabIndex = 0;
            this.labelAgeRange.Text = "How Old Are They?";
            // 
            // buttonCalcStats
            // 
            this.buttonCalcStats.Location = new System.Drawing.Point(1309, 134);
            this.buttonCalcStats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonCalcStats.Name = "buttonCalcStats";
            this.buttonCalcStats.Size = new System.Drawing.Size(283, 60);
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
            this.panel2.Location = new System.Drawing.Point(2115, 675);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 379);
            this.panel2.TabIndex = 19;
            // 
            // labelGenderLess
            // 
            this.labelGenderLess.AutoSize = true;
            this.labelGenderLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGenderLess.ForeColor = System.Drawing.Color.White;
            this.labelGenderLess.Location = new System.Drawing.Point(51, 237);
            this.labelGenderLess.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGenderLess.Name = "labelGenderLess";
            this.labelGenderLess.Size = new System.Drawing.Size(195, 36);
            this.labelGenderLess.TabIndex = 3;
            this.labelGenderLess.Text = "Genderless: ";
            // 
            // labelWomen
            // 
            this.labelWomen.AutoSize = true;
            this.labelWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWomen.ForeColor = System.Drawing.Color.White;
            this.labelWomen.Location = new System.Drawing.Point(51, 113);
            this.labelWomen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWomen.Name = "labelWomen";
            this.labelWomen.Size = new System.Drawing.Size(140, 36);
            this.labelWomen.TabIndex = 2;
            this.labelWomen.Text = "Women: ";
            // 
            // labelMen
            // 
            this.labelMen.AutoSize = true;
            this.labelMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMen.ForeColor = System.Drawing.Color.White;
            this.labelMen.Location = new System.Drawing.Point(51, 172);
            this.labelMen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMen.Name = "labelMen";
            this.labelMen.Size = new System.Drawing.Size(94, 36);
            this.labelMen.TabIndex = 1;
            this.labelMen.Text = "Men: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Location = new System.Drawing.Point(51, 37);
            this.labelGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(280, 39);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Men or Women?";
            // 
            // tabPageAutomate
            // 
            this.tabPageAutomate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(174)))), ((int)(((byte)(197)))));
            this.tabPageAutomate.Controls.Add(this.listBoxTasks);
            this.tabPageAutomate.Controls.Add(this.listBoxActions);
            this.tabPageAutomate.Controls.Add(this.buttonAddNewAction);
            this.tabPageAutomate.Location = new System.Drawing.Point(10, 48);
            this.tabPageAutomate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAutomate.Name = "tabPageAutomate";
            this.tabPageAutomate.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPageAutomate.Size = new System.Drawing.Size(2631, 1103);
            this.tabPageAutomate.TabIndex = 2;
            this.tabPageAutomate.Text = "Automate Facebook Tasks";
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 31;
            this.listBoxTasks.Location = new System.Drawing.Point(48, 42);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(1628, 934);
            this.listBoxTasks.TabIndex = 4;
            // 
            // listBoxActions
            // 
            this.listBoxActions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxActions.DisplayMember = "text";
            this.listBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.ItemHeight = 58;
            this.listBoxActions.Location = new System.Drawing.Point(1792, 42);
            this.listBoxActions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(504, 526);
            this.listBoxActions.TabIndex = 3;
            // 
            // buttonAddNewAction
            // 
            this.buttonAddNewAction.Location = new System.Drawing.Point(1792, 823);
            this.buttonAddNewAction.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAddNewAction.Name = "buttonAddNewAction";
            this.buttonAddNewAction.Size = new System.Drawing.Size(508, 157);
            this.buttonAddNewAction.TabIndex = 2;
            this.buttonAddNewAction.Text = "Add New Action";
            this.buttonAddNewAction.UseVisualStyleBackColor = true;
            this.buttonAddNewAction.Click += new System.EventHandler(this.buttonAddNewCommand_Click);
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2656, 1185);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormFacebookApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "newFacebook";
            this.Load += new System.EventHandler(this.tabPageAutomate_load);
            this.tabControl.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tabPageBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).EndInit();
            this.tabPageStatsAndShook.ResumeLayout(false);
            this.tabPageStatsAndShook.PerformLayout();
            this.panelShickOShook.ResumeLayout(false);
            this.panelShickOShook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhotoShickOShook)).EndInit();
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
            this.tabPageAutomate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBasic;
        private System.Windows.Forms.TabPage tabPageStatsAndShook;

        private System.Windows.Forms.TabPage tabPageAutomate;
        private System.Windows.Forms.Button buttonAddNewAction;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.ListBox listBoxTasks;
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
        private System.Windows.Forms.Panel panelShickOShook;
        private System.Windows.Forms.Label labelShickOShookFeatureDescription;
        private System.Windows.Forms.Label labelShickOShookTitle;
        private System.Windows.Forms.Button buttonActivateShickOShook;
        private System.Windows.Forms.Label labelTellYourFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriendPhotoShickOShook;
        private System.Windows.Forms.Button buttonShook;
        private System.Windows.Forms.Button buttonShik;
        private System.Windows.Forms.Label labelUploadLink;
        private System.Windows.Forms.Label labelUploadPhoto;
        private System.Windows.Forms.Label labelGetStatistics;
        private System.Windows.Forms.Label label1;
    }
}

