using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public class CheckBoxedTimedComponentUIControl : DecoratorTimedComponentUIControl
    {
        private CheckBox m_wrapperFunctunality = new CheckBox();

        private Panel m_container = new Panel();

        public CheckBoxedTimedComponentUIControl(ICreateUIControl i_baseComponent) : base(i_baseComponent)
        {

        }

        public override Control CreateUIControl()
        {
            Control orgin = base.CreateUIControl();
            orgin.Left = 20;
            m_wrapperFunctunality.Top = orgin.Top;
            m_wrapperFunctunality.Enabled = false;
            m_wrapperFunctunality.Checked = false;
            m_container.AutoSize = true;
            m_container.MaximumSize = new System.Drawing.Size(1000, 200);
            m_container.Size = new System.Drawing.Size(800, 200);
            m_container.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            m_container.BorderStyle = BorderStyle.FixedSingle;
            m_container.Controls.Add(orgin);
            m_container.Controls.Add(m_wrapperFunctunality);
            return m_container;
        }

        public override Control Update()
        {
            if (Invoked)
            {
                m_wrapperFunctunality.Invoke(new Action(() => { m_wrapperFunctunality.Checked = true; }));
            }
            return base.Update();
        }
    }
}
