namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class PublicationHistoryName
    {
        [JsonProperty("FormattedName")]
        public string FormattedName { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}