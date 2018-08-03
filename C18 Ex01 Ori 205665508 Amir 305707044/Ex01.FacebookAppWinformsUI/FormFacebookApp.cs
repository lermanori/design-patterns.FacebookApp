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

using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppWinformsUI
{
    public partial class FormFacebookApp : Form
    {
        private readonly string r_EnterTitleMsg = "Enter Title";
        private readonly string r_MustEnterTextMessage = "You Must Enter Text!" + Environment.NewLine + "Please Try Again.";
        private readonly string r_EnterPostMessage = "What's On Your Mind?...";
        private readonly object r_EmptyListMessage = "There Are No Items to Show!";
        private readonly string r_PhotoUploadSuccededMessage = "Succes Uploading Photo!";
        private readonly string r_PhotoUploadFailedMessage = "Failed to upload photo, please try again!";
        private readonly string r_EnterValidURLMessage = "Insert a valid http format url." + Environment.NewLine + @"example:http://www.google.com";
        private readonly string r_httpOpening = @"http://www.";
        private readonly string r_FailedAutoConnectMessage = "Auto Login Failed, Please Login Again. {0}Reason: {1}";

        private readonly string r_GeneralStatsLabelText = "{0}: {1} ({2}%)";
        private readonly string r_Men = "Men";
        private readonly string r_Women = "Women";
        private readonly string r_GenderLess = "Genderless";
        private readonly string r_UntilTwenty = "0 - 20";
        private readonly string r_TwentyOneToFourty = "21 - 40";
        private readonly string r_FourtyOneToSixty = "41 - 60";
        private readonly string r_AboveSixty = "60+";
        private readonly string r_BirthdatyLess = "No Birthday";

        private readonly string r_FriendsCountMessage = "Friends with {0} people!";
        private readonly string r_NumStatusesMessage = "Shared {0} statuses!";
        // LoginResult m_LoginResult;
        // User m_currentUser;

        private FacebookAppEngine m_FacebookApp = new FacebookAppEngine();
        private FacebookAppSettings m_LastSettings = null;
        private FriendsStatistics m_StatsAboutMyFriends = new FriendsStatistics();

        private string m_PhotoPath = string.Empty;

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
                    MessageBox.Show(string.Format(r_FailedAutoConnectMessage, Environment.NewLine, ex.Message));
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
            if (!string.IsNullOrEmpty(textBoxUploadPost.Text) && textBoxUploadPost.Text != r_EnterPostMessage)
            {
                m_FacebookApp.PostStatus(i_StatusToPost);
            }
            else
            {
                MessageBox.Show(r_MustEnterTextMessage);
            }

            textBoxUploadPost.Text = r_EnterPostMessage;
        }

        //ui
        //need to break into logic and ui
        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            populateListBoxGroups();
        }

        private void populateListBoxGroups()
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
                listBoxGroups.Items.Add(r_EmptyListMessage);
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
            textBoxTitle.Text = r_EnterTitleMsg;
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
            if (textBoxTitle.Text != r_EnterTitleMsg)
            {
                title = textBoxTitle.Text;
            }
            try
            {
                m_FacebookApp.PostChosenPhoto(m_PhotoPath, title);
                MessageBox.Show(r_PhotoUploadSuccededMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(r_PhotoUploadFailedMessage);
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
            changeURL(comboBox);
        }

        private void changeURL(ComboBox i_ComboBox)
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
                MessageBox.Show(r_EnterValidURLMessage);
                comboBoxWebBrowser.Text = r_httpOpening;
            }
        }

        private void comboBoxWebBrowser_Click(object sender, EventArgs e)
        {
            comboBoxWebBrowser.Text = r_httpOpening;
        }

        private void textBoxUploadPost_Click(object sender, EventArgs e)
        {
            textBoxUploadPost.Text = string.Empty;
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            populateListBoxFriends();
        }

        private void populateListBoxFriends()
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
                listBoxFriends.Items.Add(r_EmptyListMessage);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;

                updateShownFriend(selectedFriend);
            }
            catch { }
        }

        private void updateShownFriend(User i_SelectedFriend)
        {
            pictureBoxFriendProfilePic.LoadAsync(i_SelectedFriend.PictureNormalURL);

        }

        private void showFriendsStatistics()
        {

        }

        private void tabPage3_load(object sender, EventArgs e)
        {//think about how to implement lazy creation
            listBoxActions.Items.Add(new FormPostStatus());
        }

        private void buttonAddNewCommand_Click(object sender, EventArgs e)
        {
            if (listBoxActions.SelectedItem != null)
            {
                Form CommandForm = listBoxActions.SelectedItem as Form;
                DialogResult dialogResult = CommandForm.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    collectData(CommandForm);
                }
            }
        }


        private void collectData(object sender)
        {
            if (sender is FormPostStatus)
            {
                FormPostStatus postForm = sender as FormPostStatus;

        private void collectDataForPost(object sender)
        {
            FormPostStatus postForm = sender as FormPostStatus;

            string statusBody = postForm.StatusBody;
            DateTime timeToExecute = postForm.TimeToExecute;

            FbEventArgs args = new FbEventArgs();
            TimedComponent t = new TimedComponent();

            args.StatusBody = statusBody;
            t.ActionObject = FbActionPost.Create(m_FacebookApp);
            t.ActionObject.LoadAction(args);

            t.Timer = new System.Timers.Timer();
            t.Timer.Enabled = false;
            t.DateAndHour = timeToExecute;

            if ((timeToExecute - DateTime.Now).TotalMilliseconds > 0)
            {
                t.Timer.Interval = (timeToExecute - DateTime.Now).TotalMilliseconds;
            }
            else
            {
                t.Timer.Interval = (1000) * 5;
            }

            FacebookTimerAdapter adapter = new FacebookTimerAdapter(t);
            adapter.Args = args;
            adapter.Timed.Timer = t.Timer;

            listBoxTasks.Items.Add(adapter.Timed);

            adapter.Timed.Timer.Elapsed += new System.Timers.ElapsedEventHandler(adapter.on_elapsed);
            adapter.Timed.Timer.AutoReset = false;
            adapter.Timed.Timer.Enabled = true;
        }

        private void buttonCalcStats_Click(object sender, EventArgs e)
        {
            m_StatsAboutMyFriends.CalculateStatisticsAboutFriends(m_FacebookApp);

            updateUIAccordingToStatistics();
        }

        private void updateUIAccordingToStatistics()
        {
            labelMen.Text = string.Format(r_GeneralStatsLabelText, r_Men, m_StatsAboutMyFriends.Men, m_StatsAboutMyFriends.MenRatio.ToString());
            labelWomen.Text = string.Format(r_GeneralStatsLabelText, r_Women, m_StatsAboutMyFriends.Women, m_StatsAboutMyFriends.WomenRatio.ToString());
            labelGenderLess.Text = string.Format(r_GeneralStatsLabelText, r_GenderLess, m_StatsAboutMyFriends.GenderLess, m_StatsAboutMyFriends.GenderLessRatio.ToString());

            labelLowestAgeRange.Text = string.Format(r_GeneralStatsLabelText, r_UntilTwenty, m_StatsAboutMyFriends.UntilTwentyYearsOld, m_StatsAboutMyFriends.UntilTwentyYearsOldRatio);
            labelMediumAgeRange.Text = string.Format(r_GeneralStatsLabelText, r_TwentyOneToFourty, m_StatsAboutMyFriends.TwentyOneToFourty, m_StatsAboutMyFriends.TwentyOneToFourtyRatio);
            labelAdultAgeRange.Text = string.Format(r_GeneralStatsLabelText, r_FourtyOneToSixty, m_StatsAboutMyFriends.FourtyOneToSixty, m_StatsAboutMyFriends.FourtyOneToSixtyRatio);
            labelOldestAgeRange.Text = string.Format(r_GeneralStatsLabelText, r_AboveSixty, m_StatsAboutMyFriends.AboveSixty, m_StatsAboutMyFriends.AboveSixtyRatio);
            labelDidntEnterBirthday.Text = string.Format(r_GeneralStatsLabelText, r_BirthdatyLess, m_StatsAboutMyFriends.DidntEnterBirthday, m_StatsAboutMyFriends.DidntEnterBirthdayRatio);

            labelMostFriendsUser.Text = m_StatsAboutMyFriends.MostFriendsUser.Name;
            labelFriendCountMost.Text = string.Format(r_FriendsCountMessage, m_StatsAboutMyFriends.MostFriendsUser.Friends.Count);
            pictureBoxMostFriends.LoadAsync(m_StatsAboutMyFriends.MostFriendsUser.PictureNormalURL);
            labelLeastFriendsUser.Text = m_StatsAboutMyFriends.LeastFriendsUser.Name;
            labelFriendCountLeast.Text = string.Format(r_FriendsCountMessage, m_StatsAboutMyFriends.LeastFriendsUser.Friends.Count);
            pictureBoxLeastFriends.LoadAsync(m_StatsAboutMyFriends.LeastFriendsUser.PictureNormalURL);

            labelMostActiveUser.Text = m_StatsAboutMyFriends.MostActiveUser.Name;
            labelNumStatuses.Text = String.Format(r_NumStatusesMessage, m_StatsAboutMyFriends.MostActiveUser.Statuses.Count);
            pictureBoxMostActiveUser.LoadAsync(m_StatsAboutMyFriends.MostActiveUser.PictureNormalURL);
        }
    }

    public class FacebookTimerAdapter
    {
        private bool m_ProcessOnlyOnce = false;
        public FacebookTimerAdapter(TimedComponent i_timedComponent)
        {
            Timed = i_timedComponent;
        }
        public TimedComponent Timed { get; set; }
        public FbEventArgs Args { get; set; }
        public void on_elapsed(Object source, System.Timers.ElapsedEventArgs e)
        {
            if(!m_ProcessOnlyOnce)
            {
            m_ProcessOnlyOnce = true;
            Timed.ActionObject.raiseEvent(Args);
            MessageBox.Show("event raisen at" + DateTime.Now.ToString());
            Timed.Timer.Enabled = false;
            Timed.Timer.Elapsed -= on_elapsed;
            }
        }
    }
}
