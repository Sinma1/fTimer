using System;
using System.Collections.Generic;

namespace TimerLibrary.Models
{
    public class SummonerSpellModel
    {
        public static Dictionary<string, int> SpellsCooldowns = new Dictionary<string, int>()
        {
            {"flash", 300},
            {"barrier", 180},
            {"cleanse", 210},
            {"exhaust", 210},
            {"ghost", 180},
            {"heal", 270},
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
                    return Cooldown - (int)(DateTime.Now - SpellUsedTime.Value).TotalSeconds;
                }

                return 0;
            }
        }

        public void SubtractSeconds(int seconds)
        {
            SpellUsedTime = SpellUsedTime?.AddSeconds(-seconds);
        }

        public static SummonerSpellModel CreateSpell(string name)
        {
            return new SummonerSpellModel() {Name = name, Cooldown = (SpellsCooldowns[name.ToLower()])};
        }
    }
}