using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerLibrary
{
    public class Summoner
    {
        public string Name { get; set; }
        public SummonerSpell FirstSummonerSpell { get; set; }
        public SummonerSpell SecondSummonerSpell { get; set; }

        public static Summoner CreateDefaultSummoner(
            string name, string firstSpellName, string secondSpellName)
        {
            var summoner = new Summoner()
            {
                Name = name,
                FirstSummonerSpell = new SummonerSpell()
                {
                    Name = firstSpellName, Cooldown = SummonerSpell.SpellsCooldowns[firstSpellName]
                },
                SecondSummonerSpell = new SummonerSpell()
                {
                    Name = secondSpellName, Cooldown = SummonerSpell.SpellsCooldowns[secondSpellName]
                }
            };

            return summoner;
        }
    }
}
