namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class CompetencyID
    {
        [JsonProperty("idOwner")]
        public string Owner { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }
    }
}