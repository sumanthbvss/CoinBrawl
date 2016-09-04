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
        public bool autoBattle;
        public CookieContainer cookie;
        public const String NEW_LINE = "\n";
        private Thread battleThread;
        private Thread tokenThread;
        private delegate void BattleResultHandler(String text, Color color);
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.autoBattle = false;
            updateMainForm();
            loadStateInfo();
        }

        private delegate void UpdateBattleInfo(String value);

        private void updateMainForm()
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            Player.updatePlayer((SourceParser.PlayerStateInfo(client.DownloadString(CoinBrawl.CHARACTER))));                       
        }

        private void loadStateInfo()
        {
            //Label
            Player player = Player.getPlayer();
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

            tokenThread = new Thread(new ThreadStart(checkToken));
            tokenThread.Start();
        }

        private void checkToken()
        {
            while(autoBattle)
            {
            updateMainForm();
            if(SourceParser.ParseAvailableTokens(Player.getPlayer().getTokens()).Equals(Player.EMPTY))
                autoBattle = false;
            }
            tokenThread.Join();
        }

        private void persistantBattle()
        {
            String result = String.Empty;
            String points = String.Empty;
            CookieAwareWebClient initPoint = new CookieAwareWebClient(this.cookie);
            points = SourceParser.ParseArenaPoints(initPoint.DownloadString(CoinBrawl.ARENA_RANK));
            setBattleResultText("Your current Arena Points: " + points + NEW_LINE, Color.Black);
            while (autoBattle)
            {
                CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
                List<String> enemyList = SourceParser.BattleInfo(client.DownloadString(CoinBrawl.ARENA));
                String postData = String.Format("battle%5Bdefender_id%5D={0}&token={1}", enemyList[1], enemyList[0]);
                CookieAwareWebClient battle = new CookieAwareWebClient(this.cookie);
                battle.Method = CookieAwareWebClient.POST;
                battle.clickFight = true;
                battle.CSRF_Token = SourceParser.ParseCSRFToken(client.DownloadString(CoinBrawl.ARENA));
                battle.UploadString(CoinBrawl.BATTELS, postData);

                CookieAwareWebClient arenaClient = new CookieAwareWebClient(this.cookie);
                points = SourceParser.ParseArenaPoints(arenaClient.DownloadString(CoinBrawl.ARENA_RANK));
                if(points.Equals(SourceParser.ParseArenaPoints(arenaClient.DownloadString(CoinBrawl.ARENA_RANK))))
                {
                    result += CoinBrawl.LOSE_BATTLE + NEW_LINE;
                    setBattleResultText(result, Color.Red);
                }
                else
                {
                    result += CoinBrawl.WIN_BATTLE + NEW_LINE;
                    setBattleResultText(result, Color.Green);
                }
                //updateMainForm();
            }
            battleThread.Join();
        }

        private void setBattleResultText(String text, Color color)
        {
            if (this.battleResultBox.InvokeRequired)
            {
                BattleResultHandler brHandler = new BattleResultHandler(setBattleResultText);
                this.Invoke(brHandler, text, color);
            }
            else
            {
                this.battleResultBox.Text = text;
                this.battleResultBox.ForeColor = color;
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            updateMainForm();
            loadStateInfo();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            this.autoBattle = false;
            updateMainForm();
            loadStateInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = Player.getPlayer();
            player.setBitCoinAddress(bitconAddressTextBox.Text);
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);
            String postData = String.Format("utf8={0}&_method={1}&authenticity_token={2}&user%5Bbitcoin_address%5D={3}&commit={4}",
                CoinBrawl.UTF8, CoinBrawl.METHOD_PATCH, SourceParser.ParseCSRFToken(client.DownloadString(CoinBrawl.CHARACTER)), player.getBitCoinAddress(), CoinBrawl.COMMIT_SAVE);
            client.Method = CookieAwareWebClient.POST;
            client.clickSave = true;
            try
            {
                client.UploadString(CoinBrawl.USER + player.getUserID(), postData);
                MessageBox.Show("You have successfully updated your bitcoin address");
            }
            catch (WebException ex)
            {
                //
                MessageBox.Show("Fail to updat your bitcoin address");
                //
            }
            updateMainForm();
            loadStateInfo();
        }

        private void atk_btn_Click(object sender, EventArgs e)
        {                      
            CookieAwareWebClient client = new CookieAwareWebClient(this.cookie);            
            client.Method = "GET";
            client.clickSave = true;
            client.DownloadString(CoinBrawl.UPGRADE_ATTACK);
            updateMainForm();
            loadStateInfo();
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
