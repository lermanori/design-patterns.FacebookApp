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
        bool Invoked { get;}
        void Start();
        Control CreateUIControl();
        Control Update();
    }


    /////the real-subject the ui control (concreteComponent)
    public class TimedComponentUIController : ICreateUIControl
    {
        private Label m_resultControl = new Label();
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
            m_resultControl.AutoSize = true;
            m_resultControl.Text = m_TimedComponent.ToString();
            return m_resultControl;
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
                m_resultControl.Invoke(new Action(() => { m_resultControl.Text = m_TimedComponent.ToString(); }));
            }
            return m_resultControl;
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
    }


    //// the checkBox decoration (concrete decorator)


    public class CheckBoxedTimedComponentUIControl : decoratorTimedComponentUIControl
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
            if(Invoked)
            {
                m_wrapperFunctunality.Invoke(new Action(() => { m_wrapperFunctunality.Checked = true; }));
            }
            return base.Update();
        }

    }


}
