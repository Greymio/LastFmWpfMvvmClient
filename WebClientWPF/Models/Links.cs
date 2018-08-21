using Newtonsoft.Json;

namespace WebClientWPF.Models
{
    public class Links
    {
        [JsonProperty("link")]
        public Link Link { get; set; }
    }
}