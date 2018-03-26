namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class PreferredPositionType
    {
        [JsonProperty("CONTRACT")]
        public bool Contract { get; set; }

        [JsonProperty("TEMPORARY")]
        public bool Temporary { get; set; }

        [JsonProperty("PERMANENT")]
        public bool Permanent { get; set; }
    }
}