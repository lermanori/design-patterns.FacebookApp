using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public static class FormPostProxyFactory
    {
        public static IProxyForm Create(eTasksType i_TaskToAutomate)
        {
            IProxyForm res = null;
            switch (i_TaskToAutomate)
            {
                case eTasksType.Status:
                    res = FormPostStatusProxy.Create();
                    break;
                case eTasksType.Photo:
                    res = FormPostPhotoProxy.Create();
                    break;
                case eTasksType.Link:
                    res = FormPostLinkProxy.Create();
                    break;
            }

            return res;
        }
    }
}
