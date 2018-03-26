namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class StructuredResume
    {
        [JsonProperty("Achievements")]
        public IEnumerable<FileAttachment> Achievements { get; set; }

        [JsonProperty("Available")]
        public string Available { get; set; }

        [JsonProperty("Competency")]
        public IEnumerable<CompetencyType> Competency { get; set; }

        [JsonProperty("ContactMethod")]
        public ContactMethodType ContactMethod { get; set; }

        [JsonProperty("DOB")]
        public string DateOfBirth { get; set; }

        [JsonProperty("EducationHistory")]
        public IEnumerable<EducationHistoryType> EducationHistory { get; set; }

        [JsonProperty("EmploymentHistory")]
        public IEnumerable<EmploymentHistoryType> EmploymentHistory { get; set; }

        [JsonProperty("ExecutiveSummary")]
        public string ExecutiveSummary { get; set; }

        [JsonProperty("Hobbies")]
        public string Hobbies { get; set; }

        [JsonProperty("Languages")]
        public IEnumerable<Language> Languages { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("LegalDocuments")]
        public IEnumerable<LegalDocument> LegalDocuments { get; set; }

        [JsonProperty("MaritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("Nationality")]
        public IEnumerable<string> Nationality { get; set; }

        [JsonProperty("OtherInfo")]
        public string OtherInfo { get; set; }

        [JsonProperty("PatentHistory")]
        public IEnumerable<Patent> PatentHistory { get; set; }

        [JsonProperty("PersonName")]
        public PersonNameType PersonName { get; set; }

        [JsonProperty("PlaceOfBirth")]
        public LocationSummaryType PlaceOfBirth { get; set; }

        [JsonProperty("PoliticalStatus")]
        public string PoliticalStatus { get; set; }

        [JsonProperty("PreferredLocation")]
        public string PreferredLocation { get; set; }

        [JsonProperty("PreferredPosition")]
        public string PreferredPosition { get; set; }

        [JsonProperty("PreferredPositionType")]
        public PreferredPositionType PreferredPositionType { get; set; }

        [JsonProperty("PreferredTypeOfHours")]
        public PreferredTypeOfHours PreferredTypeOfHours { get; set; }

        [JsonProperty("ProjectHistory")]
        public IEnumerable<EmploymentHistoryType> ProjectHistory { get; set; }

        [JsonProperty("PublicationHistory")]
        public IEnumerable<PublicationHistoryType> PublicationHistory { get; set; }

        [JsonProperty("Race")]
        public string Race { get; set; }

        [JsonProperty("References")]
        public IEnumerable<Reference> References { get; set; }

        [JsonProperty("RegisteredResidence")]
        public LocationSummaryType RegisteredResidence { get; set; }

        [JsonProperty("Religion")]
        public string Religion { get; set; }

        [JsonProperty("RevisionDate")]
        public string RevisionDate { get; set; }

        [JsonProperty("Salary_desired")]
        public SalaryType SalaryDesired { get; set; }

        [JsonProperty("UserFields")]
        public IEnumerable<UserField> UserFields { get; set; }

        [JsonProperty("WillRelocate")]
        public bool WillRelocate { get; set; }
    }
}