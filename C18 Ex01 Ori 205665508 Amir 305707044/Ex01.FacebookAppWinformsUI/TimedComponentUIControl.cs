using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{

    public class TimedComponentUIController : ICreateUIControl
    {

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
            if(Invoked)
            {
                m_ResultControl.Invoke(new Action(() => { m_ResultControl.Text = m_TimedComponent.ToString(); }));
            }
            return m_ResultControl;
        }
    }
}
