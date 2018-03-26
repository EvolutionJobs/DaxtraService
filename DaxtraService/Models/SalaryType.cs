namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class SalaryType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("hiamount")]
        public decimal? HighAmount { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }
    }
}