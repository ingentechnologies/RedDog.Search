using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingen.RedDog.Search.Model
{
    public class SynonymMap
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("format")]
        public string Format { get { return "solr"; } }
        [JsonProperty("synonyms")]
        public string Synonyms { get; set; }
    }
}
