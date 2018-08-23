using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    class FormPostStatusProxy : IProxyForm
    {
       private FormPostStatus m_formPostStatus = null;

        private FormPostStatusProxy() { }

        public DialogResult ShowDialog()
        {
            if(m_formPostStatus == null)
            {
                m_formPostStatus = new FormPostStatus();
            }

            return m_formPostStatus.ShowDialog();
        }

        internal static IProxyForm Create()
        {
            return new FormPostStatusProxy();
        }

        public override string ToString()
        {
            return "Post Status";
        }
    }
}
