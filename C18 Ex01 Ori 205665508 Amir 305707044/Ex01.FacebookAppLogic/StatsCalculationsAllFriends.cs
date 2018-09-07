using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic
{
    public class StatsCalculationsAllFriends : FriendsStatistics
    {
        protected override FacebookObjectCollection<User> filterListByChoice(FacebookObjectCollection<User> i_FriendList)
        {
            // default implementation - no filters needed
            return i_FriendList;
        }
    }
}
