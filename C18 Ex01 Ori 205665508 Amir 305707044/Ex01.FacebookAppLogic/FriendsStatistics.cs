using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public abstract class FriendsStatistics
    {
        private FriendsStatisticsData m_StatisticData = new FriendsStatisticsData();

        public void CalculateStatisticsAboutFriends(FacebookAppEngine i_App)
        {
            FacebookObjectCollection<User> friendList = i_App?.FetchUserFriends();

            if (friendList != null && friendList.Count > 0)
            {
                friendList = filterListByChoice(friendList);
                m_StatisticData.TotalFriends = friendList.Count;

                foreach (User friend in friendList)
                {
                    friend.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
                    try
                    {
                        m_StatisticData.m_MenAndWomenStats.UpdateGenderCountersAccordingToGivenFriend(friend);
                        m_StatisticData.m_AgesStats.UpdateAgeRangesCountersAccordingToGivenUser(friend);
                        m_StatisticData.m_SocializingStats.UpdateFriendSocializedRanksAccordingToGivenUser(friend);

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(FriendsStatisticsData.k_MissingFriendInfo, ex);
                    }
                }

                calculateAllRatios();
            }
            else if (friendList.Count == 0)
            {
                throw new Exception(FriendsStatisticsData.k_EmptyListMessage);
            }
            else
            {
                throw new Exception(FriendsStatisticsData.k_NullListMessage);
            }
        }

        private void calculateAllRatios()
        {
            m_StatisticData.m_MenAndWomenStats.CalculateGenederRatios(m_StatisticData.TotalFriends);
            m_StatisticData.m_AgesStats.CalculateAgeRangesRatio(m_StatisticData.TotalFriends);
        }

        protected abstract FacebookObjectCollection<User> filterListByChoice(FacebookObjectCollection<User> i_FriendList);

        public string GetGenderDataStrings(eGenders i_Gender)
        {
            string res = "{0}: {1} ({2}%)";

            switch (i_Gender)
            {
                case eGenders.Men:
                    res = string.Format(res, "Men", m_StatisticData.m_MenAndWomenStats.Men, m_StatisticData.m_MenAndWomenStats.MenRatio.ToString());
                    break;
                case eGenders.Women:
                    res = string.Format(res, "Women", m_StatisticData.m_MenAndWomenStats.Women, m_StatisticData.m_MenAndWomenStats.WomenRatio.ToString());
                    break;
                case eGenders.None:
                    res = string.Format(res, "Genderless", m_StatisticData.m_MenAndWomenStats.GenderLess, m_StatisticData.m_MenAndWomenStats.GenderLessRatio.ToString());
                    break;
            }

            return res;
        }

        public string GetAgeDataStrings(eAgeRange i_Range)
        {
            string res = "{0}: {1} ({2}%)";

            switch (i_Range)
            {
                case eAgeRange.UntilTwenty:
                    res = string.Format(res, "0 - 20", m_StatisticData.m_AgesStats.UntilTwentyYearsOld, m_StatisticData.m_AgesStats.UntilTwentyYearsOldRatio);
                    break;
                case eAgeRange.TwentyOneToFourty:
                    res = string.Format(res, "21 - 40", m_StatisticData.m_AgesStats.TwentyOneToFourty, m_StatisticData.m_AgesStats.TwentyOneToFourtyRatio);
                    break;
                case eAgeRange.FourtyOneToSixty:
                    res = string.Format(res, "41 - 60", m_StatisticData.m_AgesStats.FourtyOneToSixty, m_StatisticData.m_AgesStats.FourtyOneToSixtyRatio);
                    break;
                case eAgeRange.AboveSixty:
                    res = string.Format(res, "60+", m_StatisticData.m_AgesStats.AboveSixty, m_StatisticData.m_AgesStats.AboveSixtyRatio);
                    break;
                case eAgeRange.None:
                    res = string.Format(res, "No Birthday", m_StatisticData.m_AgesStats.DidntEnterBirthday, m_StatisticData.m_AgesStats.DidntEnterBirthdayRatio);
                    break;
            }

            return res;
        }

        public string GetFriendName(eUserSocializeState i_WhichUser)
        {
            string res = string.Empty;
            switch (i_WhichUser)
            {
                case eUserSocializeState.MostFriends:
                    res = m_StatisticData.m_SocializingStats.MostFriendsUser.Name;
                    break;
                case eUserSocializeState.LeastFriends:
                    res = m_StatisticData.m_SocializingStats.LeastFriendsUser.Name;
                    break;
                case eUserSocializeState.MostActive:
                    res = m_StatisticData.m_SocializingStats.MostActiveUser.Name;
                    break;
            }
            return res;
        }

        public string GetUserFriendCount(eUserSocializeState i_WhichUser)
        {
            string res = "Friends with {0} people!";
            switch (i_WhichUser)
            {

                case eUserSocializeState.MostFriends:
                    res = string.Format(res, m_StatisticData.m_SocializingStats.MostFriendsUser.Friends.Count);
                    break;
                case eUserSocializeState.LeastFriends:
                    res = string.Format(res, m_StatisticData.m_SocializingStats.LeastFriendsUser.Friends.Count);
                    break;
                case eUserSocializeState.MostActive:
                    res = string.Format(res, m_StatisticData.m_SocializingStats.MostActiveUser.Friends.Count);
                    break;
            }

            return res;
        }

        public string GetMostActiveUserStatusCount()
        {
            string res = "Shared {0} statuses!";

            return string.Format(res, m_StatisticData.m_SocializingStats.MostActiveUser.Statuses.Count);
        }

        public string GetUserPicURL(eUserSocializeState i_WhichUser)
        {
            string res = string.Empty;
            switch (i_WhichUser)
            {
                case eUserSocializeState.MostFriends:
                    res = m_StatisticData.m_SocializingStats.MostFriendsUser.PictureNormalURL;
                    break;
                case eUserSocializeState.LeastFriends:
                    res = m_StatisticData.m_SocializingStats.LeastFriendsUser.PictureNormalURL;
                    break;
                case eUserSocializeState.MostActive:
                    res = m_StatisticData.m_SocializingStats.MostActiveUser.PictureNormalURL;
                    break;
            }
            return res;
        }

    }
}
