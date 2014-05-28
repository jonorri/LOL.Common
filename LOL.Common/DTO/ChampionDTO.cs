namespace LOL.Common.DTO
{
    using Newtonsoft.Json;

    public class ChampionDTO
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "botEnabled")]
        public bool BotEnabled { get; set; }

        [JsonProperty(PropertyName = "botMmEnabled")]
        public bool BotMatchModeEnabled { get; set; }

        [JsonProperty(PropertyName = "freeToPlay")]
        public bool FreeToPlay { get; set; }

        [JsonProperty(PropertyName = "rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }
    }
}
