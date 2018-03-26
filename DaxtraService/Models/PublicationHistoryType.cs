namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class PublicationHistoryType
    {
        [JsonProperty("Comments")]
        public string Comments { get; set; }

        [JsonProperty("content")]
        public IEnumerable<string> Content { get; set; }

        [JsonProperty("Issue")]
        public string Issue { get; set; }

        [JsonProperty("JournalOrSerialName")]
        public string JournalOrSerialName { get; set; }

        [JsonProperty("Volume")]
        public string Volume { get; set; }

        [JsonProperty("PageNumber")]
        public string PageNumber { get; set; }

        [JsonProperty("Name")]
        public IEnumerable<PublicationHistoryName> Name { get; set; }

        [JsonProperty("Title")]
        public IEnumerable<string> Title { get; set; }

        [JsonProperty("PublicationDate")]
        public string PublicationDate { get; set; }
    }
}