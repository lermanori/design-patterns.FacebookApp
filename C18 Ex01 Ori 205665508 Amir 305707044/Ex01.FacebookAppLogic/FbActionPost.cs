using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FbActionPost : FbAction
    {
        public override void loadAction(FbEventArgs e)
        {
            doWhenFinished += postStatus;
        }
        public event EventHandler<FbEventArgs> doWhenFinished;
        private void postStatus(object sender, FbEventArgs e) { m_engine.PostStatus(e.postBody); }
        private FacebookAppEngine m_engine;
        public static FbActionPost Create(FacebookAppEngine i_engine)
        {
            FbActionPost actionPost = new FbActionPost();
            actionPost.m_engine = i_engine; 
            return actionPost;
        }
    }
}
