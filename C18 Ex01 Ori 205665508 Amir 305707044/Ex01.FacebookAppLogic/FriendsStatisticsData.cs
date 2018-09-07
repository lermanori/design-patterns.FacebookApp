using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public enum eGenders
    {
        Men = 0,
        Women,
        None
    }

    public enum eAgeRange
    {
        UntilTwenty,
        TwentyOneToFourty,
        FourtyOneToSixty,
        AboveSixty,
        None
    }

    public enum eUserSocializeState
    {
        MostFriends,
        LeastFriends,
        MostActive
    }

    public class FriendsStatisticsData
    {
        public const string k_EmptyListMessage = "There are no friends to show!";
        public const string k_NullListMessage = "The friend list is null!";
        public const string k_MissingFriendInfo = "Missing information about friends!!";

        public const int k_YoungestAgeLimit = 20;
        public const int k_MiddleAgeLimit = 40;
        public const int k_AdultAgeLimit = 60;
        public const int k_DaysInYear = 365;

        public const float r_Base = 100f;

        public int TotalFriends { get; set; } = 0;

        public class GenderSplit
        {
            public int Men { get; private set; } = 0;

            public float MenRatio { get; private set; } = 0f;

            public int Women { get; private set; } = 0;

            public float WomenRatio { get; private set; } = 0f;

            public int GenderLess { get; private set; } = 0;

            public float GenderLessRatio { get; private set; } = 0f;

            public void UpdateGenderCountersAccordingToGivenFriend(User i_Friend)
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

            public void CalculateGenederRatios(int i_TotalGroupParticipants)
            {
                MenRatio = CalculateRatio(Men, i_TotalGroupParticipants);
                WomenRatio = CalculateRatio(Women, i_TotalGroupParticipants);
                GenderLessRatio = CalculateRatio(GenderLess, i_TotalGroupParticipants);
            }
        }

        public class AgesSplit
        {
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

            public void UpdateAgeRangesCountersAccordingToGivenUser(User i_Friend)
            {
                DateTime friendBirthday = DateTime.ParseExact(i_Friend.Birthday, "dd/mm/yyyy", null);
                if (friendBirthday == null)
                {
                    DidntEnterBirthday++;
                }
                else
                {
                    TimeSpan exactAge = DateTime.Today - friendBirthday;
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

            public void CalculateAgeRangesRatio(int i_TotalGroupParticipants)
            {
                UntilTwentyYearsOldRatio = CalculateRatio(UntilTwentyYearsOld, i_TotalGroupParticipants);
                TwentyOneToFourtyRatio = CalculateRatio(TwentyOneToFourty, i_TotalGroupParticipants);
                FourtyOneToSixtyRatio = CalculateRatio(FourtyOneToSixty, i_TotalGroupParticipants);
                AboveSixtyRatio = CalculateRatio(AboveSixty, i_TotalGroupParticipants);
                DidntEnterBirthdayRatio = CalculateRatio(DidntEnterBirthday, i_TotalGroupParticipants);
            }
        }

        public class UserSocializingRankSplit
        {
            public User MostFriendsUser { get; private set; } = null;

            public User LeastFriendsUser { get; private set; } = null;

            public User MostActiveUser { get; private set; } = null;

            private bool m_IsFirstCheck = true;

            private void updateMostActiveFriend(User i_Friend)
            {
                if (i_Friend.Statuses.Count > MostActiveUser.Statuses.Count)
                {
                    MostActiveUser = i_Friend;
                }
            }

            private void updateMostSocialized(User i_Friend)
            {
                if (i_Friend.Friends.Count > MostFriendsUser.Friends.Count)
                {
                    MostFriendsUser = i_Friend;
                }

                if (i_Friend.Friends.Count < LeastFriendsUser.Friends.Count)
                {
                    LeastFriendsUser = i_Friend;
                }
            }

            public void UpdateFriendSocializedRanksAccordingToGivenUser(User i_Friend)
            {
                if (m_IsFirstCheck)
                {
                    MostFriendsUser = MostActiveUser = LeastFriendsUser = i_Friend;
                    m_IsFirstCheck = false;
                }

                updateMostSocialized(i_Friend);
                updateMostActiveFriend(i_Friend);
            }
        }

        public GenderSplit m_MenAndWomenStats = new GenderSplit();
        public AgesSplit m_AgesStats = new AgesSplit();
        public UserSocializingRankSplit m_SocializingStats = new UserSocializingRankSplit();

        public static float CalculateRatio(int i_ParameterToCalculate, int i_TotalValue)
        {
            return (float)i_ParameterToCalculate / i_TotalValue * r_Base;
        }
    }
}
