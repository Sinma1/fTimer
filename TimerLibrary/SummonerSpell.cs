using System;
using System.Collections.Generic;

namespace TimerLibrary
{
    public class SummonerSpell
    {
        public static Dictionary<string, int> SpellsCooldowns = new Dictionary<string, int>()
        {
            {"flash", 300},
            {"barrier", 180},
            {"cleanse", 210},
            {"exhaust", 210},
            {"ghost", 180},
            {"heal", 240},
            {"ignite", 210},
            {"smite", 90},
            {"teleport", 270}
        };

        public string Name { get; set; }
        public int Cooldown { get; set; }

        public DateTime? SpellUsedTime { get; set; }
        public int SecondsLeft
        {
            get
            {
                if (SpellUsedTime.HasValue)
                {
                    return (Cooldown - DateTime.Now.Subtract(SpellUsedTime.Value).Seconds);
                }

                return 0;
            }
        }

        public static SummonerSpell CreateSpell(string name)
        {
            return new SummonerSpell() {Name = name, Cooldown = (SpellsCooldowns[name.ToLower()])};
        }
    }
}