namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class DaxtraResult
    {
        [JsonProperty("Resume")]
        public Resume Resume { get; set; }

        [JsonProperty("CSERROR")]
        public DaxtraError Error { get; set; }
    }
}