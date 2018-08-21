using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FbActionPost : FbAction
    {
        private FacebookAppEngine m_Engine;

        private FbActionPost() { }

        public static FbActionPost Create(FacebookAppEngine i_Engine)
        {
            return new FbActionPost { m_Engine = i_Engine };
        }

        public override void LoadAction()
        {
            doWhenFinished += postStatusAction;
        }

        private void postStatusAction(object sender, FbEventArgs e)
        {
            m_Engine.PostStatus(e.StatusBody);
        }

        public override string GetName()
        {
            return "post status";
        }

    }
}
