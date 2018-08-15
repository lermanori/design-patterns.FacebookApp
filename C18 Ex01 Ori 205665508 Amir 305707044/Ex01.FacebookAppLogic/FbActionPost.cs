using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FbActionPost : FbAction
    {
        private FacebookAppEngine m_Engine;

        public static FbActionPost Create(FacebookAppEngine i_Engine)
        {
            FbActionPost actionPost = new FbActionPost();
            actionPost.m_Engine = i_Engine; 
            return actionPost;
        }

        public override void LoadAction(FbEventArgs e)
        {
            doWhenFinished += postStatusAction;
        }

        private void postStatusAction(object sender, FbEventArgs e)
        {
            m_Engine.PostStatus(e.StatusBody);
        }
    }
}
