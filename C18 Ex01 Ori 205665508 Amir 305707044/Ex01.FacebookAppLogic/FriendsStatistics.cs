using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public class FriendsStatistics
    {
        public const string k_EmptyListMessage = "There are no friends to show!";
        public const string k_NullListMessage = "The friend list is null!";
        public const string k_MissingFriendInfo = "Missing information about friends!!";

        public const int k_YoungestAgeLimit = 20;
        public const int k_MiddleAgeLimit = 40;
        public const int k_AdultAgeLimit = 60;
        public const int k_DaysInYear = 365;

        public const float r_Base = 100f;

        public int Men { get; set; } = 0;

        public float MenRatio { get; set; } = 0f;

        public int Women { get; set; } = 0;

        public float WomenRatio { get; set; } = 0f;

        public int GenderLess { get; set; } = 0;

        public float GenderLessRatio { get; set; } = 0f;

        public int TotalFriends { get; set; } = 0;

        public int UntilTwentyYearsOld { get; set; } = 0;

        public int TwentyOneToFourty { get; set; } = 0;

        public int FourtyOneToSixty { get; set; } = 0;

        public int AboveSixty { get; set; } = 0;

        public int DidntEnterBirthday { get; set; } = 0;

        public float UntilTwentyYearsOldRatio { get; set; } = 0f;

        public float TwentyOneToFourtyRatio { get; set; } = 0f;

        public float FourtyOneToSixtyRatio { get; set; } = 0f;

        public float AboveSixtyRatio { get; set; } = 0f;

        public float DidntEnterBirthdayRatio { get; set; } = 0f;

        public User MostFriendsUser { get; set; } = null;

        public User LeastFriendsUser { get; set; } = null;

        public User MostActiveUser { get; set; } = null;


    }


    abstract class AlgorithmTemplateMethod
    {
        private FriendsStatistics m_StatsProperties;

        public void CalculateStatisticsAboutFriends(FacebookAppEngine i_App)
        {
            DateTime currentDatetime = DateTime.Today;
            FacebookObjectCollection<User> friendList = i_App?.FetchUserFriends();

            //here comes some manipulation on friendList -- > 

            if (friendList != null && friendList.Count > 0)
            {
                m_StatsProperties.TotalFriends = friendList.Count;

                m_StatsProperties.MostFriendsUser = friendList[0];
                m_StatsProperties.MostActiveUser = friendList[0];
                m_StatsProperties.LeastFriendsUser = friendList[0];

                foreach (User friend in friendList)
                {
                    friend.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
                    try
                    {
                        countMenWomen(friend);
                        calculateAgeRange(friend, currentDatetime);
                        calculateMostSocialized(friend);
                        calculateMostActiveFriend(friend);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(FriendsStatistics.k_MissingFriendInfo, ex);
                    }
                }

                calculateAllRatios();
            }
            else if (friendList.Count == 0)
            {
                throw new Exception(FriendsStatistics.k_EmptyListMessage);
            }
            else
            {
                throw new Exception(FriendsStatistics.k_NullListMessage);
            }
        }

        private void calculateMostActiveFriend(User i_Friend)
        {
            if (i_Friend.Statuses.Count > m_StatsProperties.MostActiveUser.Statuses.Count)
            {
                m_StatsProperties.MostActiveUser = i_Friend;
            }
        }

        private void calculateMostSocialized(User i_Friend)
        {
            if (i_Friend.Friends.Count > m_StatsProperties.MostFriendsUser.Friends.Count)
            {
                m_StatsProperties.MostFriendsUser = i_Friend;
            }

            if (i_Friend.Friends.Count < m_StatsProperties.LeastFriendsUser.Friends.Count)
            {
                m_StatsProperties.LeastFriendsUser = i_Friend;
            }
        }

        private void calculateAgeRange(User i_Friend, DateTime i_TodaysDate)
        {
            DateTime friendBirthday = DateTime.ParseExact(i_Friend.Birthday, "dd/mm/yyyy", null);
            if (friendBirthday == null)
            {
                m_StatsProperties.DidntEnterBirthday++;
            }
            else
            {
                TimeSpan exactAge = i_TodaysDate - friendBirthday;
                float age = (float)exactAge.Days / FriendsStatistics.k_DaysInYear;
                if (age <= FriendsStatistics.k_YoungestAgeLimit)
                {
                    m_StatsProperties.UntilTwentyYearsOld++;
                }
                else if (age <= 40)
                {
                    m_StatsProperties.TwentyOneToFourty++;
                }
                else if (age <= 60)
                {
                    m_StatsProperties.FourtyOneToSixty++;
                }
                else
                {
                    m_StatsProperties.AboveSixty++;
                }
            }
        }

        private void calculateAllRatios()
        {
            m_StatsProperties.MenRatio = calculateRatio(m_StatsProperties.Men);
            m_StatsProperties.WomenRatio = calculateRatio(m_StatsProperties.Women);
            m_StatsProperties.GenderLessRatio = calculateRatio(m_StatsProperties.GenderLess);
            
            m_StatsProperties.UntilTwentyYearsOldRatio = calculateRatio(m_StatsProperties.UntilTwentyYearsOld);
            m_StatsProperties.TwentyOneToFourtyRatio = calculateRatio(m_StatsProperties.TwentyOneToFourty);
            m_StatsProperties.FourtyOneToSixtyRatio = calculateRatio(m_StatsProperties.FourtyOneToSixty);
            m_StatsProperties.AboveSixtyRatio = calculateRatio(m_StatsProperties.AboveSixty);
            m_StatsProperties.DidntEnterBirthdayRatio = calculateRatio(m_StatsProperties.DidntEnterBirthday);
        }

        private void countMenWomen(User i_Friend)
        {
            if (i_Friend.Gender == User.eGender.male)
            {
                m_StatsProperties.Men++;
            }
            else if (i_Friend.Gender == User.eGender.female)
            {
                m_StatsProperties.Women++;
            }
            else
            {
                m_StatsProperties.GenderLess++;
            }
        }

        private float calculateRatio(int i_ParameterToCalculate)
        {
            return (float)i_ParameterToCalculate / m_StatsProperties.TotalFriends * FriendsStatistics.r_Base;
        }
    }
}
