namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class Language
    {
        [JsonProperty("CompetencyId")]
        public CompetencyID CompetencyID { get; set; }

        [JsonProperty("Proficiency")]
        public string Proficiency { get; set; }

        [JsonProperty("Speak")]
        public bool Speak { get; set; }

        [JsonProperty("LanguageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("Write")]
        public bool Write { get; set; }

        [JsonProperty("Read")]
        public bool Read { get; set; }
    }
}