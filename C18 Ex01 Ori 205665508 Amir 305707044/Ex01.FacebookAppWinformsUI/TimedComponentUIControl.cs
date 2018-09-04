using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    /////// base - interface ( component)


    public interface ICreateUIControl
    {
        bool invoked { get;}
        void Start();
        Control createUIControl();
        Control update();
    }


    /////the real-subject the ui control (concreteComponent)
    public class timedComponentUIController : ICreateUIControl
    {
        private Label res = new Label();
        private TimedComponent m_TimedComponent;

        public timedComponentUIController(TimedComponent i_component)
        {
            m_TimedComponent = i_component;
        }


        public void Start()
        {
            m_TimedComponent.Timer.Start();
        }

        public Control createUIControl()
        { 
            res.AutoSize = true;
            res.Text = m_TimedComponent.ToString();
            return res;
        }
        public bool invoked
        {
            get
            {
                return m_TimedComponent.Invoked;
            }
        }
        public Control update()
        {
            if(invoked)
            {
                res.Invoke(new Action(() => { res.Text = m_TimedComponent.ToString(); }));
            }
            return res;
        }
    }

    ////the decorator abstract class  (decorator)

    public abstract class decoratorTimedComponentUIControl : ICreateUIControl
    {
        private ICreateUIControl m_Component;
        public decoratorTimedComponentUIControl(ICreateUIControl i_Component)
        {
            m_Component = i_Component;
        }
        public virtual void Start()
        {
            m_Component.Start();
        }
        public virtual Control createUIControl()
        {
            return m_Component.createUIControl();
        }
        public virtual bool invoked
        {
            get
            {
                return m_Component.invoked;
            }
        }
        public virtual Control update()
        {
           return m_Component.update();
        }
    }


    //// the checkBox decoration (concrete decorator)


    public class CheckBoxedTimedComponentUIControl : decoratorTimedComponentUIControl
    {
        private CheckBox m_wrapperFunctunality = new CheckBox();
        private Panel m_container = new Panel();

        


        public CheckBoxedTimedComponentUIControl(ICreateUIControl i_baseComponent) : base(i_baseComponent)
        {

        }

        public override Control createUIControl()
        {
            Control orgin = base.createUIControl();
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
        public override Control update()
        {
            if(invoked)
            {
                m_wrapperFunctunality.Invoke(new Action(() => { m_wrapperFunctunality.Checked = true; }));
            }
            return base.update();
        }

    }


}
