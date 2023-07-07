using GFA.OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Models
{
    internal class GameAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Platform Platform { get; set; }
        public int Level { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public static Platform ConvertStringToPlatform(string platform)
        {
            switch (platform.ToLower())
            {
                case "steam":
                    return Platform.Steam;
                case "origin":
                    return Platform.Origin;
                case "battle.net":
                    return Platform.BattleNet;
                case "uplay":
                    return Platform.Uplay;
                case "epic games":
                    return Platform.EpicGames;

                default:
                    throw new Exception("Unex");
            }
        }
    }
}
