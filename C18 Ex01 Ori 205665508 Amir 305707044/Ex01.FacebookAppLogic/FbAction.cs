﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public abstract class FbAction
    {
        public abstract void loadAction(FbEventArgs e);
        public event EventHandler<FbEventArgs> doWhenFinished;

        public void raiseEvent(FbEventArgs e)
        {
            doWhenFinished?.Invoke(this, e);
        }
    }
}

