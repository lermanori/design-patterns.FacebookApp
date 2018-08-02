using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Ex01.FacebookAppLogic;
using GMap.NET.MapProviders;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppWinformsUI
{
    public partial class FormFacebookApp : Form
    {
        private readonly string k_EnterTitleMsg = "Enter Title";
        private readonly string k_MustEnterTextMessage = "You Must Enter Text!" + Environment.NewLine + "Please Try Again.";
        private readonly string k_EnterPostMessage = "What's On Your Mind?...";
        private readonly object k_EmptyListMessage = "There Are No Items to Show!";
        private readonly string k_PhotoUploadSuccededMessage = "Succes Uploading Photo!";
        private readonly string k_PhotoUploadFailedMessage = "Failed to upload photo, please try again!";
        private readonly string k_EnterValidURLMessage = "Insert a valid http format url." + Environment.NewLine + @"example:http://www.google.com";
        private readonly string k_httpOpening = @"http://www.";
        private readonly string k_FailedAutoConnectMessage = "Auto Login Failed, Please Login Again. {0}Reason: {1}";

        // LoginResult m_LoginResult;
        // User m_currentUser;

        FacebookAppEngine m_FacebookApp = new FacebookAppEngine();
        FacebookAppSettings m_LastSettings = null;
        GeoFeature m_GeoFeature = new GeoFeature();
        string m_PhotoPath = string.Empty;



        //ui
        public FormFacebookApp()
        {
            loadSettingsAndCreateForm();
        }

        private void loadSettingsAndCreateForm()
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
                try
                {
                    m_FacebookApp.Connect(m_LastSettings.LastAccessToken);
                    populateUIWithUserInfo();
                }
                catch (Exception ex)
                {
                    FacebookAppSettings.DeleteFile();
                    MessageBox.Show(string.Format(k_FailedAutoConnectMessage, Environment.NewLine, ex.Message));
                }
                //  m_LoginResult = FacebookService.Connect(m_LastSettings.LastAccessToken);
            }
        }
        private void populateUIWithUserInfo()
        {
            fetchLoggedInUser();
            enableLoggedInFeatures();
        }
        private void fetchLoggedInUser()
        {
            pictureBox1.LoadAsync(m_FacebookApp.UserProfilePictureURL);
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
        private void enableLoggedInFeatures()
        {
            buttonChoosePhoto.Enabled = true;
            buttonPostStatus.Enabled = true;
            checkBoxRememberUser.Enabled = true;
            buttonPostLink.Enabled = true;
            buttonLogOut.Enabled = true;
            buttonFetchGroups.Enabled = true;
            buttonPostLink.Enabled = true;
            tabControlGeo.Enabled = true;
        }

        //ui
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            handleUserSettingsWhenClosingTheForm();
            base.OnFormClosing(e);
        }


        private void handleUserSettingsWhenClosingTheForm()
        {

            if (m_FacebookApp.IsLoggedIn())
            {
                m_LastSettings.RememberUser = this.checkBoxRememberUser.Checked;
                m_LastSettings.LastAccessToken = m_FacebookApp.GetAccessToken();
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

        //ui
        private void handleLogin()
        {
            m_FacebookApp.Login();
            fetchLoggedInUser();

            if (m_FacebookApp.IsLoggedIn())
            {
                enableLoggedInFeatures();
            }
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
            buttonPostLink.Enabled = false;
            tabControlGeo.Enabled = false;
        }

        //ui
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            handleLogout();
        }
        //ui
        private void handleLogout()
        {
            m_FacebookApp.Logout();
            resetUI();
            MessageBox.Show("Logged Out!");

            disableLoggedInFeatures();
        }

        //ui -->Needs to be worked on
        private void resetUI()
        {
            pictureBox1.Image = null;

        }

        //ui
        private void buttonPostStatus_click(object sender, EventArgs e)
        {
            postStatus(textBoxUploadPost.Text);
        }

        //ui
        public void postStatus(string i_StatusToPost)
        {
            if (!string.IsNullOrEmpty(textBoxUploadPost.Text) && textBoxUploadPost.Text != k_EnterPostMessage)
            {
                m_FacebookApp.PostStatus(i_StatusToPost);
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
            populateListboxGroups();
        }

        private void populateListboxGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            FacebookObjectCollection<Group> userGroupCollection = m_FacebookApp.FetchUserGroups();

            foreach (Group group in userGroupCollection)
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
            Group selectedGroup = listBoxGroups.SelectedItem as Group;
            string groupDescription = selectedGroup.Description;
            textBoxDescriptionOfGroup.Text = groupDescription;
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

        //need to check if file is legal
        private void chooseAndLoadPhoto()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_PhotoPath = openFileDialog1.FileName;
            }
            if (!string.IsNullOrEmpty(m_PhotoPath))
            {
                pictureBoxPostPhotoPreviewImage.LoadAsync(m_PhotoPath);
                buttonPostPhoto.Enabled = true;
            }
        }

        //ui
        private void buttonPostPhoto_Click(object sender, EventArgs e)
        {
            handlePhotoUpload();
        }

        private void handlePhotoUpload()
        {
            string title = string.Empty;
            if (textBoxTitle.Text != k_EnterTitleMsg)
            {
                title = textBoxTitle.Text;
            }
            try
            {
                m_FacebookApp.PostChosenPhoto(m_PhotoPath, title);
                MessageBox.Show(k_PhotoUploadSuccededMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(k_PhotoUploadFailedMessage);
            }
            resetPictureButtons();

        }


        //ui
        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }

        private void buttonPostLink_Click(object sender, EventArgs e)
        {
            string linkToPost = webBrowser.Url.ToString();
            m_FacebookApp.PostChosenLink(linkToPost);
        }

        private void comboBoxWebBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ChangeURL(comboBox);
        }

        private void ChangeURL(ComboBox i_ComboBox)
        {
            if (!string.IsNullOrEmpty(i_ComboBox.SelectedItem as string))
            {
                webBrowser.Url = new System.Uri(i_ComboBox.SelectedItem as string);
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
            bool result = m_FacebookApp.CreateURL(urlToShow, out uriResult);

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
            populateListboxFriends();
        }

        private void populateListboxFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            FacebookObjectCollection<User> userFriends = m_FacebookApp.FetchUserFriends();

            foreach (User friend in userFriends)
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

            StringBuilder bio = new StringBuilder();

            if (listBoxFriends.SelectedItems.Count == 1)
            {
                bio.Append((listBoxFriends.SelectedItem as User).LastName);
            }

            textBoxFriendBio.Text = bio.ToString();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            gMapUserFriends.MapProvider = GMapProviders.GoogleMap;
            gMapUserFriends.SetPositionByKeywords("Tel Aviv, Israel");
            gMapUserFriends.ShowCenter = false;
            populateListboxFriends();

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {//think about how to implement lazy creation
            listBoxActions.Items.Add(new FormPostStatus());
        }



        private void buttonAddNewCommand_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null)
            {
                Form CommandForm = listBoxActions.SelectedItem as Form;
                CommandForm.FormClosing += on_closed;
                DialogResult dialogResult = CommandForm.ShowDialog();
            }
        }

        private void on_closed(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel && e.CloseReason == CloseReason.UserClosing)
            {
                collectData(sender);
            }
        }

        private void collectData(object sender)
        {
            if (sender is FormPostStatus)
            {
                FormPostStatus postForm = sender as FormPostStatus;


                string statusBody = postForm.statusBody;
                DateTime timeToExecute = postForm.timeToExecute;

                FbEventArgs args = new FbEventArgs();
                TimedComponent t = new TimedComponent();

                args.postBody = statusBody;
                t.ActionObject = FbActionPost.Create(m_FacebookApp);
                t.ActionObject.loadAction(args);

                t.Timer = new System.Timers.Timer();
                t.DateAndHour = timeToExecute;
                t.Timer.Interval = (timeToExecute - DateTime.Now).Milliseconds > 0 ? (timeToExecute - DateTime.Now).Milliseconds : 1;

                facebookTimerAdapter adapter = new facebookTimerAdapter(t);

                t.Timer.Elapsed += adapter.on_elapsed;

                listBoxTasks.Items.Add(t);

            }
        }

    }

    public class facebookTimerAdapter
    {
        public facebookTimerAdapter(TimedComponent i_timedComponent)
        {
            Timed = i_timedComponent;
        }
        public TimedComponent Timed { get; set; }
        public FbEventArgs Args { get; set; }

        public void on_elapsed(Object source, System.Timers.ElapsedEventArgs e)
        {
            Timed.ActionObject.raiseEvent(Args);

        }
    }
}
