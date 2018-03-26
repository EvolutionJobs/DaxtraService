namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class FilePicture
    {
        [JsonProperty("content-disposition")]
        public string ContentDisposition { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("content-transfer-encoding")]
        public string ContentTransferEncoding { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }
    }
}