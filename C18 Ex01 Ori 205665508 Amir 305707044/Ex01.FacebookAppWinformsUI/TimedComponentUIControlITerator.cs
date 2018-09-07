using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    class TimedComponentUIControlNotInvokedITerator : IEnumerator
    {
        private TimedComponentUIControlNotInvokedCollection m_Collection;
        private int m_CurrentIdx = -1;
       
        public TimedComponentUIControlNotInvokedITerator(TimedComponentUIControlNotInvokedCollection i_collection)
        {
            m_Collection = i_collection;
        }

        public object Current
        {
            get
            {
                return m_Collection.m_Components[m_CurrentIdx];
            }
        }

        public bool MoveNext()
        {
            ++m_CurrentIdx;
            bool valid = m_CurrentIdx < m_Collection.Count;
            if (valid && (m_Collection.m_Components[m_CurrentIdx] as ICreateTimedComponentUIControl).Invoked)
            {
                ++m_CurrentIdx;
            }
            return m_CurrentIdx < m_Collection.Count;
        }

        public void Reset()
        {
            m_CurrentIdx = 0;
        }
    }
}
