using Newtonsoft.Json;

namespace WebClientWPF.Models
{
    public class Bio
    {
        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}