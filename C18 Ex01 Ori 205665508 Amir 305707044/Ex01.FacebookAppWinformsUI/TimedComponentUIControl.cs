using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public class TimedComponentUIControl : IControl
    {
        private bool m_UpdateOnce = false;

        private Label m_ResultLabel = new Label();

        private TimedComponent m_TimedComponent;

        public TimedComponentUIControl(TimedComponent i_Component)
        {
            m_TimedComponent = i_Component;
        }

        public void Start()
        {
            m_TimedComponent.Timer.Start();
        }

        public Control CreateUIControl()
        {
            m_ResultLabel.AutoSize = true;
            m_ResultLabel.Text = m_TimedComponent.ToString();
            return m_ResultLabel;
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
            if (!m_UpdateOnce)
            {
                m_UpdateOnce = true;
                if (Invoked)
                {
                    m_ResultLabel.Invoke(new Action(() => { m_ResultLabel.Text = m_TimedComponent.ToString(); }));
                }
            }

            return m_ResultLabel;
        }

        public void InvokeNow()
        {
            m_TimedComponent.InvokeNow();
        }
    }
}
