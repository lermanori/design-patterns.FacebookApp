using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    class FormPostLinkProxy : IProxy
    {
        private FormPostLink m_FormPostLink = null;

        private FormPostLinkProxy() { }

        public DialogResult ShowDialog()
        {
            if (m_FormPostLink==null)
            {
                m_FormPostLink = new FormPostLink();
            }
            return m_FormPostLink.ShowDialog();
        }
        public override string ToString()
        {
            return "Post Link";
        }

        internal static IProxy Create()
        {
            return new FormPostLinkProxy();
        }
    }
}
