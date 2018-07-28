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
using System.Net;

namespace Ex01.FacebookApp
{
    public partial class Form1 : Form
    {
        LoginResult m_loginResult;
        Action logout;
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
            pictureBox1.Image = m_currentUser.ImageNormal;
        }

        private void postStatus(string post)
        {
            m_currentUser.PostStatus(post);
        }
      
        //somethings wrong here
        public void on_logOut()
        {
            logout = on_logOut;
            FacebookService.Logout(logout);
            textBox1.Text = "";
            pictureBox1.Image = null;
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            on_logOut();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            postStatus(textBox2.Text);
            textBox2.Text = "";
        }
    }
}
