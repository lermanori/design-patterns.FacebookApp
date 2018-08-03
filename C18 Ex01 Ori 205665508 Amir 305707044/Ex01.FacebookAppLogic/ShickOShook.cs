using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public class ShickOShook
    {
        public const string k_StatusMessage = "I think {0} is definitely {1}!";

        public List<string> friendPhotoURLCollection { get; private set; } = null;

        public string CurrentPhotoURL { get; private set; } = null;

        public string CurrentFriendFirstName { get; private set; } = null;

        public string CurrentFriendFullName { get; private set; } = null;

        public void GetFriendPhotoURLArray(User i_Friend)
        {
            i_Friend?.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);

            List<string> friendPhotosURLs = new List<string>();

            foreach (Album album in i_Friend?.Albums)
            {
                foreach (Photo p in album.Photos)
                {
                    friendPhotosURLs.Add(p.PictureNormalURL);
                }
            }

            if (friendPhotosURLs.Count > 0)
            {
                friendPhotoURLCollection = friendPhotosURLs;
                ChangeCurrentPhotoURL();
                CurrentFriendFirstName = i_Friend.FirstName;
                CurrentFriendFullName = i_Friend.Name;
            }
        }

        public void ChangeCurrentPhotoURL()
        {
            Random randomObject = new Random();
            if (friendPhotoURLCollection != null)
            {
                int index = randomObject.Next(friendPhotoURLCollection.Count);
                CurrentPhotoURL = friendPhotoURLCollection[index];
            }
        }

        public void PublishPost(string i_Text, FacebookAppEngine i_FacebookApp)
        {
            i_FacebookApp.PostStatus(string.Format(k_StatusMessage, CurrentFriendFullName, i_Text));
        }
    }
}
