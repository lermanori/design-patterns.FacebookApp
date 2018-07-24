using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using System.Net;
using System.IO;

namespace Ex01.FacebookApp
{
    public partial class Form1 : Form
    {
        LoginResult m_loginResult;
        FacebookWrapper.ObjectModel.User m_currentUser;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();

        }
        private void login()
        {
            m_loginResult = FacebookService.Login("273882356720887", "email", "user_hometown", "user_birthday", "user_friends", "user_events");
            textBox1.Text = m_loginResult.AccessToken.ToString();
            m_currentUser = m_loginResult.LoggedInUser;
        }
        private void loadEvents()
        {

            //FacebookWrapper.ObjectModel.FacebookObjectCollection<FacebookWrapper.ObjectModel.Event> myEvents = m_currentUser.Events;
            try
            {

                foreach (FacebookWrapper.ObjectModel.Event eventush in m_currentUser.Events)
                {
                    listBox1.Items.Add(eventush);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://graph.facebook.com/v3.0/me?fields=events&access_token=EAAD5GDSVJPcBAE0wxuB2MrP8XUUnUlpXhrxdHGmzMvYkbP5n2VZBSfdXIErSN7ZAP8QhJn0lnRZBWvdR6r90TbvKQdX6OF9U9XDyXA2nhA0SdZAWuw48ievDAqZCUhAs3XwZA55INVkEvt6VqOeqYvpyzEcjz070oddpRfyhFj8AiaSSZCsL7VoBN59eefl5A4ZD");

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            MessageBox.Show(responseString);
        }
    }
}
