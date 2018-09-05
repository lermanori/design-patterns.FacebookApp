using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public class FormPostLinkProxy : IProxyForm, IfbAutomatable
    {
        private FormPostLink m_FormPostLink = null;
        private object m_PostLinkLock = new object();

        private FormPostLinkProxy()
        {
        }

        private void initializeIfNull()
        {
            if (m_FormPostLink == null)
            {
                lock (m_PostLinkLock)
                {
                    if (m_FormPostLink == null)
                    {
                        m_FormPostLink = new FormPostLink();
                    }
                }
            }
        }

        public DialogResult ShowDialog()
        {
            initializeIfNull();
            return m_FormPostLink.ShowDialog();
        }

        public FbEventArgs CollectData()
        {
            initializeIfNull();
            return m_FormPostLink.CollectData();
        }

        public eTasksType GetTaskType()
        {
            initializeIfNull();
            return m_FormPostLink.GetTaskType();
        }

        public override string ToString()
        {
            return "Post Link";
        }

        internal static FormPostLinkProxy Create()
        {
            return new FormPostLinkProxy();
        }
    }
}
