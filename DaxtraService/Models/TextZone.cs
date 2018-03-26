namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class TextZone
    {
        [JsonProperty("Header")]
        public string Header { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}