namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class CompetencyType
    {
        [JsonProperty("skillLevel")]
        public int? SkillLevel { get; set; }

        [JsonProperty("skillUsed")]
        public SkillUsed SkillUsed { get; set; }

        [JsonProperty("skillProficiency")]
        public string SkillProficiency { get; set; }

        [JsonProperty("Grade")]
        public string Grade { get; set; }

        [JsonProperty("skillName")]
        public string SkillName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("auth")]
        public bool Auth { get; set; }

        [JsonProperty("skillCount")]
        public int? SkillCount { get; set; }

        [JsonProperty("lastUsed")]
        public string LastUsed { get; set; }

        [JsonProperty("CompetencyId")]
        public CompetencyID CompetencyID { get; set; }

        [JsonProperty("TaxonomyId")]
        public TaxonomyID TaxonomyId { get; set; }

        [JsonProperty("skillAliasArray")]
        public IEnumerable<string> SkillAliasArray { get; set; }
    }
}