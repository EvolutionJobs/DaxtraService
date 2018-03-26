namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class EmploymentHistoryType
    {
        [JsonProperty("StartDate")]
        public string StartDate { get; set; }

        [JsonProperty("EndDate")]
        public string EndDate { get; set; }

        [JsonProperty("LocationSummary")]
        public LocationSummaryType LocationSummary { get; set; }

        [JsonProperty("InternetDomainName")]
        public string InternetDomainName { get; set; }

        [JsonProperty("EmployerOrgName")]
        public string EmployerOrgName { get; set; }

        [JsonProperty("employerOrgType")]
        public string EmployerOrgType { get; set; }

        [JsonProperty("PositionType")]
        public string PositionType { get; set; }

        [JsonProperty("MonthsOfWork")]
        public int? MonthsOfWork { get; set; }

        [JsonProperty("TimelineNumber")]
        public decimal? TimelineNumber { get; set; }

        [JsonProperty("Title")]
        public IEnumerable<string> Title { get; set; }

        [JsonProperty("ReasonForLeaving")]
        public string ReasonForLeaving { get; set; }

        [JsonProperty("OrgIndustry")]
        public OrgIndustry OrgIndustry { get; set; }

        [JsonProperty("JobArea")]
        public string JobArea { get; set; }

        [JsonProperty("JobGrade")]
        public string JobGrade { get; set; }

        [JsonProperty("Project")]
        public string Project { get; set; }

        [JsonProperty("OrgName")]
        public string OrgName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}