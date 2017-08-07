using System;
using Newtonsoft.Json;
using Ingen.RedDog.Search.Http;

namespace Ingen.RedDog.Search.Model
{
    public class ScoringProfileFunctionFreshness
    {
        [JsonProperty("boostingDuration")]
        public TimeSpan BoostingDuration
        {
            get;
            set;
        }
    }
}