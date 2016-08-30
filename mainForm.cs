using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public CookieContainer cookie;  
        public String mainPage;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            updateMainForm();
        }

        private void updateMainForm()
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            List<String> playerInfo = SourceParser.PlayerStateInfo(client.DownloadString(CoinBrawlPath.CHARACTER));
            loadStateInfo(playerInfo);
        }

        private void loadStateInfo(List<String> info)
        {
            levelValue.Text = info[0];
            atkValue.Text = info[1];
            defValue.Text = info[2];
            staminaValue.Text = info[3];
            tokensValue.Text = info[4];
            goldValue.Text = info[5];
            satoshiValue.Text = info[6];
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
