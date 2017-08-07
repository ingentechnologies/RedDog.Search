using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ingen.RedDog.Search.Model
{
    public class LookupQueryResult
    {
        public LookupQueryResult()
        {
            Properties = new Dictionary<string, object>();
        }

        [JsonExtensionData]
        public Dictionary<string, object> Properties
        {
            get;
            set;
        }
    }
}