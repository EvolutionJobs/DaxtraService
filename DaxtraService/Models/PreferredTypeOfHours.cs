namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class PreferredTypeOfHours
    {
        [JsonProperty("FULLTIME")]
        public bool FullTime { get; set; }

        [JsonProperty("PARTTIME")]
        public bool PartTime { get; set; }
    }
}