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
        public const string k_AppID = "273882356720887";
        public const string k_PermissionsNeeded = @"email, user_birthday, user_hometown, user_location, user_likes, user_events, user_photos, user_videos, 
                                                        user_friends, user_tagged_places, user_posts, user_gender, user_link, publish_video, 
                                                        groups_access_member_info, public_profile ";

        public const string k_LoginFailedMessage = "Login Failed!";
        public const string k_LogoutFailedMessage = "Logout Failed!";
        public const string k_PostStatusFailedMessage = "Post Status Failed!";
        public const string k_FailedToUpdateMessage = "Failed to update user";
        public const string k_FailedToUpload = "Failed to Upload! Try Again";

        private LoginResult m_LoginResult = null;

        public User CurrentUser { get; private set; }

        public string UserProfilePictureURL { get; private set; }

        public void Login()
        {
            try
            {
                m_LoginResult = FacebookService.Login(k_AppID, k_PermissionsNeeded);
                initializeMembersAfterSuccessfulConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(k_LoginFailedMessage, ex);
            }
        }

        public void Connect(string i_AccessToken)
        {
            try
            {
                m_LoginResult = FacebookService.Connect(i_AccessToken);
                initializeMembersAfterSuccessfulConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(k_LoginFailedMessage, ex);
            }
        }

        private void initializeMembersAfterSuccessfulConnection()
        {
            CurrentUser = m_LoginResult.LoggedInUser;
            UserProfilePictureURL = CurrentUser.PictureNormalURL;
        }

        public string GetAccessToken()
        {
            return m_LoginResult?.AccessToken;
        }

        public void Logout()
        {
            try
            {
                FacebookService.Logout(resetDataAfterLogout);
            }
            catch (Exception ex)
            {
                throw new Exception(k_LogoutFailedMessage, ex);
            }
        }

        private void resetDataAfterLogout()
        {
            CurrentUser = null;
            m_LoginResult = null;
            UserProfilePictureURL = null;
        }

        public void PostStatus(string i_StatusToPost)
        {
            try
            {
                CurrentUser.PostStatus(i_StatusToPost);
            }
            catch (Exception ex)
            {
                throw new Exception(k_PostStatusFailedMessage, ex);
            }
        }

        public bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        private void refetchUser()
        {
            try
            {
                CurrentUser.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
            }
            catch (Exception ex)
            {
                throw new Exception(k_FailedToUpdateMessage, ex);
            }
        }

        public FacebookObjectCollection<Group> FetchUserGroups()
        {
            return CurrentUser?.Groups;
        }

        public FacebookObjectCollection<Checkin> FetchUserCheckins()
        {
            return CurrentUser?.Checkins;
        }

        public FacebookObjectCollection<Photo> FetchUserPhotos()
        {
            FacebookObjectCollection<Photo> collectionOfUserPhotos = new FacebookObjectCollection<Photo>();
            refetchUser();

            foreach (Album album in CurrentUser?.Albums)
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
            return CurrentUser?.Friends;
        }

        public void PostChosenPhoto(string i_PhotoPath, string i_PhotoTitle)
        {
            try
            {
                CurrentUser.PostPhoto(i_PhotoPath, i_PhotoTitle);
            }
            catch (Exception ex)
            {
                throw new Exception(k_FailedToUpload, ex);
            }
        }

        public void PostChosenLink(string i_LinkToPost)
        {
            try
            {
                CurrentUser.PostLink(i_LinkToPost, string.Empty);
            }
            catch (Exception ex)
            {
                throw new Exception(k_FailedToUpload, ex);
            }
        }

        public static bool CreateURL(string i_UrlToShow, out Uri o_UriResult)
        {
            bool result = Uri.TryCreate(i_UrlToShow, UriKind.Absolute, out o_UriResult)
                && o_UriResult.Scheme == Uri.UriSchemeHttp;

            return result;
        }

        public User FetchRandomFriend()
        {
            User randomFriend = null;
            Random randomFriendIndex = new Random();
            int randomNumber = randomFriendIndex.Next(CurrentUser.Friends.Count);

            randomFriend = CurrentUser?.Friends[randomNumber];
            return randomFriend;
        }
    }
}
