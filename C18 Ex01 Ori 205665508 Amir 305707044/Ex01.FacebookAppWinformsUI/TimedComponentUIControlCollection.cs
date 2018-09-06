using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    class TimedComponentUIControlNotInvokedCollection : IEnumerable
    {
        public readonly List<ICreateTimedComponentUIControl> m_Components;

        public int Count { get; private set; }

        public TimedComponentUIControlNotInvokedCollection()
        {
            m_Components = new List<ICreateTimedComponentUIControl>();
            Count = m_Components.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return new TimedComponentUIControlNotInvokedITerator(this);
        }

        public void Add(ICreateTimedComponentUIControl i_insertedElement)
        {
            m_Components.Add(i_insertedElement);
            Count = m_Components.Count;
        }

        public void remove(ICreateTimedComponentUIControl i_removedElement)
        {
            m_Components.Remove(i_removedElement);
            Count = m_Components.Count;
        }

    }
}
