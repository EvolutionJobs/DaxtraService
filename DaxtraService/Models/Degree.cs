namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class Degree
    {
        [JsonProperty("degreeType")]
        public string DegreeType { get; set; }

        [JsonProperty("DegreeName")]
        public string DegreeName { get; set; }

        [JsonProperty("DegreeDate")]
        public string DegreeDate { get; set; }
    }
}