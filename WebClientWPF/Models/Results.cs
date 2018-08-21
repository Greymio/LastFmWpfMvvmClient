namespace WebClientWPF.Models
{
    public class Results
    {
        [Newtonsoft.Json.JsonProperty("opensearch:Query")]
        public OpenSearchQuery Query { get; set; }

        [Newtonsoft.Json.JsonProperty("opensearch:totalResults")]
        public string TotalResults { get; set; }

        [Newtonsoft.Json.JsonProperty("opensearch:startIndex")]
        public string StartIndex { get; set; }

        [Newtonsoft.Json.JsonProperty("opensearch:itemsPerPage")]
        public string ItemsPerPage { get; set; }

        [Newtonsoft.Json.JsonProperty("artistmatches")]
        public ArtistMatches ArtistMatches { get; set; }

        [Newtonsoft.Json.JsonProperty("@attr")]
        public Attr Attr { get; set; }
    }
}