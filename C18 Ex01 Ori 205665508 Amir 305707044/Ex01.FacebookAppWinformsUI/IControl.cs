using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public interface IControl
    {
        bool Invoked { get; }

        void Start();

        Control CreateUIControl();

        Control Update();

        void InvokeNow();
    }
}
