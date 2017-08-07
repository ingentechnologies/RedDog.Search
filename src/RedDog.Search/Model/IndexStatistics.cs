﻿using Newtonsoft.Json;

namespace Ingen.RedDog.Search.Model
{
    public class IndexStatistics
    {
        [JsonProperty("documentCount")]
        public long DocumentCount
        {
            get;
            set;
        }

        [JsonProperty("storageSize")]
        public long StorageSize
        {
            get;
            set;
        }
    }
}