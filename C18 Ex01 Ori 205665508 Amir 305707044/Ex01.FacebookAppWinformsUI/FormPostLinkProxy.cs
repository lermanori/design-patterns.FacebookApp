﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    class FormPostLinkProxy : IProxyForm , IfbAutomatable
    {
        private FormPostLink m_FormPostLink = null;

        private FormPostLinkProxy() { }

        private void initializeIfNull()
        {
            if (m_FormPostLink == null)
            {
                m_FormPostLink = new FormPostLink();
            }
        }

        public DialogResult ShowDialog()
        {
            initializeIfNull();
            return m_FormPostLink.ShowDialog();
        }

        public FbEventArgs collectData()
        {
            initializeIfNull();
            return m_FormPostLink.collectData();
        }

        public TasksType GetTaskType()
        {
            initializeIfNull();
            return m_FormPostLink.GetTaskType();
        }

        public override string ToString()
        {
            return "Post Link";
        }

        internal static IProxyForm Create()
        {
            return new FormPostLinkProxy();
        }

        
    }
}