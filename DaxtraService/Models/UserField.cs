namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class UserField
    {
        [JsonProperty("FieldName")]
        public string FieldName { get; set; }

        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}