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
        public const string k_EnterTitleMsg = "Enter Title";
        private readonly string r_MustEnterTextMessage = "You Must Enter Text!" + Environment.NewLine + "Please Try Again.";
        public const string k_EnterPostMessage = "What's On Your Mind?...";
        public const string k_EmptyListMessage = "There Are No Items to Show!";
        public const string k_PhotoUploadSuccededMessage = "Succes Uploading Photo!";
        public const string k_PhotoUploadFailedMessage = "Failed to upload photo, please try again!";
        private readonly string r_EnterValidURLMessage = "Insert a valid http format url." + Environment.NewLine + @"example:http://www.google.com";
        public const string k_httpOpening = @"http://www.";
        public const string k_FailedAutoConnectMessage = "Auto Login Failed, Please Login Again. {0}Reason: {1}";
        public const string k_GeneralStatsLabelText = "{0}: {1} ({2}%)";
        public const string k_Men = "Men";
        public const string k_Women = "Women";
        public const string k_GenderLess = "Genderless";
        public const string k_UntilTwenty = "0 - 20";
        public const string k_TwentyOneToFourty = "21 - 40";
        public const string k_FourtyOneToSixty = "41 - 60";
        public const string k_AboveSixty = "60+";
        public const string k_BirthdatyLess = "No Birthday";
        public const string k_FriendsCountMessage = "Friends with {0} people!";
        public const string k_NumStatusesMessage = "Shared {0} statuses!";
        public const string k_FailedToOperateMessage = "Failed To Perform! Please try again.";
        public const string k_ShickOShookLabelText = "Tell {0} What you think!";
        public const string k_NoPhotosForUser = "{0} has no pictures!";
        public const string k_ShickOShookSuccesfulPostMessage = "You Told the world what you think about {0}'s apperance!";

        private FacebookAppEngine m_FacebookApp = new FacebookAppEngine();
        private FacebookAppSettings m_LastSettings = null;
        //private FriendsStatistics m_StatsAboutMyFriends = new FriendsStatistics();
        //private ShickOShook m_ShickOShook = new ShickOShook();

        private List<Control> m_ControlsToEnableOrDisable = new List<Control>();
        private string m_PhotoPath = string.Empty;

        public FormFacebookApp()
        {
            loadSettingsAndCreateForm();
        }

        private void loadSettingsAndCreateForm()
        {
            m_LastSettings = FacebookAppSettings.LoadFromFile();

            InitializeComponent();
            populateArrayOfControls();
        }

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
            }
        }

        private void populateUIWithUserInfo()
        {
            fetchLoggedInUser();
            enableLoggedInFeatures();
            checkBoxRememberUser.Checked = m_LastSettings.RememberUser;
        }

        private void fetchLoggedInUser()
        {
            pictureBoxProfilePicture.LoadAsync(m_FacebookApp.UserProfilePictureURL);
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
            buttonLogin.Enabled = false;
            buttonLogOut.Enabled = true;

            foreach (Control ctr in m_ControlsToEnableOrDisable)
            {
                ctr.Enabled = true;
            }
        }

        private void populateArrayOfControls()
        {
            m_ControlsToEnableOrDisable.Add(buttonChoosePhoto);
            m_ControlsToEnableOrDisable.Add(buttonPostStatus);
            m_ControlsToEnableOrDisable.Add(checkBoxRememberUser);
            m_ControlsToEnableOrDisable.Add(buttonPostLink);
            m_ControlsToEnableOrDisable.Add(buttonFetchGroups);
            m_ControlsToEnableOrDisable.Add(buttonPostLink);
            m_ControlsToEnableOrDisable.Add(textBoxUploadPost);
            m_ControlsToEnableOrDisable.Add(textBoxTitle);
            m_ControlsToEnableOrDisable.Add(buttonActivateShickOShook);
            m_ControlsToEnableOrDisable.Add(buttonShik);
            m_ControlsToEnableOrDisable.Add(buttonShook);
            m_ControlsToEnableOrDisable.Add(buttonCalcStats);
            m_ControlsToEnableOrDisable.Add(buttonAddNewAction);
            m_ControlsToEnableOrDisable.Add(pictureBoxFriendPhotoShickOShook);


            disableLoggedInFeatures();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            handleUserSettingsWhenClosingTheForm();
            base.OnFormClosing(e);
        }

        private void handleUserSettingsWhenClosingTheForm()
        {
            if (m_FacebookApp.IsLoggedIn() && checkBoxRememberUser.Checked)
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

                m_LastSettings.SaveToFile();
            }
        }

        private void buttonLoginClick(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void handleLogin()
        {
            try
            {
                m_FacebookApp.Login();
                fetchLoggedInUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_FacebookApp.IsLoggedIn())
            {
                enableLoggedInFeatures();

            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            handleLogout();
        }

        private void handleLogout()
        {
            try
            {
                m_FacebookApp.Logout();
                resetUI();
                MessageBox.Show("Logged Out!");
                disableLoggedInFeatures();
                buttonLogOut.Enabled = false;
                buttonLogin.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disableLoggedInFeatures()
        {
            foreach (Control ctr in m_ControlsToEnableOrDisable)
            {
                ctr.Enabled = false;
            }

        }

        private void resetUI()
        {
            pictureBoxProfilePicture.Image = null;
            listBoxGroups.Items.Clear();
            textBoxUploadPost.Text = string.Empty;
            resetPictureButtons();
            pictureBoxFriendPhotoShickOShook.Image = null;
            resetStatsFeature();
            listBoxTasks.Items.Clear();
        }

        private void resetStatsFeature()
        {
            labelMen.Text = string.Format(k_GeneralStatsLabelText, k_Men, "0", "0");
            labelWomen.Text = string.Format(k_GeneralStatsLabelText, k_Women, "0", "0");
            labelGenderLess.Text = string.Format(k_GeneralStatsLabelText, k_GenderLess, "0", "0");

            labelLowestAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_UntilTwenty, "0", "0");
            labelMediumAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_TwentyOneToFourty, "0", "0");
            labelAdultAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_FourtyOneToSixty, "0", "0");
            labelOldestAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_AboveSixty, "0", "0");
            labelDidntEnterBirthday.Text = string.Format(k_GeneralStatsLabelText, k_BirthdatyLess, "0", "0");

            labelMostFriendsUser.Text = string.Empty;
            labelFriendCountMost.Text = string.Empty;
            pictureBoxMostFriends.Image = null;
            labelLeastFriendsUser.Text = string.Empty;
            labelFriendCountLeast.Text = string.Empty;
            pictureBoxLeastFriends.Image = null;

            labelMostActiveUser.Text = string.Empty;
            labelNumStatuses.Text = string.Empty;
            pictureBoxMostActiveUser.Image = null;
        }

        private void buttonPostStatus_click(object sender, EventArgs e)
        {
            PostStatus(textBoxUploadPost.Text);
        }

        public void PostStatus(string i_StatusToPost)
        {
            if (!string.IsNullOrEmpty(textBoxUploadPost.Text) && textBoxUploadPost.Text != k_EnterPostMessage)
            {
                m_FacebookApp.PostStatus(i_StatusToPost);
            }
            else
            {
                MessageBox.Show(r_MustEnterTextMessage);
            }

            textBoxUploadPost.Text = k_EnterPostMessage;
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            populateListBoxGroups();
        }

        private void populateListBoxGroups()
        {

            groupBindingSource.DataSource = m_FacebookApp.CurrentUser.Groups;
            //listBoxGroups.Items.Clear();
            //listBoxGroups.DisplayMember = "Name";
            //try
            //{
            //    FacebookObjectCollection<Group> userGroupCollection = m_FacebookApp.FetchUserGroups();

            //    foreach (Group group in userGroupCollection)
            //    {
            //        listBoxGroups.Items.Add(group);
            //    }

            //    if (listBoxGroups.Items.Count == 0)
            //    {
            //        listBoxGroups.Items.Add(k_EmptyListMessage);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void resetPictureButtons()
        {
            pictureBoxPostPhotoPreviewImage.Image = null;
            textBoxTitle.Text = k_EnterTitleMsg;
            buttonPostPhoto.Enabled = false;
        }

        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            chooseAndLoadPhoto();
        }

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
            catch
            {
                MessageBox.Show(k_PhotoUploadFailedMessage);
            }

            resetPictureButtons();
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }

        private void buttonPostLink_Click(object sender, EventArgs e)
        {
            uploadLink();
        }

        private void uploadLink()
        {
            string linkToPost = webBrowser.Url.ToString();
            m_FacebookApp.PostChosenLink(linkToPost, string.Empty);
        }

        private void comboBoxWebBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            changeURLFromComboBoxSelectedItem();
        }

        private void changeURLFromComboBoxSelectedItem()
        {
            if (!string.IsNullOrEmpty(comboBoxWebBrowser.SelectedItem as string))
            {
                webBrowser.Url = new System.Uri(comboBoxWebBrowser.SelectedItem as string);
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
            bool result = FacebookAppEngine.CreateURL(urlToShow, out uriResult);

            if (result)
            {
                webBrowser.Url = uriResult;
                comboBoxWebBrowser.Text = uriResult.ToString();
                comboBoxWebBrowser.Items.Add(comboBoxWebBrowser.Text);
            }
            else
            {
                MessageBox.Show(r_EnterValidURLMessage);
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

        private void tabPageAutomate_load(object sender, EventArgs e)
        {
            populateListboxWithTimeableActions();
        }

        private void populateListboxWithTimeableActions()
        {
            listBoxActions.Items.Add(FormPostProxyFactory.Create(TasksType.status));
            listBoxActions.Items.Add(FormPostProxyFactory.Create(TasksType.photo));
            listBoxActions.Items.Add(FormPostProxyFactory.Create(TasksType.link));
        }

        private void buttonAddNewCommand_Click(object sender, EventArgs e)
        {
            addATimedCommandToCommit();
        }

        private void addATimedCommandToCommit()
        {
            if (listBoxActions.SelectedItem != null)
            {
                IProxyForm CommandForm = listBoxActions.SelectedItem as IProxyForm;
                DialogResult dialogResult = CommandForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    IfbAutomatable fbTaskToAutomate = CommandForm as IfbAutomatable;
                    FbEventArgs args = (fbTaskToAutomate)?.collectData();
                    TasksType taskType = (TasksType)(fbTaskToAutomate)?.GetTaskType();
                    //TimedComponent timedComponent = TimedComponent.Create(args, m_FacebookApp, taskType); ---> Needs To Be Erased, moved it into the facade
                    TimedComponent timedComponent = m_FacebookApp.CreateTimedComponent(args, taskType);
                    timedComponent.ActionObject.DoWhenFinishedError += (i_object, i_e) => MessageBox.Show("there was a probloem during invoking the action");
                    timedComponent.Timer.Elapsed += Timer_Elapsed;

                    listBoxTasks.Items.Add(timedComponent);
                    timedComponent.Timer.Start();
                }
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            listBoxTasks.Invoke(new Action(() => { RefreshListBox(); }));
        }

        private void RefreshListBox()
        {
            int count = listBoxTasks.Items.Count;
            listBoxTasks.SuspendLayout();
            for (int i = 0; i < count; i++)
            {
                listBoxTasks.Items[i] = listBoxTasks.Items[i];
            }
            listBoxTasks.ResumeLayout();
        }

        private void buttonCalcStats_Click(object sender, EventArgs e)
        {
            activateCalcStatisticsFeature();
        }

        private void activateCalcStatisticsFeature()
        {
            m_FacebookApp.FriendStatisticsFeature.CalculateStatisticsAboutFriends(m_FacebookApp);
            updateUIAccordingToStatistics();
        }

        private void updateUIAccordingToStatistics()
        {
            labelMen.Text = string.Format(k_GeneralStatsLabelText, k_Men, m_FacebookApp.FriendStatisticsFeature.Men, m_FacebookApp.FriendStatisticsFeature.MenRatio.ToString());
            labelWomen.Text = string.Format(k_GeneralStatsLabelText, k_Women, m_FacebookApp.FriendStatisticsFeature.Women, m_FacebookApp.FriendStatisticsFeature.WomenRatio.ToString());
            labelGenderLess.Text = string.Format(k_GeneralStatsLabelText, k_GenderLess, m_FacebookApp.FriendStatisticsFeature.GenderLess, m_FacebookApp.FriendStatisticsFeature.GenderLessRatio.ToString());

            labelLowestAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_UntilTwenty, m_FacebookApp.FriendStatisticsFeature.UntilTwentyYearsOld, m_FacebookApp.FriendStatisticsFeature.UntilTwentyYearsOldRatio);
            labelMediumAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_TwentyOneToFourty, m_FacebookApp.FriendStatisticsFeature.TwentyOneToFourty, m_FacebookApp.FriendStatisticsFeature.TwentyOneToFourtyRatio);
            labelAdultAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_FourtyOneToSixty, m_FacebookApp.FriendStatisticsFeature.FourtyOneToSixty, m_FacebookApp.FriendStatisticsFeature.FourtyOneToSixtyRatio);
            labelOldestAgeRange.Text = string.Format(k_GeneralStatsLabelText, k_AboveSixty, m_FacebookApp.FriendStatisticsFeature.AboveSixty, m_FacebookApp.FriendStatisticsFeature.AboveSixtyRatio);
            labelDidntEnterBirthday.Text = string.Format(k_GeneralStatsLabelText, k_BirthdatyLess, m_FacebookApp.FriendStatisticsFeature.DidntEnterBirthday, m_FacebookApp.FriendStatisticsFeature.DidntEnterBirthdayRatio);

            labelMostFriendsUser.Text = m_FacebookApp.FriendStatisticsFeature.MostFriendsUser.Name;
            labelFriendCountMost.Text = string.Format(k_FriendsCountMessage, m_FacebookApp.FriendStatisticsFeature.MostFriendsUser.Friends.Count);
            pictureBoxMostFriends.LoadAsync(m_FacebookApp.FriendStatisticsFeature.MostFriendsUser.PictureNormalURL);
            labelLeastFriendsUser.Text = m_FacebookApp.FriendStatisticsFeature.LeastFriendsUser.Name;
            labelFriendCountLeast.Text = string.Format(k_FriendsCountMessage, m_FacebookApp.FriendStatisticsFeature.LeastFriendsUser.Friends.Count);
            pictureBoxLeastFriends.LoadAsync(m_FacebookApp.FriendStatisticsFeature.LeastFriendsUser.PictureNormalURL);

            labelMostActiveUser.Text = m_FacebookApp.FriendStatisticsFeature.MostActiveUser.Name;
            labelNumStatuses.Text = string.Format(k_NumStatusesMessage, m_FacebookApp.FriendStatisticsFeature.MostActiveUser.Statuses.Count);
            pictureBoxMostActiveUser.LoadAsync(m_FacebookApp.FriendStatisticsFeature.MostActiveUser.PictureNormalURL);
        }

        private void buttonActivateShikOShook_Click(object sender, EventArgs e)
        {
            activateShickOShook();
        }

        private void activateShickOShook()
        {
            User randomFriend = m_FacebookApp.FetchRandomFriend();
            userBindingSource.DataSource = randomFriend;
            try
            {
                m_FacebookApp.ShickOShookFeature.GetFriendPhotoURLArray(randomFriend);
                if (m_FacebookApp.ShickOShookFeature.friendPhotoURLCollection != null)
                {
                    pictureBoxFriendPhotoShickOShook.LoadAsync(m_FacebookApp.ShickOShookFeature.CurrentPhotoURL);
                    labelTellYourFriends.Text = string.Format(k_ShickOShookLabelText, m_FacebookApp.ShickOShookFeature.CurrentFriendFirstName);
                    labelTellYourFriends.Visible = true;
                   
                }
                else
                {
                    MessageBox.Show(string.Format(k_NoPhotosForUser, randomFriend.FirstName));
                }
            }
            catch
            {
                MessageBox.Show(k_FailedToOperateMessage);
            }
        }

        private void pictureBoxFriendPhotoShickOShook_Click(object sender, EventArgs e)
        {
            m_FacebookApp.ShickOShookFeature.ChangeCurrentPhotoURL();
            pictureBoxFriendPhotoShickOShook.LoadAsync(m_FacebookApp.ShickOShookFeature.CurrentPhotoURL);
        }

        private void buttonShik_Click(object sender, EventArgs e)
        {
            try
            {
                m_FacebookApp.ShickOShookFeature.PublishPost(buttonShik.Text, m_FacebookApp);
                MessageBox.Show(string.Format(k_ShickOShookSuccesfulPostMessage, m_FacebookApp.ShickOShookFeature.CurrentFriendFirstName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShook_Click(object sender, EventArgs e)
        {
            try
            {
                m_FacebookApp.ShickOShookFeature.PublishPost(buttonShook.Text, m_FacebookApp);
                MessageBox.Show(string.Format(k_ShickOShookSuccesfulPostMessage, m_FacebookApp.ShickOShookFeature.CurrentFriendFirstName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
