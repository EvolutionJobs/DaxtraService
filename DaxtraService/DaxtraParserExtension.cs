namespace Microsoft.Extensions.DependencyInjection
{
    using Evolution.Daxtra;
    using Microsoft.Extensions.Logging;

    public static class DaxtraParserExtension
    {
        /// <summary>Add Daxtra as a CV parsing service.</summary>
        /// <param name="services">The services to extend.</param>
        /// <param name="url">The URL of the Daxtra service.</param>
        /// <param name="api">The API path and version.</param>
        /// <param name="key">The account key to send with each request.</param>
        /// <returns>The extended service</returns>
        public static IServiceCollection AddDaxtraParser(this IServiceCollection services, string url, string api, string key)
        {
            // Add Companies House API service
            return services.AddSingleton<IDaxtraParser>(
                sp => new DaxtraParser(sp.GetService<ILoggerFactory>(), url, api, key));
        }
    }
}