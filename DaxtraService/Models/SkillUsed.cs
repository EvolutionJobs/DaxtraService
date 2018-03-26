namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class SkillUsed
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("type")]
        public string SkillType { get; set; }
    }
}