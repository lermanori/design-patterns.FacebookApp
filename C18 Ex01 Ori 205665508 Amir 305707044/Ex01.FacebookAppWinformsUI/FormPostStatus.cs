using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ex01.FacebookAppLogic;

namespace Ex01.FacebookAppWinformsUI
{
    public partial class FormPostStatus : Form , IfbAutomatable
    {
        public string StatusBody { get; set; }

        public DateTime TimeToExecute { get; set; }

        public FormPostStatus()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.TimeToExecute = dateTimePickerPost.Value;
            this.StatusBody = textBoxPost.Text;
            this.DialogResult = DialogResult.OK;
            
            this.Close();
        }
        public FbEventArgs collectData()
        {
            FbEventArgs result = new FbEventArgs { StatusBody=StatusBody, time = TimeToExecute };
            return result;
        }
        public TasksType getTaskType()
        {
            return TasksType.status;
        }
        
    }
}