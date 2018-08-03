using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FbActionPost : FbAction
    {
        private FacebookAppEngine m_Engine;

        public override void LoadAction(FbEventArgs e)
        {
            doWhenFinished += PostStatus;
        }

        private void PostStatus(object sender, FbEventArgs e) { m_Engine.PostStatus(e.StatusBody); }

        public static FbActionPost Create(FacebookAppEngine i_engine)
        {
            FbActionPost actionPost = new FbActionPost();
            actionPost.m_Engine = i_engine; 
            return actionPost;
        }
    }
}
