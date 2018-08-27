using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public enum eTasksType
    {
        Status,
        Photo,
        Link
    }

    public static class FbActionFactory
    {
        public static FbAction Create(FacebookAppEngine i_Engine, eTasksType i_taskToAutomate)
        {
            FbAction res = null;
            switch (i_taskToAutomate)
            {
                case eTasksType.Status:
                    res = FbActionPost.Create(i_Engine);
                    break;
                case eTasksType.Photo:
                    res = FbActionPhoto.Create(i_Engine);
                    break;
                case eTasksType.Link:
                    res = FbActionLink.Create(i_Engine);
                    break;
            }

            return res;
        }
    }
}
