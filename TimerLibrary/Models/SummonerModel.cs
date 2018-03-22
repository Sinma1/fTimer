namespace TimerLibrary.Models
{
    public class SummonerModel
    {
        public string Name { get; set; }
        public SummonerSpellModel FirstSummonerSpell { get; set; }
        public SummonerSpellModel SecondSummonerSpell { get; set; }

        public static SummonerModel CreateDefaultSummoner(
            string name, string firstSpellName, string secondSpellName)
        {
            var summoner = new SummonerModel()
            {
                Name = name,
                FirstSummonerSpell = new SummonerSpellModel()
                {
                    Name = firstSpellName, Cooldown = SummonerSpellModel.SpellsCooldowns[firstSpellName]
                },
                SecondSummonerSpell = new SummonerSpellModel()
                {
                    Name = secondSpellName, Cooldown = SummonerSpellModel.SpellsCooldowns[secondSpellName]
                }
            };
            var val = SummonerSpellModel.SpellsCooldowns[secondSpellName];
            return summoner;
        }

        public static SummonerModel GetDummySummoner()
        {
            return CreateDefaultSummoner("ROLE", "flash", "teleport");
        }
    }
}
