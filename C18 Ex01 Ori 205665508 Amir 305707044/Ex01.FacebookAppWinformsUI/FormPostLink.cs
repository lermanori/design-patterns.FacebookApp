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
    public partial class FormPostLink : Form ,IfbAutomatable,IProxyForm
    {
        public const string k_EnterTitleMsg = "Enter Title";
        public const string k_httpOpening = @"http://www.";
        private readonly string r_EnterValidURLMessage = "Insert a valid http format url." + Environment.NewLine + @"example:http://www.google.com";

        public string LinkUrl { get; set; }
        public DateTime TimeToExecute { get; set; }
        public string StatusBody { get; set; }

        private FacebookAppSettings m_FacebookSettings = FacebookAppSettings.LoadFromFile(); 


        public FormPostLink()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            TimeToExecute = dateTimePickerPost.Value;
            StatusBody = textBoxTitle.Text;
            LinkUrl = webBrowser.Url.ToString();
            buttonSubmit.Enabled = false;
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }
        private void comboBoxWebBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            changeURL(comboBox);
        }

        private void changeURL(ComboBox i_ComboBox)
        {
            if (!string.IsNullOrEmpty(i_ComboBox.SelectedItem as string))
            {
                webBrowser.Url = new System.Uri(i_ComboBox.SelectedItem as string);
            }
        }
        private void submitUserUrlChoice()
        {
            string urlToShow = comboBoxWebBrowser.Text;

            Uri uriResult;
            bool result = FacebookAppLogic.FacebookAppEngine.CreateURL(urlToShow, out uriResult);

            if (result)
            {
                webBrowser.Url = uriResult;
                comboBoxWebBrowser.Text = uriResult.ToString();
                comboBoxWebBrowser.Items.Add(comboBoxWebBrowser.Text);
                buttonSubmit.Enabled = true;
            }
            else
            {
                MessageBox.Show(r_EnterValidURLMessage);
                comboBoxWebBrowser.Text = k_httpOpening;
            }
        }
        private void comboBoxWebBrowser_Click(object sender, EventArgs e)
        {
            comboBoxWebBrowser.Text = k_httpOpening;
        }

        private void buttonSubmitUrl_onClick(object sender, EventArgs e)
        {
            submitUserUrlChoice();
        }

        private void FormPostLink_Load(object sender, EventArgs e)
        {
            addLinksToComboBoxFromFile();
        }

        private void addLinksToComboBoxFromFile()
        {
            if (m_FacebookSettings.ComboBoxWebBrowserItems.Count != 0)
            {
                foreach (string s in m_FacebookSettings.ComboBoxWebBrowserItems)
                {
                    if (!comboBoxWebBrowser.Items.Contains(s))
                    {
                        comboBoxWebBrowser.Items.Add(s);
                    }
                }
            }
        }

        public FbEventArgs collectData()
        {
            FbEventArgs result = new FbEventArgs { StatusBody = StatusBody, time = TimeToExecute, link = LinkUrl };
            return result;
        }
        public TasksType getTaskType()
        {
            return TasksType.link;
        }

    }

}
