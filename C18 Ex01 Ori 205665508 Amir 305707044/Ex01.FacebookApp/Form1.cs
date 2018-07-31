using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Ex01.FacebookApp
{
    public partial class Form1 : Form
    {
        private readonly string k_EnterTitleMsg = "Enter Title";
        private readonly string k_httpOpening = @"http://www.";
        LoginResult m_loginResult;

        FacebookSettings m_LastSettings = null;

        string m_photoPath = string.Empty;
        User m_currentUser;

        public Form1()
        {
            m_LastSettings = FacebookSettings.LoadFromFile();
            InitializeComponent();
            this.checkBoxRememberUser.Checked = m_LastSettings.RememberUser;
            this.Size = m_LastSettings.LastWindowSize;

        }

        protected override void OnShown(EventArgs e)
        {
            if (m_LastSettings.RememberUser && !string.IsNullOrEmpty(m_LastSettings.LastAccessToken))
            {
                m_loginResult = FacebookService.Connect(m_LastSettings.LastAccessToken);
                fetchLoggedInUser();
            }
            if(m_LastSettings.ComboBoxWebBrowserItems.Count != 0)
            {
                foreach(string s in m_LastSettings.ComboBoxWebBrowserItems )
                {
                    if(!comboBoxWebBrowser.Items.Contains(s))
                    {
                    comboBoxWebBrowser.Items.Add(s);
                    }
                }
            }
            base.OnShown(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            m_LastSettings.LastWindowSize = this.Size;
            m_LastSettings.RememberUser = this.checkBoxRememberUser.Checked;
            m_LastSettings.LastAccessToken = m_loginResult.AccessToken;
            foreach(string s in comboBoxWebBrowser.Items)
            {
                if(!m_LastSettings.ComboBoxWebBrowserItems.Contains(s))
                {
                m_LastSettings.ComboBoxWebBrowserItems.Add(s);
                }
            }
            m_LastSettings.saveToFile();
            base.OnFormClosing(e);
        }

        private void buttonLoginClick(object sender, EventArgs e)
        { 
            login();
        }

        private void login()
        {
            m_loginResult = FacebookService.Login("273882356720887", "email", "user_hometown", "user_birthday", "user_friends", "user_events", "groups_access_member_info", "publish_video");
            fetchLoggedInUser();
            if(m_loginResult.LoggedInUser != null)
            {
                enableLoggedInFeatures();
            }
        }

        private void enableLoggedInFeatures()
        {
            buttonChoosePhoto.Enabled = true;
            buttonPostStatus.Enabled = true;
            checkBoxRememberUser.Enabled = true;
            buttonPostLink.Enabled = true;
            buttonLogOut.Enabled = true;
            buttonFetchGroups.Enabled = true;
        }
        private void disableLoggedInFeatures()
        {
            buttonChoosePhoto.Enabled = false;
            buttonPostStatus.Enabled = false;
            checkBoxRememberUser.Enabled = false;
            buttonPostLink.Enabled = false;
            buttonLogOut.Enabled = false;
            buttonFetchGroups.Enabled = false;
        }

        private void fetchLoggedInUser()
        {
            m_currentUser = m_loginResult.LoggedInUser;
            pictureBox1.Image = m_currentUser.ImageNormal;
        }

        private void postStatus(string post)
        {
            m_currentUser.PostStatus(post);
        }

        //somethings wrong here
        public void on_logOut()
        {
            FacebookService.Logout(ShowByeMsg);
            disableLoggedInFeatures();
        }

        private void ShowByeMsg()
        {
            pictureBox1.Image = null;
            MessageBox.Show("Logged Out!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            Group g = l.SelectedItem as Group;

            textBoxDescriptionOfGroup.Text = g.Description;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            on_logOut();
        }

        private void buttonPostStatus_click(object sender, EventArgs e)
        {
            postStatus(textBox2.Text);
            textBox2.Text = "enter post here";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
                m_currentUser.ReFetch(DynamicWrapper.eLoadOptions.Full);
                FacebookObjectCollection<Group> groupCollection = m_currentUser.Groups;

                foreach (Group g in groupCollection)
                {
                    listBoxGroups.Items.Add(g);
                }

                if (listBoxGroups.Items.Count == 0)
                {
                    listBoxGroups.Items.Add("no items to show");
                }

        }

        private void buttonPostPhoto_Click(object sender, EventArgs e)
        {
            string title = string.Empty;
            if (textBoxTitle.Text != k_EnterTitleMsg)
            {
                title = textBoxTitle.Text;
            }
            try
            {
                m_currentUser.PostPhoto(m_photoPath, title);
                MessageBox.Show("Success uploadin photo!" + Environment.NewLine + Path.GetExtension(m_photoPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must Choose A legal File" + Environment.NewLine + ex.Message);

            }

            resetPictureButtons();

        }

        private void resetPictureButtons()
        {
            pictureBoxPostPhotoPreviewImage.Image = null;
            textBoxTitle.Text = k_EnterTitleMsg;
            buttonPostPhoto.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_photoPath = openFileDialog1.FileName;
            }
            if (!string.IsNullOrEmpty(m_photoPath))
            {
                pictureBoxPostPhotoPreviewImage.LoadAsync(m_photoPath);
                buttonPostPhoto.Enabled = true;
            }
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            m_currentUser.PostLink(webBrowser.Url.ToString());

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWebBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            string urlToShow = comboBox.SelectedItem as string;

            if(!string.IsNullOrEmpty(urlToShow))
            {
                webBrowser.Url = new System.Uri(urlToShow);
            }
        }



        private void buttonSubmitUrl_onClick(object sender, EventArgs e)
        {
            string urlToShow = comboBoxWebBrowser.Text;

            Uri uriResult;
            bool result = Uri.TryCreate(urlToShow, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttp;

            if (result)
            {
                 webBrowser.Url = uriResult;
                comboBoxWebBrowser.Text = uriResult.ToString();
                comboBoxWebBrowser.Items.Add(comboBoxWebBrowser.Text);
            }
            else
            {
                MessageBox.Show(
@"insert a valid http format url.
example:http://www.google.com");
                comboBoxWebBrowser.Text = k_httpOpening;
            }

        }

        private void comboBoxWebBrowser_Click(object sender, EventArgs e)
        {
            comboBoxWebBrowser.Text = k_httpOpening;
        }
    }
}
