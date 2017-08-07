using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Ingen.RedDog.Search.Model
{
    public class Suggester
    {
        public Suggester()
        {
            SourceFields = new Collection<string>();
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("searchMode")]
        public SuggesterSearchMode SearchMode
        {
            get;
            set;
        }

        [JsonProperty("sourceFields")]
        public ICollection<string> SourceFields
        {
            get;
            set;
        }
    }
}
