namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class FileAttachment
    {
        [JsonProperty("cat_score")]
        public string CatScore { get; set; }

        [JsonProperty("best_cat")]
        public string BestCat { get; set; }

        [JsonProperty("conv_msg")]
        public string ConvMsg { get; set; }

        [JsonProperty("conv")]
        public string Conv { get; set; }

        [JsonProperty("main_cv")]
        public string MainCV { get; set; }

        [JsonProperty("mime")]
        public string Mime { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("fname")]
        public string FName { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_email_body")]
        public string IsEmailBody { get; set; }

        [JsonProperty("doc_type")]
        public string DocType { get; set; }

        [JsonProperty("ftype")]
        public string FType { get; set; }
    }
}