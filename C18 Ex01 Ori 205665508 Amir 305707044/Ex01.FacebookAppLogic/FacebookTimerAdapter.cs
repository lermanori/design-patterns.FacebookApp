using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookAppLogic
{
    public class FacebookTimerAdapter
    {
        private bool m_ProcessOnlyOnce = false;

        public TimedComponent Timed { get; set; }

        public FbEventArgs Args { get; set; }

        public FacebookTimerAdapter(TimedComponent i_timedComponent)
        {
            Timed = i_timedComponent;
        }

        public void on_elapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            if (!m_ProcessOnlyOnce)
            {
                m_ProcessOnlyOnce = true;
                Timed.ActionObject.raiseEvent(Args);
                Timed.Timer.Enabled = false;
                Timed.Timer.Elapsed -= on_elapsed;
            }
        }
    }
}
