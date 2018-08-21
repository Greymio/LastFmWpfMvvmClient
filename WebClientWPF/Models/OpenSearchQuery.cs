namespace WebClientWPF.Models
{
    public class OpenSearchQuery
    {
        [Newtonsoft.Json.JsonProperty("#text")]
        public string Text { get; set; }

        [Newtonsoft.Json.JsonProperty("role")]
        public string Role { get; set; }

        [Newtonsoft.Json.JsonProperty("searchTerms")]
        public string SearchTerms { get; set; }

        [Newtonsoft.Json.JsonProperty("startPage")]
        public string StartPage { get; set; }
    }
}