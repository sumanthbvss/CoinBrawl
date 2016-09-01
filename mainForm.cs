using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public static int fightTimes = 0;
        public bool autoBattle;
        public CookieContainer cookie;
        private Thread battleThread;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.autoBattle = false;
            updateMainForm();
        }

        private void updateMainForm()
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            Player.updatePlayer((SourceParser.PlayerStateInfo(client.DownloadString(CoinBrawl.CHARACTER))));           
            loadStateInfo(Player.getPlayer());
        }

        private void loadStateInfo(Player player)
        {
            //Label
            levelValue.Text = player.getLevel();
            atkValue.Text = player.getAttack();
            defValue.Text = player.getDefense();
            staminaValue.Text = player.getStamina();
            tokensValue.Text = player.getTokens();
            goldValue.Text = player.getGold();
            satoshiValue.Text = player.getSatoshi();
            bitconAddressTextBox.Text = player.getBitCoinAddress();

            //Button
            stamina_btn.Enabled = player.canUpgradeStamina();
            stamina_btn.Text = Player.UPGRADE + player.upgradeStaminaGold() + Player.GOLD;
            tokens_btn.Enabled = player.canUpgradeTokens();
            tokens_btn.Text = Player.UPGRADE + player.upgradeTokensGold() + Player.GOLD;
            atk_btn.Enabled = player.canUpgradeAttack();
            atk_btn.Text = Player.UPGRADE + player.upgradeAttackGold() + Player.GOLD;
            def_btn.Enabled = player.canUpgradeDefense();
            def_btn.Text = Player.UPGRADE + player.upgradeDefenseGold() + Player.GOLD;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            this.Close();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.autoBattle = true;
            battleThread = new Thread(new ThreadStart(persistantBattle));
            battleThread.Start();
        }

        private void persistantBattle()
        {
            while (autoBattle)
            {
                CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
                List<String> enemyList = SourceParser.BattleInfo(client.DownloadString(CoinBrawl.ARENA));
                String postData = String.Format("battle%5Bdefender_id%5D={0}&token={1}", enemyList[1], enemyList[0]);
                CookieAwareWebClient battle = new CookieAwareWebClient(this.cookie);
                battle.Method = CookieAwareWebClient.POST;
                battle.clickFight = true;
                battle.CSRF_Token = SourceParser.ParseCSRFToken(client.DownloadString(CoinBrawl.ARENA));

                String respones = battle.UploadString(CoinBrawl.BATTELS, postData);
                fightTimes++;

                //updateMainForm();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            updateMainForm();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            this.autoBattle = false;
            battleThread.Join();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = Player.getPlayer();
            player.setBitCoinAddress(bitconAddressTextBox.Text);
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            String postData = String.Format("utf8={0}&_method={1}&authenticity_token={2}&user%5Bbitcoin_address%5D={3}&commit={4}",
                CoinBrawl.UTF8, CoinBrawl.METHOD_PATCH, player.getAuthenticityToken(), player.getBitCoinAddress(), CoinBrawl.COMMIT_SAVE);
            client.Method = "POST";
            client.clickSave = true;
            String response = client.UploadString(CoinBrawl.USER + player.getUserID(), postData);
        }

        private void atk_btn_Click(object sender, EventArgs e)
        {                      
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);            
            client.Method = "GET";
            client.clickSave = true;
            client.DownloadString(CoinBrawl.UPGRADE_ATTACK);
            updateMainForm();
        }

        private void def_btn_Click(object sender, EventArgs e)
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            client.Method = "GET";
            client.clickSave = true;
            client.DownloadString(CoinBrawl.UPGRADE_DEFENSE);
            updateMainForm();
        }

        private void stamina_btn_Click(object sender, EventArgs e)
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            client.Method = "GET";
            client.clickSave = true;
            client.DownloadString(CoinBrawl.UPGRADE_STAMINA);
            updateMainForm();
        }

        private void tokens_btn_Click(object sender, EventArgs e)
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            client.Method = "GET";
            client.clickSave = true;
            client.DownloadString(CoinBrawl.UPGRADE_TOKENS);
            updateMainForm();
        }
    }
}
