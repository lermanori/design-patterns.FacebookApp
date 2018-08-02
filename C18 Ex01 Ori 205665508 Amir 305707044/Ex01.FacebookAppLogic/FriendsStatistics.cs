using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public class FriendsStatistics
    {
        public const int k_YoungestAgeLimit = 20;
        public const int k_MiddleAgeLimit = 40;
        public const int k_AdultAgeLimit = 60;
        private const int k_DaysInYear = 365;

        private readonly float r_Base = 100f;

        public int Men { get; private set; } = 0;
        public float MenRatio { get; private set; } = 0f;
        public int Women { get; private set; } = 0;
        public float WomenRatio { get; private set; } = 0f;
        public int GenderLess { get; private set; } = 0;
        public float GenderLessRatio { get; private set; } = 0f;
        public int Total { get; set; } = 0;

        public int UntilTwentyYearsOld { get; private set; } = 0;
        public int TwentyOneToFourty { get; private set; } = 0;
        public int FourtyOneToSixty { get; private set; } = 0;
        public int AboveSixty { get; private set; } = 0;
        public int DidntEnterBirthday { get; private set; } = 0;

        public float UntilTwentyYearsOldRatio { get; private set; } = 0f;
        public float TwentyOneToFourtyRatio { get; private set; } = 0f;
        public float FourtyOneToSixtyRatio { get; private set; } = 0f;
        public float AboveSixtyRatio { get; private set; } = 0f;
        public float DidntEnterBirthdayRatio { get; private set; } = 0f;

        public User MostFriendsUser { get; private set; } = null;
        public User LeastFriendsUser { get; private set; } = null;

        public User MostActiveUser { get; private set; } = null;

        public void CalculateStatisticsAboutFriends(FacebookAppEngine i_App)
        {
            DateTime currentDatetime = DateTime.Today;
            FacebookObjectCollection<User> friendList = i_App.FetchUserFriends();

            Total = friendList.Count;
            MostFriendsUser = friendList[0];
            MostActiveUser = friendList[0];

            LeastFriendsUser = friendList[0];

            foreach (User friend in friendList)
            {
                friend.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
                countMenWomen(friend);
                calculateAgeRange(friend, currentDatetime);
                calculateMostSocialized(friend);
                calculateMostActiveFriend(friend);
            }

            calculateAllRatios();
        }

        private void calculateMostActiveFriend(User i_Friend)
        {
            if(i_Friend.Statuses.Count > MostActiveUser.Statuses.Count)
            {
                MostActiveUser = i_Friend;
            }
        }

        private void calculateMostSocialized(User friend)
        {
            if (friend.Friends.Count > MostFriendsUser.Friends.Count)
            {
                MostFriendsUser = friend;
            }

            if (friend.Friends.Count < LeastFriendsUser.Friends.Count)
            {
                LeastFriendsUser = friend;
            }
        }

        private void calculateAllRatios()
        {
            MenRatio = calculateRatio(Men);
            WomenRatio = calculateRatio(Women);
            GenderLessRatio = calculateRatio(GenderLess);

            UntilTwentyYearsOldRatio = calculateRatio(UntilTwentyYearsOld);
            TwentyOneToFourtyRatio = calculateRatio(TwentyOneToFourty);
            FourtyOneToSixtyRatio = calculateRatio(FourtyOneToSixty);
            AboveSixtyRatio = calculateRatio(AboveSixty);
            DidntEnterBirthdayRatio = calculateRatio(DidntEnterBirthday);

        }

        private void countMenWomen(User i_Friend)
        {
            if (i_Friend.Gender == User.eGender.male)
            {
                Men++;
            }
            else if (i_Friend.Gender == User.eGender.female)
            {
                Women++;
            }
            else
            {
                GenderLess++;
            }
        }
        private void calculateAgeRange(User i_Friend, DateTime i_TodaysDate)
        {
            DateTime friendBirthday = DateTime.ParseExact(i_Friend.Birthday, "dd/mm/yyyy", null);
            if (friendBirthday == null)
            {
                DidntEnterBirthday++;

            }
            else
            {
                TimeSpan exactAge = i_TodaysDate - friendBirthday;
                float age = (float)exactAge.Days / k_DaysInYear;
                if (age <= k_YoungestAgeLimit)
                {
                    UntilTwentyYearsOld++;
                }
                else if (age <= 40)
                {
                    TwentyOneToFourty++;
                }
                else if (age <= 60)
                {
                    FourtyOneToSixty++;
                }
                else
                {
                    AboveSixty++;
                }
            }
        }




        private float calculateRatio(int i_ParameterToCalculate)
        {
            return (float)i_ParameterToCalculate / Total * r_Base;
        }
    }
}
