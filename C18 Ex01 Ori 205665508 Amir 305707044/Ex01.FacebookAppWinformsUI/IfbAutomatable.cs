using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    interface IfbAutomatable
    {
        FbEventArgs collectData();
        TasksType getTaskType();
    }
}
