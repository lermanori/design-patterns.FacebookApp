using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public class FacebookAppEngine
    {
        private LoginResult m_LoginResult = null;
        private User m_CurrentUser = null;

        public void Login()
        {
            m_LoginResult = FacebookService.Login("273882356720887", "email", "user_hometown", "user_birthday", "user_friends", "user_events", "groups_access_member_info", "publish_video");
            m_CurrentUser = m_LoginResult.LoggedInUser;
        }
        public void Connect(string i_AccessToken)
        {
            m_LoginResult = FacebookService.Connect(i_AccessToken);
            m_CurrentUser = m_LoginResult.LoggedInUser;
        }

        public User CurrentUser
        {
            get { return m_CurrentUser; }
            private set { m_CurrentUser = value; }
        }

        public string GetAccessToken()
        {
            return m_LoginResult.AccessToken;
        }

        public StringBuilder GetUserBio(string o_FriendName)
        {
            StringBuilder bio = new StringBuilder();
            User friendToGet = findUserByName(o_FriendName);

            bio.AppendLine(friendToGet.Name);
            // bio.AppendLine(i_Friend.Location.ToString());
            bio.AppendLine(friendToGet.Email);
            //  bio.AppendLine(i_Friend.Hometown.ToString());
            bio.AppendLine("(Friends with: ");
            foreach (User fof in friendToGet.Friends)
            {
                bio.AppendFormat("{0}, ", fof.FirstName);
            }
            bio.AppendLine(")");

            return bio;
        }

        private User findUserByName(string i_FriendName)
        {
            User userToFind = null;
            foreach(User user in m_CurrentUser.Friends)
            {
                if(user.Name == i_FriendName)
                {
                    userToFind = user;
                    break;
                }
            }
            return userToFind;
        }

        public void Logout()
        {
            FacebookService.Logout(ResetDataAfterLogout);
        }

        private void ResetDataAfterLogout()
        {
            m_CurrentUser = null;
            m_LoginResult = null;
        }

        public void PostStatus(string i_StatusToPost)
        {
            m_CurrentUser.PostStatus(i_StatusToPost);
        }

        public Image GetUserNormalImage()
        {
            return m_CurrentUser.ImageNormal;
        }

        public bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public void refetchUser()
        {
            m_CurrentUser.ReFetch(DynamicWrapper.eLoadOptions.Full);
        }

        public List<string> GetUserGroups()
        {
            List<string> listOfUserGroups = new List<string>();
            refetchUser();

            foreach (Group group in m_CurrentUser.Groups)
            {
                listOfUserGroups.Add(group.Name);
            }

            return listOfUserGroups;

        }

        public string GetUserGroupBio(string o_SelectedGroupName)
        {
            //Group currentGroup = i_SelectedItem as Group;
            Group currentGroup = findGroupByName(o_SelectedGroupName);
            return currentGroup.Description;
        }

        private Group findGroupByName(string i_SelectedGroupName)
        {
            Group groupToFind = null;
            foreach (Group group in m_CurrentUser.Groups)
            {
                if(group.Name == i_SelectedGroupName)
                {
                    groupToFind = group;
                    break;
                }
            }
            return groupToFind;
        }

        public void PostChosenPhoto(string i_PhotoPath, string i_PhotoTitle)
        {
            m_CurrentUser.PostPhoto(i_PhotoPath, i_PhotoTitle);
        }

        public void PostChosenLink(string i_LinkToPost)
        {
            m_CurrentUser.PostLink(i_LinkToPost);
        }

        public bool CreateURL(string i_UrlToShow, out Uri i_UriResult)
        {
            bool result = Uri.TryCreate(i_UrlToShow, UriKind.Absolute, out i_UriResult)
                && i_UriResult.Scheme == Uri.UriSchemeHttp;

            return result;

        }

        public List<string> GetUserFriends()
        {
            List<string> listOfUserFriends = new List<string>();
            refetchUser();
            foreach(User friend in m_CurrentUser.Friends)
            {
                listOfUserFriends.Add(friend.Name.ToString());
                friend.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
            }
            return listOfUserFriends;
        }
    }
}
