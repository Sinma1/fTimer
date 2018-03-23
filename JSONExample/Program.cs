using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerLibrary.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace JSONExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SummonerModel summoner = SummonerModel.GetDummySummoner();
            summoner.FirstSummonerSpell.SpellUsedTime = DateTime.Now;

            var newsummoner = new JavaScriptSerializer().Deserialize<SummonerModel>(new JavaScriptSerializer().Serialize(summoner));
            var jsonnetsummoner = JsonConvert.DeserializeObject<SummonerModel>(JsonConvert.SerializeObject(summoner));
            
            Console.WriteLine(newsummoner.FirstSummonerSpell.SpellUsedTime);
            Console.WriteLine(jsonnetsummoner.FirstSummonerSpell.SpellUsedTime);

            Console.ReadLine();
        }
    }
}
