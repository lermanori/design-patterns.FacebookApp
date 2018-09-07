using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public abstract class DecoratorTimedComponentUIControl : IControl
    {
        private IControl m_Component;

        public DecoratorTimedComponentUIControl(IControl i_Component)
        {
            m_Component = i_Component;
        }

        public virtual void Start()
        {
            m_Component.Start();
        }

        public virtual Control CreateUIControl()
        {
            return m_Component.CreateUIControl();
        }

        public virtual bool Invoked
        {
            get
            {
                return m_Component.Invoked;
            }
        }

        public virtual Control Update()
        {
            return m_Component.Update();
        }

        public void InvokeNow()
        {
            m_Component.InvokeNow();
        }
    }
}
