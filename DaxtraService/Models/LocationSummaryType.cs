namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class LocationSummaryType
    {
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("Municipality")]
        public string Municipality { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("AddressLine")]
        public string AddressLine { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
    }
}