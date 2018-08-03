using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Ex01.FacebookAppLogic
{
    public class TimedComponent
    {
        public DateTime DateAndHour { get; set; }
        public Timer Timer { get; set; }
        public FbAction ActionObject { get; set; }
        public override string ToString()
        {
            Type type = ActionObject.GetType();
            string[] typeAsString = type.ToString().Split('.');

            return string.Format("task {0} at {1} s at {2}",typeAsString[typeAsString.Length-1], ((DateAndHour - DateTime.Now).TotalSeconds).ToString(),DateAndHour.ToString() );
        }
    }
}
