using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerLibrary.Models;
using System.Web.Script.Serialization;

namespace JSONExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SummonerModel summoner = SummonerModel.GetDummySummoner();
            summoner.FirstSummonerSpell.SpellUsedTime = DateTime.Now;

            var json =
                "{\"Name\":\"TOP\",\"FirstSummonerSpell\":{\"Name\":\"flash\",\"Cooldown\":300,\"SpellUsedTime\":\"\\/Date(1521744015499)\\/\",\"SecondsLeft\":300},\"SecondSummonerSpell\":{\"Name\":\"teleport\",\"Cooldown\":270,\"SpellUsedTime\":null,\"SecondsLeft\":0}}";

            var newsummoner = new JavaScriptSerializer().Deserialize<SummonerModel>(json);

            Console.WriteLine(newsummoner.Name);
            Console.WriteLine(newsummoner.SecondSummonerSpell.Name);

            Console.ReadLine();
        }
    }
}
