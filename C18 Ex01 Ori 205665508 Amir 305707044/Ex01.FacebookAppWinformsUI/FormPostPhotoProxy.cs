using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    class FormPostPhotoProxy : IProxyForm
    {
        private FormPostPhoto m_FormPostPhoto = null;

        private FormPostPhotoProxy() { }

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

        internal static IProxyForm Create()
        {
            return new FormPostPhotoProxy();
        }
    }
}
