using System.Collections.Generic;
using System.Web.Script.Serialization;

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
            return new JavaScriptSerializer().Serialize(this);
        }

        public static MatchModel ParseJsonString(string json)
        {
            return new JavaScriptSerializer().Deserialize<MatchModel>(json);
        }
    }
}
