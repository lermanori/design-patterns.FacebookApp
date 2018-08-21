using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public enum TasksType {status,photo,link }
    class FbActionFactory
    {
        public static FbAction Create(FacebookAppEngine i_Engine,TasksType i_taskToAutomate)
        {
            FbAction res = null;
            switch(i_taskToAutomate)
            {
                case TasksType.status:
                    res = FbActionPost.Create(i_Engine);
                    break;
                case TasksType.photo:
                    res = FbActionPhoto.Create(i_Engine);
                    break;
                case TasksType.link:
                    res = FbActionLink.Create(i_Engine);
                    break;
            }
            return res;
        }
    }
}
