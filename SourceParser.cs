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
            String pattern = "<table class='table stats-table'>(.*)<\\/tbody><\\/table>";
            Match match = Regex.Match(sourceInfo, pattern);
            playerInfo.Add(SourceParser.ParseLevel(sourceInfo));
            playerInfo.Add(SourceParser.ParseAttack(sourceInfo));
            playerInfo.Add(SourceParser.ParseDefense(sourceInfo));            
            playerInfo.Add(SourceParser.ParseStamina(sourceInfo));
            playerInfo.Add(SourceParser.ParseTokens(sourceInfo));
            playerInfo.Add(SourceParser.ParseGold(sourceInfo));
            playerInfo.Add(SourceParser.ParseSatoshi(sourceInfo));
            /* List stored in order as following:
             * 1.Level      2.Attack
             * 3.Defense    4.Stamina
             * 5.Tokens     6.Gold
             * 7.Satoshi
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

        public static String ParseUpdateATK(String src) 
        {
            String pattern = "";
            return SourceParser.EMPTY; 
        }
        public static String ParseUpdateDEF(String src) { return SourceParser.EMPTY; }
        public static String ParseUpdateStamina(String src) { return SourceParser.EMPTY; }
        public static String ParseUpdateTokens(String src) { return SourceParser.EMPTY; }
    }
}
