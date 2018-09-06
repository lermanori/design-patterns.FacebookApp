using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;
using System.Collections;

namespace Ex01.FacebookAppWinformsUI
{

    public class TimedComponentUIController : ICreateTimedComponentUIControl
    {
        private bool m_updateOnce = false;

        private Label m_ResultControl = new Label();

        private TimedComponent m_TimedComponent;

        public TimedComponentUIController(TimedComponent i_component)
        {
            m_TimedComponent = i_component;
        }

        public void Start()
        {
            m_TimedComponent.Timer.Start();
        }

        public Control CreateUIControl()
        {
            m_ResultControl.AutoSize = true;
            m_ResultControl.Text = m_TimedComponent.ToString();
            return m_ResultControl;
        }

        public bool Invoked
        {
            get
            {
                return m_TimedComponent.Invoked;
            }
        }

        public Control Update()
        {
            if (!m_updateOnce)
            {
                m_updateOnce = true;
                if (Invoked)
                {
                    m_ResultControl.Invoke(new Action(() => { m_ResultControl.Text = m_TimedComponent.ToString(); }));
                }
            }
            return m_ResultControl;
        }

        public void InvokeNow()
        {
            m_TimedComponent.InvokeNow();
        }
    }
}
