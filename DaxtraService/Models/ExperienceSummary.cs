namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class ExperienceSummary
    {
        [JsonProperty("TotalYearsOfManagementWorkExperience")]
        public decimal? TotalYearsOfManagementWorkExperience { get; set; }

        [JsonProperty("TotalYearsOfLowLevelManagementWorkExperience")]
        public decimal? TotalYearsOfLowLevelManagementWorkExperience { get; set; }

        [JsonProperty("TotalMonthsOfWorkExperience")]
        public decimal? TotalMonthsOfWorkExperience { get; set; }

        [JsonProperty("ExecutiveBrief")]
        public string ExecutiveBrief { get; set; }

        [JsonProperty("TotalMonthsOfLowLevelManagementWorkExperience")]
        public decimal? TotalMonthsOfLowLevelManagementWorkExperience { get; set; }

        [JsonProperty("TotalMonthsOfManagementWorkExperience")]
        public decimal? TotalMonthsOfManagementWorkExperience { get; set; }

        [JsonProperty("TotalYearsOfMidLevelManagementWorkExperience")]
        public decimal? TotalYearsOfMidLevelManagementWorkExperience { get; set; }

        [JsonProperty("TotalMonthsOfMidLevelManagementWorkExperience")]
        public decimal? TotalMonthsOfMidLevelManagementWorkExperience { get; set; }

        [JsonProperty("TotalYearsOfSeniorManagementWorkExperience")]
        public decimal? TotalYearsOfSeniorManagementWorkExperience { get; set; }

        [JsonProperty("TotalMonthsOfSeniorManagementWorkExperience")]
        public decimal? TotalMonthsOfSeniorManagementWorkExperience { get; set; }

        [JsonProperty("ManagementRecord")]
        public string ManagementRecord { get; set; }

        [JsonProperty("HighestEducationalLevel")]
        public string HighestEducationalLevel { get; set; }

        [JsonProperty("TotalYearsOfWorkExperience")]
        public decimal? TotalYearsOfWorkExperience { get; set; }
    }
}