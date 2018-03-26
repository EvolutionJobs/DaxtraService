namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class InternetWebAddress
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("type")]
        public string AddressType { get; set; }
    }
}