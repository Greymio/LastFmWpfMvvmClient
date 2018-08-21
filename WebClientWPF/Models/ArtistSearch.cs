using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientWPF.Models
{
    public class ArtistSearch
    {
        [Newtonsoft.Json.JsonProperty("results")]
        public Results Results { get; set; }
    }
}
