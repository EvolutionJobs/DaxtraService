namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class EmailTrackingData
    {
        [JsonProperty("RecipientsEmail")]
        public string RecipientsEmail { get; set; }

        [JsonProperty("EmailDate")]
        public string EmailDate { get; set; }

        [JsonProperty("SendersEmail")]
        public string SendersEmail { get; set; }

        [JsonProperty("EmailSubject")]
        public string EmailSubject { get; set; }
    }
}