namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;

    public class ParserInformation
    {
        [JsonProperty("ConverterRelease")]
        public string ConverterRelease { get; set; }

        [JsonProperty("ParserConfiguration")]
        public string ParserConfiguration { get; set; }

        [JsonProperty("ParserRelease")]
        public string ParserRelease { get; set; }

        [JsonProperty("ParserReleaseDate")]
        public string ParserReleaseDate { get; set; }

        [JsonProperty("ConverterReleaseDate")]
        public string ConverterReleaseDate { get; set; }

        [JsonProperty("ParserSchema")]
        public string ParserSchema { get; set; }
    }
}