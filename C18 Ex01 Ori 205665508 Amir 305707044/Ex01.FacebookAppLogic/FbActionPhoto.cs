using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppLogic
{
    public class FbActionPhoto : FbAction
    {
        private FbActionPhoto()
        {
        }

        public static FbActionPhoto Create(FacebookAppEngine i_Engine)
        {
            return new FbActionPhoto { m_Engine = i_Engine };
        }

        public override void LoadAction()
        {
            DoWhenFinished += postPhotoAction;
        }

        private void postPhotoAction(object sender, FbEventArgs e)
        {
            m_Engine.PostChosenPhoto(e.PathToImage, e.StatusBody);
        }

        public override string GetName()
        {
            return "Post Photo";
        }
    }
}
