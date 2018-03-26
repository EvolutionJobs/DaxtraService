namespace Evolution.Daxtra
{
    using Evolution.Daxtra.Models;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using System;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    class DaxtraParser : HttpService, IDaxtraParser
    {
        readonly ILogger logger;
        readonly StringContent key;
        readonly string api;
        const string fullProfileResource = "/profile/full/json";

        /// <summary>Get the serialisation settings used by Daxtra</summary>
        internal static JsonSerializerSettings JsonSettings { get; } = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
            MissingMemberHandling = MissingMemberHandling.Ignore,
        };

        public DaxtraParser(ILoggerFactory logger, string url, string api, string key) :
            base(CreateClient(url))
        {
            this.logger = logger.CreateLogger<DaxtraParser>();
            this.key = new StringContent(key, Encoding.UTF8);
            this.api = api;
        }

        /// <summary>Create the HTTP client to access Daxtra with.</summary>
        /// <param name="url">The base URL for Daxtra's service.</param>
        /// <returns>The new HTTP client.</returns>
        static HttpClient CreateClient(string url)
        {
            var c = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip
            })
            {
                BaseAddress = new Uri(url)
            };

            // Request GZIPped response
            c.DefaultRequestHeaders.Add("Content-Transfer-Encoding", "gzip");

            return c;
        }

        async Task<Resume> PostToDaxtra(byte[] file)
        {
            this.logger.LogInformation("Parsing {FileLength} Bytes", file.Length);

            // Fix bug in Daxtra's multipart/form-data implementation - they expect "" around part names, which .NET (correctly) treats as optional
            var formContent = new MultipartFormDataContent
            {
                { new ByteArrayContent(file), "\"file\"" },
                { this.key, "\"account\"" }
            };

            // var sw = new Stopwatch();
            // sw.Start();
            var response = await this.Client.PostAsync(this.api + fullProfileResource, formContent);
            // sw.Stop();
            // this.logger.LogInformation("Daxtra CVX Response {Status}: {Reason} in {Duration}ms", (int)response.StatusCode, response.ReasonPhrase, sw.ElapsedMilliseconds);

            if (response.StatusCode == HttpStatusCode.NotFound ||
                response.StatusCode == HttpStatusCode.NoContent)
                return null;

            var content = response.Content;

            // Fix bug in Daxtra's response where they return the wrong encoding name
            if (content.Headers.ContentType.CharSet == "UTF8")
                content.Headers.ContentType.CharSet = "UTF-8";

            // Read body from GZIPped content
            string body = await content.ReadAsStringAsync();

            DaxtraResult result;
            try
            {
                // Parse the result
                result = JsonConvert.DeserializeObject<DaxtraResult>(body, JsonSettings);
            }
            catch (Exception x)
            {
                x.Data.Add("json-response", body);
                throw;
            }

            if (result.Error != null)
                throw new DaxtraException(result.Error.Message, result.Error.Code, response.StatusCode, body);
            else if (!response.IsSuccessStatusCode)
                throw new DaxtraException($"HTTP Error returned from Daxtra service: {response.ReasonPhrase}", (int)response.StatusCode, response.StatusCode, body);
            else if (result.Resume == null)
                throw new DaxtraException($"Parse failed!\r\nBody: {body}", (int)response.StatusCode, response.StatusCode, body);

            return result.Resume;
        }

        Task<Resume> IDaxtraParser.Parse(byte[] file) => 
            this.PostToDaxtra(file);
    }
}