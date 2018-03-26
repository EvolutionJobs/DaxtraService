namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class Patent
    {
        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}