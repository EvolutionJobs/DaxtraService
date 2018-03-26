namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class DaxtraError
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}