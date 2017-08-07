using Newtonsoft.Json;

namespace Ingen.RedDog.Search.Model
{
    public class CorsOptions
    {
        public CorsOptions()
        {
            AllowedOrigins = new[] {"*"};
        }

        [JsonProperty("allowedOrigins")]
        public string[] AllowedOrigins
        {
            get;
            set;
        }

        [JsonProperty("maxAgeInSeconds")]
        public long MaxAgeInSeconds
        {
            get;
            set;
        }
    }
}