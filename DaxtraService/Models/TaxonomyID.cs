namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class TaxonomyID
    {
        [JsonProperty("idOwner")]
        public string Owner { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}