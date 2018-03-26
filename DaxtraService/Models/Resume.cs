namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Model for http://cvxdemo.daxtra.com/cvx/cvx_schema/candidate/2.0.35/Resume.json
    /// <para>Daxtra's naming convention is extremely inconsistent, so all properties have explicit name attributes.</para>
    /// </summary>
    public class Resume
    {
        [JsonProperty("ExperienceSummary")]
        public ExperienceSummary ExperienceSummary { get; set; }

        [JsonProperty("FileStruct")]
        public FileStructure FileStruct { get; set; }

        [JsonProperty("ParserInfo")]
        public ParserInformation ParserInfo { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("TextResume")]
        public string TextResume { get; set; }

        [JsonProperty("StructuredResume")]
        public StructuredResume StructuredResume { get; set; }

        [JsonProperty("TextZones")]
        public IEnumerable<TextZone> TextZones { get; set; }

        [JsonProperty("EmailTrackingData")]
        public EmailTrackingData EmailTracking { get; set; }
    }
}