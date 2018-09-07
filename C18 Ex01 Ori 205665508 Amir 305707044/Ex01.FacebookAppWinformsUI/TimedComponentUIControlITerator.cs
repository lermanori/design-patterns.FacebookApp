using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public class TimedComponentUIControlIterator : IEnumerator
    {
        private TimedComponentUIControlCollection m_UIControlsCollection;
        private int m_CurrentIndex = -1;
       
        public TimedComponentUIControlIterator(TimedComponentUIControlCollection i_Collection)
        {
            m_UIControlsCollection = i_Collection;
        }

        public object Current
        {
            get
            {
                return m_UIControlsCollection.m_Components[m_CurrentIndex];
            }
        }

        public bool MoveNext()
        {
            ++m_CurrentIndex;
            bool valid = m_CurrentIndex < m_UIControlsCollection.Count;
            if (valid && (m_UIControlsCollection.m_Components[m_CurrentIndex] as IControl).Invoked)
            {
                ++m_CurrentIndex;
            }

            return m_CurrentIndex < m_UIControlsCollection.Count;
        }

        public void Reset()
        {
            m_CurrentIndex = 0;
        }
    }
}
