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

        public FbEventArgs FbEventArgs { get; set; }

        public Timer Timer { get; set; }

        public FbAction ActionObject { get; set; }


        public static TimedComponent Create(FbEventArgs i_Args, FacebookAppEngine i_Engine, TasksType i_ChosenTask)
        {
            //need to switch fbactionpost.create to factory wholl get an enum

            TimedComponent timedComponent = new TimedComponent { FbEventArgs = i_Args, ActionObject = FbActionFactory.Create(i_Engine, i_ChosenTask), Timer = new System.Timers.Timer() ,Invoked = false};

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

        private void on_elapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            if (!Invoked)
            {
                Invoked = true;
                ActionObject.raiseEvent(FbEventArgs);
                Timer.Enabled = false;
                Timer.Elapsed -= on_elapsed;
            }
        }

        public override string ToString()
        {
            string ActionName = ActionObject.GetName();
            string timeToPresent = FbEventArgs.time - DateTime.Now > TimeSpan.Zero ? (FbEventArgs.time - DateTime.Now).TotalSeconds.ToString() : "this moment";
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
