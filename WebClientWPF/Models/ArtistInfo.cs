using Newtonsoft.Json;

namespace WebClientWPF.Models
{
    public class ArtistInfo
    {
        [JsonProperty("artist")]
        public Artist Artist { get; set; }
    }
}
