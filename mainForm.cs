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
            Player player = new Player(SourceParser.PlayerStateInfo(client.DownloadString(CoinBrawlPath.CHARACTER)));
            loadStateInfo(player);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void defbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
