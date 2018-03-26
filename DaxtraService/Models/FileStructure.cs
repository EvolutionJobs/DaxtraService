namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class FileStructure
    {
        [JsonProperty("attachment")]
        public IEnumerable<FileAttachment> Attachment { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("picture")]
        public FilePicture Picture { get; set; }
    }
}