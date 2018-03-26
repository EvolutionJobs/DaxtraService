namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class LegalDocument
    {
        [JsonProperty("IssueCountryCode")]
        public string IssueCountryCode { get; set; }

        [JsonProperty("IssueAuthority")]
        public string IssueAuthority { get; set; }

        [JsonProperty("IssueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("IssueLocationSummary")]
        public LocationSummaryType IssueLocationSummary { get; set; }

        [JsonProperty("type")]
        public string DocumentType { get; set; }
    }
}