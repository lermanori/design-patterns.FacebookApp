using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    class FbActionLink : FbAction
    {
        private FacebookAppEngine m_Engine;

        private FbActionLink() { }

        public static FbActionLink Create(FacebookAppEngine i_Engine)
        {
            return new FbActionLink { m_Engine = i_Engine };
        }

        public override void LoadAction()
        {
            doWhenFinished += postLinkAction;
        }

        private void postLinkAction(object sender, FbEventArgs e)
        {
            m_Engine.PostChosenLink(e.link,e.StatusBody);
        }

        public override string GetName()
        {
            return "post Link";
        }
    }
}
