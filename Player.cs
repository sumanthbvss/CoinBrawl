﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Player
    {
        static Player player = new Player();
        public static String UPGRADE = "Upgrade ";
        public static String GOLD_LABEL = " Gold";
        public static String DISABLED = "disabled";
        public static String EMPTY = "0";
        public static int PLAYER_INFO_SIZE = 14;
        public static int LEVEL = 1;
        public static int ATTACK = 2;
        public static int DEFENSE = 3;
        public static int STAMINA = 4;
        public static int TOKENS = 5;
        public static int GOLDS = 6;
        public static int SATOSHI = 7;
        public static int UPGRADE_STAMINA_GOLD = 8;
        public static int UPGRADE_TOKENS_GOLD = 9;
        public static int UPGRADE_ATK_GOLD = 10;
        public static int UPGRADE_DEF_GOLD = 11;
        public static int BITCOIN_ADDR = 12;
        public static int USER_ID = 13;
        public static int ARENA_POINTS = 14;
        String level;
        String job;
        String gems;
        String stamina;
        String tokens;
        String attack;
        String defense;
        String gold;
        String satoshi;
        String arenaPoints;
        String safetyTime;
        String bitcoinAddress;        
        String userName;
        String userPassword;
        String userID;
        String authenticity_token;
        int staminaGold;
        int tokensGold;
        int attackGold;
        int defenseGold;
        bool upgradeStaminaFlag;
        bool upgradeTokensFlag;
        bool upgradeAttackFlag;
        bool upgradeDefenseFlag;
        bool regenerateStaminaFlag;
        bool regenerateTokensFlag;

        private Player() { }
        public static Player getPlayer()
        {
            if (player == null)
                player = new Player();
            return player;
        }

        public static void updatePlayer(List<String> info)
        {
            player.level = info[Player.LEVEL];
            player.attack = info[Player.ATTACK];
            player.defense = info[Player.DEFENSE];
            player.stamina = info[Player.STAMINA];
            player.tokens = info[Player.TOKENS];
            player.gold = info[Player.GOLDS];
            player.satoshi = info[Player.SATOSHI];
            player.staminaGold = Int32.Parse(info[Player.UPGRADE_STAMINA_GOLD]);
            player.tokensGold = Int32.Parse(info[Player.UPGRADE_TOKENS_GOLD]);
            player.attackGold = Int32.Parse(info[Player.UPGRADE_ATK_GOLD]);
            player.defenseGold = Int32.Parse(info[Player.UPGRADE_DEF_GOLD]);
            player.bitcoinAddress = info[Player.BITCOIN_ADDR];
            player.userID = info[Player.USER_ID];
            player.arenaPoints = info[Player.ARENA_POINTS];
        }

        //Setter
        public void setLevel(String level){ this.level = level;}
        public void setJob(String job) { this.job = job; }
        public void setGems(String gems) { this.gems = gems; }
        public void setStamina(String stamina) { this.stamina = stamina; }
        public void setTokens(String tokens) { this.tokens = tokens; }
        public void setAttack(String attack) { this.attack = attack; }
        public void setDefense(String defense) { this.defense = defense; }
        public void setGold(String gold) { this.gold = gold; }
        public void setSatoshi(String satoshi) { this.satoshi = satoshi; }
        public void setArenaPoints(String ap) { this.arenaPoints = ap; }
        public void setSafetyTime(String safeTime) { this.safetyTime = safeTime; }
        public void setBitCoinAddress(String address){this.bitcoinAddress = address;}
        public void setUpgradeStaminaGold(int gold) { this.staminaGold = gold; }
        public void setUpgradeTokensGold(int gold) { this.tokensGold = gold; }
        public void setUpgradeAttackGold(int gold) { this.attackGold = gold; }
        public void setUpgradeDefenseGold(int gold) { this.defenseGold = gold; }
        public void setUpgradeStamina(bool flag) { this.upgradeStaminaFlag = flag; }
        public void setUpgradeTokens(bool flag) { this.upgradeTokensFlag = flag; }
        public void setUpgradeAttack(bool flag) { this.upgradeAttackFlag = flag; }
        public void setUpgradeDefense(bool flag) { this.upgradeDefenseFlag = flag; }
        public void setUserID(String userID) { this.userID = userID; }
        public void setAuthenticityToken(String authToken) { this.authenticity_token = authToken; }

        //Getter
        public String getLevel() { return this.level; }
        public String getJob() { return this.job; }
        public String getGems() { return this.gems; }
        public String getStamina() { return this.stamina; }
        public String getTokens() { return this.tokens; }
        public String getAttack() { return this.attack; }
        public String getDefense() { return this.defense;}
        public String getGold() { return this.gold; }
        public String getSatoshi() { return this.satoshi; }
        public String getArenaPoints() { return this.arenaPoints; }
        public String getSafetytime() { return this.safetyTime; }
        public String getBitCoinAddress() { return this.bitcoinAddress; }
        public String getUserID() { return this.userID; }
        public String getAuthenticityToken(){ return this.authenticity_token;}
        public int upgradeStaminaGold() { return this.staminaGold; }
        public int upgradeTokensGold() { return this.tokensGold; }
        public int upgradeAttackGold() { return this.attackGold; }
        public int upgradeDefenseGold() { return this.defenseGold; }

        public bool canUpgradeStamina() 
        {
            if (this.staminaGold > Int64.Parse(this.gold))
                this.setUpgradeStamina(false);
            else
                this.setUpgradeStamina(true);
            return this.upgradeStaminaFlag; 
        }

        public bool canUpgradeTokens()
        {
            if (this.tokensGold > Int64.Parse(this.gold))
                this.setUpgradeTokens(false);
            else
                this.setUpgradeTokens(true);
            return this.upgradeTokensFlag; 
        }

        public bool canUpgradeAttack()
        {
            if (this.attackGold > Int64.Parse(this.gold))
                this.setUpgradeAttack(false);
            else
                this.setUpgradeAttack(true);
            return this.upgradeAttackFlag;
        }

        public bool canUpgradeDefense()
        {
            if (this.defenseGold > Int64.Parse(this.gold))
                this.setUpgradeDefense(false);
            else
                this.setUpgradeStamina(true);
            return this.upgradeDefenseFlag; 
        }

        public bool canBattle()
        {
            if(this.tokens.Equals("0"))
                return false;
            return true;
        }

    }
}
