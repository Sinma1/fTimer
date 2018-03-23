using System.Collections.Generic;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace TimerLibrary.Models
{
    public class MatchModel
    {
        public SummonerModel TopSummoner { get; set; }
        public SummonerModel JungleSummoner { get; set; }
        public SummonerModel MidSummoner { get; set; }
        public SummonerModel AdcSummoner { get; set; }
        public SummonerModel SupportSummoner { get; set; }

        public List<SummonerModel> Summoners => new List<SummonerModel>()
        {
            TopSummoner, JungleSummoner, MidSummoner, AdcSummoner, SupportSummoner
        };

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static MatchModel ParseJsonString(string json)
        {
            return JsonConvert.DeserializeObject<MatchModel>(json);
        }
    }
}
