using System.Collections.Generic;

namespace WebClientWPF.Models
{
    public class ArtistMatches
    {
        [Newtonsoft.Json.JsonProperty("artist")]
        public List<Artist> Artists { get; set; }
    }
}