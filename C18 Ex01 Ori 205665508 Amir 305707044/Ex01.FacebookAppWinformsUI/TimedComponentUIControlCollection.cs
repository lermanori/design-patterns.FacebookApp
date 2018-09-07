using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public class TimedComponentUIControlCollection : IEnumerable
    {
        public readonly List<IControl> m_Components;

        public int Count { get; private set; }

        public TimedComponentUIControlCollection()
        {
            m_Components = new List<IControl>();
            Count = m_Components.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return new TimedComponentUIControlIterator(this);
        }

        public void Add(IControl i_InsertedElement)
        {
            m_Components.Add(i_InsertedElement);
            Count = m_Components.Count;
        }

        public void Remove(IControl i_RemovedElement)
        {
            m_Components.Remove(i_RemovedElement);
            Count = m_Components.Count;
        }
    }
}
