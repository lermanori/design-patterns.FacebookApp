using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public class CheckBoxedTimedComponentUIControl : DecoratorTimedComponentUIControl
    {
        private CheckBox m_WrapperCheckboxFunctionality = new CheckBox();
        private bool m_UpdateOnce = false;
        private Panel m_Container = new Panel();

        public CheckBoxedTimedComponentUIControl(IControl i_baseComponent) : base(i_baseComponent)
        {
        }

        public override Control CreateUIControl()
        {
            Control orgin = base.CreateUIControl();
            orgin.Left = 20;
            m_WrapperCheckboxFunctionality.Top = orgin.Top;
            m_WrapperCheckboxFunctionality.Enabled = false;
            m_WrapperCheckboxFunctionality.Checked = false;
            m_Container.AutoSize = true;
            m_Container.MaximumSize = new System.Drawing.Size(1000, 200);
            m_Container.Size = new System.Drawing.Size(800, 200);
            m_Container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            m_Container.BorderStyle = BorderStyle.FixedSingle;
            m_Container.Controls.Add(orgin);
            m_Container.Controls.Add(m_WrapperCheckboxFunctionality);
            return m_Container;
        }

        public override Control Update()
        {
            if (!m_UpdateOnce)
            {
                m_UpdateOnce = true;
                if (Invoked)
                {
                    m_WrapperCheckboxFunctionality.Invoke(new Action(() => { m_WrapperCheckboxFunctionality.Checked = true; }));
                }

                return base.Update();
            }
            else
            {
                return m_Container;
            }
        }
    }
}
