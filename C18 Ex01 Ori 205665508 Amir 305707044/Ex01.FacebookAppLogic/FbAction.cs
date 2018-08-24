using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public abstract class FbAction
    {
        protected FacebookAppEngine m_Engine;

        public abstract void LoadAction();

        public event EventHandler<FbEventArgs> DoWhenFinished;
        public event EventHandler DoWhenFinishedError;

        public void raiseEvent(FbEventArgs e)
        {
            DoWhenFinished?.Invoke(this, e);
        }
        public void raiseErrorEvent()
        {
            DoWhenFinishedError?.Invoke(this,new EventArgs());
        }
        public abstract string GetName();

        
    }
}