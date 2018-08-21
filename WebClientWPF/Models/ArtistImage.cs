namespace WebClientWPF.Models
{
    public class ArtistImage
    {
        [Newtonsoft.Json.JsonProperty("#text")]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("size")]
        public string Size { get; set; }
    }
}