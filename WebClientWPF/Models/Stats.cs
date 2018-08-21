using Newtonsoft.Json;

namespace WebClientWPF.Models
{
    public class Stats
    {
        [JsonProperty("listeners")]
        public string Listeners { get; set; }

        [JsonProperty("playcount")]
        public string Playcount { get; set; }
    }
}