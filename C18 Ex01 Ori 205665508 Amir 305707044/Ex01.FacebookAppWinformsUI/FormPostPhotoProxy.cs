using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    class FormPostPhotoProxy : IProxyForm , IfbAutomatable
    {
        private FormPostPhoto m_FormPostPhoto = null;

        private FormPostPhotoProxy() { }

        private void initializeIfNull()
        {
            if (m_FormPostPhoto == null)
            {
                m_FormPostPhoto = new FormPostPhoto();
            }
        }


        public DialogResult ShowDialog()
        {
            if(m_FormPostPhoto == null)
            {
                m_FormPostPhoto = new FormPostPhoto();
            }
            return m_FormPostPhoto.ShowDialog();
        }
        public override string ToString()
        {
            return "Post Photo";
        }

        public FbEventArgs collectData()
        {
            initializeIfNull();
            return m_FormPostPhoto.collectData();
        }

        public TasksType GetTaskType()
        {
            initializeIfNull();
            return m_FormPostPhoto.GetTaskType();
        }


        internal static IProxyForm Create()
        {
            return new FormPostPhotoProxy();
        }
    }
}
