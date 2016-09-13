using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace WindowsFormsApplication1
{
    class SourceParser
    {
        private const String EMPTY = "";
        private const String GOLD_EXPENSE = "([0-9])+";
        private SourceParser() { }

        private static void ParallelParsingStateThread1(List<String> playerInfo, String sourceInfo)
        {
            playerInfo[Player.LEVEL] = SourceParser.ParseLevel(sourceInfo);
            playerInfo[Player.GOLDS] = SourceParser.ParseGold(sourceInfo);
            playerInfo[Player.ATTACK] = SourceParser.ParseAttack(sourceInfo);
            playerInfo[Player.DEFENSE] = SourceParser.ParseDefense(sourceInfo);
            playerInfo[Player.STAMINA] = SourceParser.ParseStamina(sourceInfo);
            playerInfo[Player.TOKENS] = SourceParser.ParseTokens(sourceInfo);
            playerInfo[Player.SATOSHI] = SourceParser.ParseSatoshi(sourceInfo);
        }

        private static void ParallelParsingStateThread2(List<String> playerInfo, String sourceInfo)
        {
            playerInfo[Player.UPGRADE_STAMINA_GOLD] = SourceParser.ParseUpdateStamina(sourceInfo);
            playerInfo[Player.UPGRADE_TOKENS_GOLD] = SourceParser.ParseUpdateTokens(sourceInfo);
            playerInfo[Player.UPGRADE_ATK_GOLD] = SourceParser.ParseUpdateATK(sourceInfo);
            playerInfo[Player.UPGRADE_DEF_GOLD] = SourceParser.ParseUpdateDEF(sourceInfo);
            playerInfo[Player.BITCOIN_ADDR] = SourceParser.ParseBitcoinAddress(sourceInfo);
            playerInfo[Player.USER_ID] = SourceParser.ParseUserID(sourceInfo);
        }

        public static String FilterBlanlAndNewLine(String sourceInfo)
        {
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY).Replace("\n", SourceParser.EMPTY);
            return sourceInfo;
        }

        public static String ParseUserID(String sourceInfo)
        {
            String pattern = "(http:\\/\\/www.coinbrawl.com\\?ref=)([0-9]*)";
            Match match = Regex.Match(sourceInfo, pattern);
            return match.Groups[2].Value;
        }
        public static String ParseAuthenticationToken(String htmlSourceStr)
        {
            if(htmlSourceStr.Length == 0)
                return SourceParser.EMPTY;
            String pattern = "<input name=\"authenticity_token\" type=\"hidden\" value=\"(.*)\"\\/>";
            Match match = Regex.Match(htmlSourceStr, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
                return SourceParser.EMPTY;
        }
        public static String ParseBitcoinAddress(String sourceInfo) 
        {
            String pattern = "(id=\"user_bitcoin_address\")(\\s)(name=\"user(.*)\")(\\s)(type=\"text\")(\\s)(value=\")([A-Za-z0-9]*)(?=\")";
            sourceInfo = sourceInfo.Replace("\n", SourceParser.EMPTY);
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY);
            Match match = Regex.Match(sourceInfo, pattern);
            return match.Groups[9].Value;
        }
        public static List<String> ParseArenaPlayer(String src)
        {
            List<String> arenaPlayer = new List<String>();
            return arenaPlayer;
        }
        public static String ParseCSRFToken(String sourceInfo)
        {
            String pattern = "(<meta content=\"authenticity_token\" name=\"csrf-param\"\\/><meta content=\")(.*)(\" name=\"csrf-token\"\\/>)";
            sourceInfo = sourceInfo.Replace("\n", SourceParser.EMPTY);
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY);
            Match match = Regex.Match(SourceParser.FilterBlanlAndNewLine(sourceInfo), pattern);
            return match.Groups[2].Value;
        }
        public static List<String> BattleInfo(String sourceInfo)
        {
            //List<List<String>> battleInfo = new List<List<String>>();
            sourceInfo = sourceInfo.Replace("\n", SourceParser.EMPTY);
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY);
            String battlePattern = "CoinBrawl.Battle(.*)CoinBrawl.NpcBattle";
            String end = @"battles(.*)(?=createBattlePath)";
            String allEnemyInfo = "(\"key\")(.*)(\"key\")(.*)(\"key\")(.*)(\"key\")(.*)(\"key\")(.*)";
            Match match = Regex.Match(Regex.Match(Regex.Match(sourceInfo, battlePattern).Groups[0].Value, end).Groups[0].Value, allEnemyInfo);

            String enemyStr = match.Groups[1].Value + match.Groups[2].Value;
            String enemyInfoPattern = "(\"key\":\")([A-Za-z0-9]*)(\",\"defender_id\":)([0-9]*)";
            match = Regex.Match(enemyStr, enemyInfoPattern);
            List<String> enemyList = new List<String>();
            enemyList.Add(match.Groups[2].Value);//Enemy key
            enemyList.Add(match.Groups[4].Value);//Enemy ID
            return enemyList;
        }
        public static List<String> PlayerStateInfo(String sourceInfo)
        {
            List<String> playerInfo = new List<String>();
            for (int i = 0; i < Player.PLAYER_INFO_SIZE; ++i)
                playerInfo.Add(Player.EMPTY);
            sourceInfo = sourceInfo.Replace("\n", SourceParser.EMPTY);
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY);
            String pattern = "<table class='table stats-table'>(.*)<\\/tbody><\\/table>";
            Match match = Regex.Match(sourceInfo, pattern);

            List<Thread> threads = new List<Thread>();
            threads.Add(new Thread(() => ParallelParsingStateThread1(playerInfo, sourceInfo)));
            threads.Add(new Thread(() => ParallelParsingStateThread2(playerInfo, sourceInfo)));
            threads[0].Start();
            threads[1].Start();
            foreach (Thread thread in threads)
                thread.Join();
            return playerInfo;
        }

        public static String ParseLevel(String src)
        {
            String pattern = "<td>Level<\\/td><td>([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Level</td><td>", SourceParser.EMPTY);
        }
        public static String ParseStamina(String src)
        {
            String pattern = "<td>Stamina<\\/td><td>([0-9])*\\/([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Stamina</td><td>", SourceParser.EMPTY);
        }
        public static String ParseTokens(String src)
        {
            String pattern = "<td>Tokens<\\/td><td>([0-9])*\\/([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Tokens</td><td>", SourceParser.EMPTY);
        }
        public static String ParseAttack(String src)
        {
            String pattern = "<td>Attack<\\/td><td><span>([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Attack</td><td><span>", SourceParser.EMPTY);
        }
        public static String ParseDefense(String src)
        {
            String pattern = "<td>Defense<\\/td><td><span>([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Defense</td><td><span>", SourceParser.EMPTY);
        }
        public static String ParseGold(String src)
        {
            String pattern = "<td>Gold<\\/td><td><strong class='text-success'>([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Gold</td><td><strong class='text-success'>", SourceParser.EMPTY);
        }
        public static String ParseSatoshi(String src)
        {
            String pattern = "<td>Satoshi</td><td><strong class='text-success'>([0-9])*";
            Match match = Regex.Match(src, pattern);
            int count = match.Groups.Count;
            return match.Groups[0].Value.Replace("<td>Satoshi</td><td><strong class='text-success'>", SourceParser.EMPTY);
        }
        public static String ParseUpdateStamina(String src) 
        {
            String staminaPattern = "<tr><td>Stamina</td><td>(.*)</td></tr><tr><td>Tokens</td>";
            String upgradePattern = "(Upgrade \\([0-9]* gold\\))";
            Match match = Regex.Match(Regex.Match(Regex.Match(src, staminaPattern).Groups[0].Value, upgradePattern).Groups[0].Value, SourceParser.GOLD_EXPENSE);
            return match.Groups[0].Value; 
        }
        public static String ParseUpdateTokens(String src) 
        {
            String staminaPattern = "<tr><td>Tokens</td><td>(.*)</td></tr><tr><td>Attack</td>";
            String upgradePattern = "(Upgrade \\([0-9]* gold\\))";
            Match match = Regex.Match(Regex.Match(Regex.Match(src, staminaPattern).Groups[0].Value, upgradePattern).Groups[0].Value,SourceParser.GOLD_EXPENSE);
            return match.Groups[0].Value; 
        }
        public static String ParseUpdateATK(String src) 
        {
            String staminaPattern = "<tr><td>Attack</td><td>(.*)</td></tr><tr><td>Defense</td>";
            String upgradePattern = "(Upgrade \\([0-9]* gold\\))";
            Match match = Regex.Match(Regex.Match(Regex.Match(src, staminaPattern).Groups[0].Value, upgradePattern).Groups[0].Value, SourceParser.GOLD_EXPENSE);
            return match.Groups[0].Value;
        }
        public static String ParseUpdateDEF(String src)
        {
            String staminaPattern = "<tr><td>Defense</td><td>(.*)</td></tr><tr><td>Battle Stats</td>";
            String upgradePattern = "(Upgrade \\([0-9]* gold\\))";
            Match match = Regex.Match(Regex.Match(Regex.Match(src, staminaPattern).Groups[0].Value, upgradePattern).Groups[0].Value, SourceParser.GOLD_EXPENSE);
            return match.Groups[0].Value; 
        }
        public static String ParseAvailableTokens(String tokenString)
        {
            Match match = Regex.Match(tokenString, "([0-9]+)\\/([0-9]+)");
            return match.Groups[2].Value;
        }
        public static String ParseArenaPoints(String sourceInfo)
        {
            String pattern = "(<td>Your arena points<\\/td><td><strong>)([0-9]*(,[0-9]*)*)(<\\/strong><\\/td>)";
            sourceInfo = sourceInfo.Replace("\n", SourceParser.EMPTY);
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY);
            Match match = Regex.Match(sourceInfo, pattern);
            return match.Groups[2].Value;
        }
    }
}
