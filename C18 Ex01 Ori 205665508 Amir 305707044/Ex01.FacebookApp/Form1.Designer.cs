namespace Ex01.FacebookApp
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonPostPhoto = new System.Windows.Forms.Button();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.pictureBoxPostPhotoPreviewImage = new System.Windows.Forms.PictureBox();
            this.labelPostPhotoPreview = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1872, 141);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1220, 72);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 59);
            this.button3.TabIndex = 5;
            this.button3.Text = "post status";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(1220, 169);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 90);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "enter post here";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 41);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 55);
            this.button4.TabIndex = 7;
            this.button4.Text = "Fetch Groups";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.buttonPostPhoto.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Location = new System.Drawing.Point(1658, 427);
            this.buttonChoosePhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(250, 72);
            this.buttonChoosePhoto.TabIndex = 11;
            this.buttonChoosePhoto.Text = "Choose Photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.button6_Click);
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
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(902, 716);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 66);
            this.button7.TabIndex = 14;
            this.button7.Text = "Post Link";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            "http://www.github.com/",
            "http://www.stackoverflow.com/"});
            this.comboBoxWebBrowser.Location = new System.Drawing.Point(28, 242);
            this.comboBoxWebBrowser.Name = "comboBoxWebBrowser";
            this.comboBoxWebBrowser.Size = new System.Drawing.Size(1161, 33);
            this.comboBoxWebBrowser.TabIndex = 19;
            this.comboBoxWebBrowser.Text = "choose from list or enter your own";
            this.comboBoxWebBrowser.SelectedIndexChanged += new System.EventHandler(this.comboBoxWebBrowser_SelectedIndexChanged);
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
            this.ClientSize = new System.Drawing.Size(2037, 1092);
            this.Controls.Add(this.buttonSubmitUrl);
            this.Controls.Add(this.comboBoxWebBrowser);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelDescriptionOfGroups);
            this.Controls.Add(this.textBoxDescriptionOfGroup);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.labelPostPhotoPreview);
            this.Controls.Add(this.pictureBoxPostPhotoPreviewImage);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonPostPhoto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonPostPhoto;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPostPhotoPreviewImage;
        private System.Windows.Forms.Label labelPostPhotoPreview;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox textBoxDescriptionOfGroup;
        private System.Windows.Forms.Label labelDescriptionOfGroups;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.ComboBox comboBoxWebBrowser;
        private System.Windows.Forms.Button buttonSubmitUrl;
    }
}

