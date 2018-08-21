using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebClientWPF.Models
{
    public class Similar
    {
        [JsonProperty("artist")]
        public List<Artist> Artists { get; set; }
    }
}