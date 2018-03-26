namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class OrgIndustry
    {
        [JsonProperty("IndustryDescription")]
        public string IndustryDescription { get; set; }

        [JsonProperty("primaryIndicator")]
        public bool PrimaryIndicator { get; set; }
    }
}