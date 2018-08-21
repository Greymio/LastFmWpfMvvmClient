using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebClientWPF.Models
{
    public class Tags
    {
        [JsonProperty("tag")]
        public List<Tag> Tag { get; set; }
    }
}