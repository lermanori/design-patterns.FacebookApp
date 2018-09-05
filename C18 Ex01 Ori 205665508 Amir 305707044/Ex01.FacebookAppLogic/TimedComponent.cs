using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Ex01.FacebookAppLogic
{
    public class TimedComponent
    {
        public bool Invoked { get; private set; }

        private readonly object r_TimedComponentLock = new object();

        public FbEventArgs FbEventArgs { get; set; }

        public Timer Timer { get; set; }

        public FbAction ActionObject { get; set; }

        public static TimedComponent Create(FbEventArgs i_Args, FacebookAppEngine i_Engine, eTasksType i_ChosenTask)
        {
            TimedComponent timedComponent = new TimedComponent { FbEventArgs = i_Args, ActionObject = FbActionFactory.Create(i_Engine, i_ChosenTask), Timer = new System.Timers.Timer(), Invoked = false };

            timedComponent.ActionObject.LoadAction();

            timedComponent.Timer.Enabled = false;
            timedComponent.Timer.Elapsed += new System.Timers.ElapsedEventHandler(timedComponent.OnElapsed);

            if ((timedComponent.FbEventArgs.Time - DateTime.Now).TotalMilliseconds > 0)
            {
                timedComponent.Timer.Interval = (timedComponent.FbEventArgs.Time - DateTime.Now).TotalMilliseconds;
            }
            else
            {
                // if the time already passed, we commit the action immediately
                timedComponent.Timer.Interval = 0.1;
            }

            return timedComponent;
        }

        private void OnElapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            if (!Invoked)
            {
                lock (r_TimedComponentLock)
                {
                    if (!Invoked)
                    {
                        Invoked = true;
                        try
                        {
                            ActionObject.RaiseEvent(FbEventArgs);
                        }
                        catch
                        {
                            ActionObject.RaiseErrorEvent();
                        }

                        Timer.Enabled = false;
                        Timer.Elapsed -= OnElapsed;
                    }
                }
            }
        }

        public override string ToString()
        {
            string ActionName = ActionObject.GetName();
            string timeToPresent = FbEventArgs.Time - DateTime.Now > TimeSpan.Zero ? (FbEventArgs.Time - DateTime.Now).TotalSeconds.ToString() : "this moment";
            if (!Invoked)
            {
                return string.Format("Task {0} at {1} seconds to be procesed", ActionName, timeToPresent);
            }
            else
            {
                return string.Format("Task {0} at {1} has beed completed", ActionName, timeToPresent);
            }
        }
    }
}
