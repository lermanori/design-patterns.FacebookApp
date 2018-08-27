using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FbActionLink : FbAction
    {
        private FbActionLink()
        {
        }

        public static FbActionLink Create(FacebookAppEngine i_Engine)
        {
            return new FbActionLink { m_Engine = i_Engine };
        }

        public override void LoadAction()
        {
            DoWhenFinished += postLinkAction;
        }

        private void postLinkAction(object sender, FbEventArgs e)
        {
            m_Engine.PostChosenLink(e.Link, e.StatusBody);
        }

        public override string GetName()
        {
            return "Post Link";
        }
    }
}
