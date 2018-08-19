using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public partial class FormPostPhoto : Form ,IfbAutomatable
    {
        public const string k_EnterTitleMsg = "Enter Title";

        public string PathToImage { get; set; }

        public string StatusBody { get; set; }

        public DateTime TimeToExecute { get; set; }

        public FormPostPhoto()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            TimeToExecute = dateTimePickerPost.Value;
            StatusBody = textBoxTitle.Text;

            this.DialogResult = DialogResult.OK;
            checkTitleAndReset();
            Close();
        }

        private void resetPictureButtons()
        {
            pictureBoxPostPhotoPreviewImage.Image = null;
            textBoxTitle.Text = k_EnterTitleMsg;
            buttonSubmit.Enabled = false;
        }
        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            chooseAndLoadPhoto();
        }

        private void chooseAndLoadPhoto()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PathToImage = openFileDialog1.FileName;
            }

            //insert here checking for image file

            if (!string.IsNullOrEmpty(PathToImage))
            {
                pictureBoxPostPhotoPreviewImage.LoadAsync(PathToImage);
                buttonSubmit.Enabled = true;
            }
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }

        public FbEventArgs collectData()
        {
            FbEventArgs result = new FbEventArgs { StatusBody = StatusBody, time = TimeToExecute, PathToImage = PathToImage };
            return result;
        }
        public TasksType getTaskType()
        {
            return TasksType.photo;
        }

        private void checkTitleAndReset()
        {
            string title = string.Empty;
            if (textBoxTitle.Text != k_EnterTitleMsg)
            {
                title = textBoxTitle.Text;
            }

            resetPictureButtons();
        }


    }
}

