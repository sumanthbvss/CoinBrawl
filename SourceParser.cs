using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SourceParser
    {
        private const String EMPTY = "";
        private const String GOLD_EXPENSE = "([0-9])+";
        public static String parseAuthenticationToken(String htmlSourceStr)
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

        public static List<String> ParseArenaPlayer(String src)
        {
            List<String> arenaPlayer = new List<String>();
            return arenaPlayer;
        }

        public static List<String> PlayerStateInfo(String sourceInfo)
        {
            List<String> playerInfo = new List<String>();
            sourceInfo = sourceInfo.Replace("\n", SourceParser.EMPTY);
            sourceInfo = sourceInfo.Replace("\r", SourceParser.EMPTY);
            String pattern = "<table class='table stats-table'>(.*)<\\/tbody><\\/table>";
            Match match = Regex.Match(sourceInfo, pattern);
            playerInfo.Add(SourceParser.ParseLevel(sourceInfo));
            playerInfo.Add(SourceParser.ParseAttack(sourceInfo));
            playerInfo.Add(SourceParser.ParseDefense(sourceInfo));            
            playerInfo.Add(SourceParser.ParseStamina(sourceInfo));
            playerInfo.Add(SourceParser.ParseTokens(sourceInfo));
            playerInfo.Add(SourceParser.ParseGold(sourceInfo));
            playerInfo.Add(SourceParser.ParseSatoshi(sourceInfo));
            playerInfo.Add(SourceParser.ParseUpdateStamina(sourceInfo));
            playerInfo.Add(SourceParser.ParseUpdateTokens(sourceInfo));
            playerInfo.Add(SourceParser.ParseUpdateATK(sourceInfo));
            playerInfo.Add(SourceParser.ParseUpdateDEF(sourceInfo));
            /* List stored in order as following:
             * 1.Level              2.Attack
             * 3.Defense            4.Stamina
             * 5.Tokens             6.Gold
             * 7.Satoshi            8.Upgrade Stamina
             * 9.Upgrade Tokens     10.Upgrade Attack
             * 11.Upgrade Defense
             */
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
    }
}
