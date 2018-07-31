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
using Ex01.FacebookAppLogic;


namespace Ex01.FacebookAppWinformsUI
{
    public partial class FormFacebookApp : Form
    {
        private readonly string k_EnterTitleMsg = "Enter Title";
        private readonly string k_MustEnterTextMessage = "You Must Enter Text!" + Environment.NewLine + "Please Try Again.";
        private readonly string k_EnterPostMessage = "What's On Your Mind?...";
        private readonly object k_EmptyListMessage = "There Are No Items to Show!";
        private readonly string k_PhotoUploadSuccededMessage = "Succes Uploading Photo!";
        private readonly string k_IllegalFileMessage = "Must Choose A legal File!";
        private readonly string k_EnterValidURLMessage = "Insert a valid http format url." + Environment.NewLine + @"example:http://www.google.com";
        private readonly string k_httpOpening = @"http://www.";

        LoginResult m_LoginResult;
        FacebookAppEngine m_FacebookApp = new FacebookAppEngine();

        FacebookAppSettings m_LastSettings = null;

        string m_photoPath = string.Empty;
        User m_currentUser;



        //ui
        public FormFacebookApp()
        {
            m_LastSettings = FacebookAppSettings.LoadFromFile();
            InitializeComponent();
            this.checkBoxRememberUser.Checked = m_LastSettings.RememberUser;
        }

        //ui
        protected override void OnShown(EventArgs e)
        {
            handleAccountConnectionWhileOpeningForm();
            base.OnShown(e);
        }

        private void handleAccountConnectionWhileOpeningForm()
        {
            if (m_LastSettings.RememberUser && !string.IsNullOrEmpty(m_LastSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_LastSettings.LastAccessToken);
                populateUIWithUserInfo();
            }
        }
        private void populateUIWithUserInfo()
        {
            fetchLoggedInUser();
            enableLoggedInFeatures();
        }

        //ui
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            handleUserSettingsWhenClosingTheForm();
            base.OnFormClosing(e);
        }

        private void handleUserSettingsWhenClosingTheForm()
        {
            if (m_currentUser != null)
            {
                m_LastSettings.RememberUser = this.checkBoxRememberUser.Checked;
                m_LastSettings.LastAccessToken = m_LoginResult.AccessToken;
                foreach (string s in comboBoxWebBrowser.Items)
                {
                    if (!m_LastSettings.ComboBoxWebBrowserItems.Contains(s))
                    {
                        m_LastSettings.ComboBoxWebBrowserItems.Add(s);
                    }
                }
                m_LastSettings.saveToFile();
            }
        }

        //ui
        private void buttonLoginClick(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void handleLogin()
        {
            m_LoginResult = FacebookService.Login("273882356720887", "email", "user_hometown", "user_birthday", "user_friends", "user_events", "groups_access_member_info", "publish_video");
            fetchLoggedInUser();

            if (m_LoginResult.LoggedInUser != null)
            {
                enableLoggedInFeatures();
            }
        }
        //ui
        private void enableLoggedInFeatures()
        {
            buttonChoosePhoto.Enabled = true;
            buttonPostStatus.Enabled = true;
            checkBoxRememberUser.Enabled = true;
            buttonPostLink.Enabled = true;
            buttonLogOut.Enabled = true;
            buttonFetchGroups.Enabled = true;
        }
        //ui
        private void disableLoggedInFeatures()
        {
            buttonChoosePhoto.Enabled = false;
            buttonPostStatus.Enabled = false;
            checkBoxRememberUser.Enabled = false;
            buttonPostLink.Enabled = false;
            buttonLogOut.Enabled = false;
            buttonFetchGroups.Enabled = false;
        }
        //ui
        private void fetchLoggedInUser()
        {
            m_currentUser = m_LoginResult.LoggedInUser;
            pictureBox1.Image = m_currentUser.ImageNormal;

            if (m_LastSettings.ComboBoxWebBrowserItems.Count != 0)
            {
                foreach (string s in m_LastSettings.ComboBoxWebBrowserItems)
                {
                    if (!comboBoxWebBrowser.Items.Contains(s))
                    {
                        comboBoxWebBrowser.Items.Add(s);
                    }
                }
            }
        }

        //ui
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            handleLogout();
        }
        private void handleLogout()
        {
            FacebookService.Logout(ResetUI);
            MessageBox.Show("Logged Out!");
            disableLoggedInFeatures();
        }

