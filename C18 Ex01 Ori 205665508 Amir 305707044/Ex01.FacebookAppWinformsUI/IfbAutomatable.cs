using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public interface IfbAutomatable
    {
        FbEventArgs CollectData();

        eTasksType GetTaskType();
    }
}
