/*
 https://www.coinbrawl.com/
 Automation Arena combat
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.TextLength == 0 || userPassword.TextLength == 0)
            {
                MessageBox.Show("Must input user account/password");
                return;
            }
            
            var cookieJar = new CookieContainer();
            CookieAwareWebClient client = new CookieAwareWebClient(cookieJar);
            System.Net.ServicePointManager.Expect100Continue = false;
            client.Method = CookieAwareWebClient.POST;

            String response = String.Empty;
            String token = SourceParser.parseAuthenticationToken(client.DownloadString(CoinBrawl.SIGN_IN));
            String postData = String.Format("utf8=%E2%9C%93&authenticity_token={0}&user%5Bemail%5D={1}&user%5Bpassword%5D={2}&commit=Sign+in", token, userName.Text, userPassword.Text);
            try
            {
                 response = client.UploadString(CoinBrawl.SIGN_IN, postData);
            }
            catch(WebException ex)
            {
                MessageBox.Show("A ntework error occurred\nPlease try again later or reopen the program");                
            }

            if (response.Contains(CoinBrawl.LOGIN_SUCCESS))
            {
                MessageBox.Show("Login successfully");
                mainForm mForm = new mainForm();
                mForm.cookie = client.CookieContainer;
                this.Visible = false;
                mForm.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid email or passowrd");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Extensible
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //CoinBrawl Logo
        }
    }
}
