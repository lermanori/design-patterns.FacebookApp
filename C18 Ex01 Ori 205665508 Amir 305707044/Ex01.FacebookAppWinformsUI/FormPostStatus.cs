using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.FacebookAppWinformsUI
{
    public partial class FormPostStatus : Form
    {
        public string statusBody { get; set; }
        public DateTime timeToExecute { get; set; }

        public FormPostStatus()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.timeToExecute = dateTimePickerPost.Value;
            this.statusBody = textBoxPost.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

     
