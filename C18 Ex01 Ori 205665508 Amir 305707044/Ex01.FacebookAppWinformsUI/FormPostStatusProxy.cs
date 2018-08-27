using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public class FormPostStatusProxy : IProxyForm, IfbAutomatable
    {
        private FormPostStatus m_formPostStatus = null;

        private FormPostStatusProxy()
        {
        }

        private void initializeIfNull()
        {
            if (m_formPostStatus == null)
            {
                m_formPostStatus = new FormPostStatus();
            }
        }

        public DialogResult ShowDialog()
        {
            initializeIfNull();
            return m_formPostStatus.ShowDialog();
        }

        internal static FormPostStatusProxy Create()
        {
            return new FormPostStatusProxy();
        }

        public FbEventArgs CollectData()
        {
            initializeIfNull();
            return m_formPostStatus.CollectData();
        }

        public eTasksType GetTaskType()
        {
            initializeIfNull();
            return m_formPostStatus.GetTaskType();
        }

        public override string ToString()
        {
            return "Post Status";
        }
    }
}
