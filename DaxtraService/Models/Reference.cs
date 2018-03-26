namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class Reference
    {
        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("PersonName")]
        public PersonNameType PersonName { get; set; }

        [JsonProperty("ContactMethod")]
        public ContactMethodType ContactMethod { get; set; }

        [JsonProperty("PositionTitle")]
        public string PositionTitle { get; set; }
    }
}