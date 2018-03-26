namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class EducationHistoryType
    {
        [JsonProperty("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("EndDate")]
        public string EndDate { get; set; }

        [JsonProperty("MeasureValue")]
        public string MeasureValue { get; set; }

        [JsonProperty("Major")]
        public string Major { get; set; }

        [JsonProperty("SchoolUnit")]
        public string SchoolUnit { get; set; }

        [JsonProperty("Degree")]
        public Degree Degree { get; set; }

        [JsonProperty("LocationSummary")]
        public LocationSummaryType LocationSummary { get; set; }

        [JsonProperty("SchoolName")]
        public string SchoolName { get; set; }

        [JsonProperty("schoolType")]
        public string SchoolType { get; set; }

        [JsonProperty("Comments")]
        public string Comments { get; set; }
    }
}