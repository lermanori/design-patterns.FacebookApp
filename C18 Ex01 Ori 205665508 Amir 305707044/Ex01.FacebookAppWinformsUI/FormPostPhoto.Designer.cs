namespace Ex01.FacebookAppWinformsUI
{
    partial class FormPostPhoto
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
            this.labelUploadPhoto = new System.Windows.Forms.Label();
            this.labelPostPhotoPreview = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonChoosePhoto = new System.Windows.Forms.Button();
            this.pictureBoxPostPhotoPreviewImage = new System.Windows.Forms.PictureBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dateTimePickerPost = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUploadPhoto
            // 
            this.labelUploadPhoto.AutoSize = true;
            this.labelUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUploadPhoto.ForeColor = System.Drawing.Color.Black;
            this.labelUploadPhoto.Location = new System.Drawing.Point(21, 9);
            this.labelUploadPhoto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUploadPhoto.Name = "labelUploadPhoto";
            this.labelUploadPhoto.Size = new System.Drawing.Size(690, 39);
            this.labelUploadPhoto.TabIndex = 27;
            this.labelUploadPhoto.Text = "Upload a Photo and choose time and date";
            // 
            // labelPostPhotoPreview
            // 
            this.labelPostPhotoPreview.AutoSize = true;
            this.labelPostPhotoPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostPhotoPreview.Location = new System.Drawing.Point(23, 85);
            this.labelPostPhotoPreview.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPostPhotoPreview.Name = "labelPostPhotoPreview";
            this.labelPostPhotoPreview.Size = new System.Drawing.Size(111, 31);
            this.labelPostPhotoPreview.TabIndex = 26;
            this.labelPostPhotoPreview.Text = "Preview";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(29, 671);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(786, 38);
            this.textBoxTitle.TabIndex = 23;
            this.textBoxTitle.Text = "Enter Title";
            this.textBoxTitle.Click += new System.EventHandler(this.textBoxTitle_Click);
            // 
            // buttonChoosePhoto
            // 
            this.buttonChoosePhoto.Location = new System.Drawing.Point(668, 155);
            this.buttonChoosePhoto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonChoosePhoto.Name = "buttonChoosePhoto";
            this.buttonChoosePhoto.Size = new System.Drawing.Size(159, 504);
            this.buttonChoosePhoto.TabIndex = 24;
            this.buttonChoosePhoto.Text = "Choose Photo";
            this.buttonChoosePhoto.UseVisualStyleBackColor = true;
            this.buttonChoosePhoto.Click += new System.EventHandler(this.buttonChoosePhoto_Click);
            // 
            // pictureBoxPostPhotoPreviewImage
            // 
            this.pictureBoxPostPhotoPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPostPhotoPreviewImage.Location = new System.Drawing.Point(29, 155);
            this.pictureBoxPostPhotoPreviewImage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxPostPhotoPreviewImage.Name = "pictureBoxPostPhotoPreviewImage";
            this.pictureBoxPostPhotoPreviewImage.Size = new System.Drawing.Size(617, 504);
            this.pictureBoxPostPhotoPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPhotoPreviewImage.TabIndex = 25;
            this.pictureBoxPostPhotoPreviewImage.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(29, 807);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(786, 97);
            this.buttonSubmit.TabIndex = 29;
            this.buttonSubmit.Text = "submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dateTimePickerPost
            // 
            this.dateTimePickerPost.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePickerPost.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerPost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPost.Location = new System.Drawing.Point(26, 730);
            this.dateTimePickerPost.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerPost.Name = "dateTimePickerPost";
            this.dateTimePickerPost.Size = new System.Drawing.Size(789, 38);
            this.dateTimePickerPost.TabIndex = 28;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPostPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 934);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dateTimePickerPost);
            this.Controls.Add(this.labelUploadPhoto);
            this.Controls.Add(this.labelPostPhotoPreview);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonChoosePhoto);
            this.Controls.Add(this.pictureBoxPostPhotoPreviewImage);
            this.Name = "FormPostPhoto";
            this.Text = "Post Photo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhotoPreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUploadPhoto;
        private System.Windows.Forms.Label labelPostPhotoPreview;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonChoosePhoto;
        private System.Windows.Forms.PictureBox pictureBoxPostPhotoPreviewImage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePickerPost;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}