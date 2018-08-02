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
        private readonly string k_AppID = "273882356720887";
        private readonly string k_PermissionsNeeded = @"email, user_birthday, user_hometown, user_location, user_likes, user_events, user_photos, user_videos, 
                                                        user_friends, user_tagged_places, user_posts, user_gender, user_link, publish_video, 
                                                        groups_access_member_info, public_profile ";

        private LoginResult m_LoginResult = null;

        public User CurrentUser { get; private set; }

        public string UserProfilePictureURL { get; private set; }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(k_AppID, k_PermissionsNeeded);
            initializeMembersAfterSuccessfulConnection();
        }

        public void Connect(string i_AccessToken)
        {
            m_LoginResult = FacebookService.Connect(i_AccessToken);
            initializeMembersAfterSuccessfulConnection();
        }

        private void initializeMembersAfterSuccessfulConnection()
        {
            CurrentUser = m_LoginResult.LoggedInUser;
            UserProfilePictureURL = CurrentUser.PictureNormalURL;
        }

        public string GetAccessToken()
        {
            return m_LoginResult.AccessToken;
        }

        public void Logout()
        {
            FacebookService.Logout(resetDataAfterLogout);
        }

        private void resetDataAfterLogout()
        {
            CurrentUser = null;
            m_LoginResult = null;
            UserProfilePictureURL = null;
        }

        public void PostStatus(string i_StatusToPost)
        {
            CurrentUser.PostStatus(i_StatusToPost);
        }

        public bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public void refetchUser()
        {
            CurrentUser.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
        }

        public FacebookObjectCollection<Group> FetchUserGroups()
        {
            return CurrentUser.Groups;
        }

        public FacebookObjectCollection<Checkin> FetchUserCheckins()
        {
            return CurrentUser.Checkins;
        }

        public FacebookObjectCollection<Photo> FetchUserPhotos()
        {
            FacebookObjectCollection<Photo> collectionOfUserPhotos = new FacebookObjectCollection<Photo>();
            refetchUser();

            foreach (Album album in CurrentUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    collectionOfUserPhotos.Add(photo);
                }
            }

            return collectionOfUserPhotos;
        }

        public FacebookObjectCollection<User> FetchUserFriends()
        {
            return CurrentUser.Friends;
        }

        public void PostChosenPhoto(string i_PhotoPath, string i_PhotoTitle)
        {
            CurrentUser.PostPhoto(i_PhotoPath, i_PhotoTitle);
        }

        public void PostChosenLink(string i_LinkToPost)
        {
            CurrentUser.PostLink(i_LinkToPost);
        }

        public bool CreateURL(string i_UrlToShow, out Uri i_UriResult)
        {
            bool result = Uri.TryCreate(i_UrlToShow, UriKind.Absolute, out i_UriResult)
                && i_UriResult.Scheme == Uri.UriSchemeHttp;

            return result;
        }
    }
}
