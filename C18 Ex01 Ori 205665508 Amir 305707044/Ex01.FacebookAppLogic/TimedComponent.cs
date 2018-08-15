using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Ex01.FacebookAppLogic
{
    public class TimedComponent
    {
        private bool m_ProcessOnlyOnce;

        public FbEventArgs FbEventArgs { get; set; }

        public Timer Timer { get; set; }

        public FbAction ActionObject { get; set; }

        public static TimedComponent create(FbEventArgs i_Args,FacebookAppEngine i_Engine)
        {
            TimedComponent timedComponent = new TimedComponent { FbEventArgs = i_Args, ActionObject = FbActionPost.Create(i_Engine), Timer = new System.Timers.Timer() };

            timedComponent.ActionObject.LoadAction();

            timedComponent.Timer.Enabled = false;
            timedComponent.Timer.Elapsed += new System.Timers.ElapsedEventHandler(timedComponent.on_elapsed);

            if ((timedComponent.FbEventArgs.time - DateTime.Now).TotalMilliseconds > 0)
            {
                timedComponent.Timer.Interval = (timedComponent.FbEventArgs.time - DateTime.Now).TotalMilliseconds;
            }
            else
            {
                timedComponent.Timer.Interval = 1000 * 5;//if the time already passed the user wants it instantaniasly so well post it in 5 seconds
            }
            return timedComponent; 

    }

        public void on_elapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            if (!m_ProcessOnlyOnce)
            {
                m_ProcessOnlyOnce = true;
                ActionObject.raiseEvent(FbEventArgs);
                Timer.Enabled = false;
                Timer.Elapsed -= on_elapsed;
            }
        }

        public override string ToString()
        {
            string ActionName = ActionObject.GetName();

            return string.Format("Task {0} at {1}",ActionName, (FbEventArgs.time - DateTime.Now).TotalSeconds.ToString());
        }
    }
}
