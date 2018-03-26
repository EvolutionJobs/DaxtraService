namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class PersonNameType
    {
        [JsonProperty("FormattedName")]
        public string FormattedName { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Suffix")]
        public string Suffix { get; set; }

        [JsonProperty("FamilyName")]
        public string FamilyName { get; set; }

        [JsonProperty("GivenName")]
        public string GivenName { get; set; }

        [JsonProperty("PreferredGivenName")]
        public string PreferredGivenName { get; set; }

        [JsonProperty("MiddleName")]
        public IEnumerable<string> MiddleName { get; set; }

        [JsonProperty("sex")]
        public string Gender { get; set; }
    }
}