        //ui -->Needs to be worked on
        private void ResetUI()
        {
            pictureBox1.Image = null;

        }

        //ui
        private void buttonPostStatus_click(object sender, EventArgs e)
        {
            postStatus(textBoxUploadPost.Text);
        }

        //ui
        public void postStatus(string post)
        {
            if (!string.IsNullOrEmpty(textBoxUploadPost.Text) && textBoxUploadPost.Text != k_EnterPostMessage)
            {
                m_currentUser.PostStatus(post);
            }
            else
            {
                MessageBox.Show(k_MustEnterTextMessage);
            }

            textBoxUploadPost.Text = k_EnterPostMessage;
        }

        //ui
        //need to break into logic and ui
        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            m_currentUser.ReFetch(DynamicWrapper.eLoadOptions.Full);
            FacebookObjectCollection<Group> groupCollection = m_currentUser.Groups;

            foreach (Group group in groupCollection)
            {
                listBoxGroups.Items.Add(group);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                listBoxGroups.Items.Add(k_EmptyListMessage);
            }

        }
        //ui --> need to give meaningful names
        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            Group g = l.SelectedItem as Group;
            textBoxDescriptionOfGroup.Text = g.Description;
        }


        //ui
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
                MessageBox.Show(k_PhotoUploadSuccededMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(k_IllegalFileMessage);
            }
            resetPictureButtons();
        }
        //ui
        private void resetPictureButtons()
        {
            pictureBoxPostPhotoPreviewImage.Image = null;
            textBoxTitle.Text = k_EnterTitleMsg;
            buttonPostPhoto.Enabled = false;
        }

        //ui
        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            chooseAndLoadPhoto();
        }

        private void chooseAndLoadPhoto()
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

        //ui
        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }

        private void buttonPostLink_Click(object sender, EventArgs e)
        {
            m_currentUser.PostLink(webBrowser.Url.ToString());
        }

        private void comboBoxWebBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            chooseWebsite(comboBox);
        }

        private void chooseWebsite(ComboBox i_ComboBox)
        {
            string urlToShow = i_ComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(urlToShow))
            {
                webBrowser.Url = new System.Uri(urlToShow);
            }
        }

        private void buttonSubmitUrl_onClick(object sender, EventArgs e)
        {
            submitUserUrlChoice();
        }

        private void submitUserUrlChoice()
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
                MessageBox.Show(k_EnterValidURLMessage);
                comboBoxWebBrowser.Text = k_httpOpening;
            }
        }

        private void comboBoxWebBrowser_Click(object sender, EventArgs e)
        {
            comboBoxWebBrowser.Text = k_httpOpening;
        }

        private void textBoxUploadPost_Click(object sender, EventArgs e)
        {
            textBoxUploadPost.Text = string.Empty;
        }



        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchUserFriends(); 
        }

        private void fetchUserFriends()
        {
            m_currentUser.ReFetch(DynamicWrapper.eLoadOptions.Full);
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            FacebookObjectCollection<User> friendsCollection = m_currentUser.Friends;

            foreach (User friend in friendsCollection)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
            }

            if (listBoxFriends.Items.Count == 0)
            {
                listBoxFriends.Items.Add(k_EmptyListMessage);
            }

        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

            User friend = new User();
            StringBuilder bio = new StringBuilder();

            if(listBoxFriends.SelectedItems.Count == 1)
            {
                friend = listBoxFriends.SelectedItem as User;
                getBio(friend);
            }
            
            textBoxFriendBio.Text = bio.ToString() ;
        }

        private StringBuilder getBio(User i_Friend)
        {
            StringBuilder bio = new StringBuilder();
            bio.AppendLine(i_Friend.Name);
           // bio.AppendLine(i_Friend.Location.ToString());
            bio.AppendLine(i_Friend.Email);
          //  bio.AppendLine(i_Friend.Hometown.ToString());

            return bio;
        }
    }
}
