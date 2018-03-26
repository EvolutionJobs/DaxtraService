namespace Evolution.Daxtra.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ContactMethodType
    {
        [JsonProperty("InternetWebAddress")]
        public IEnumerable<InternetWebAddress> InternetWebAddress { get; set; }

        [JsonProperty("InternetEmailAddress_main")]
        public string InternetEmailAddressMain { get; set; }

        [JsonProperty("InternetEmailAddress_alt")]
        public string InternetEmailAddressAlt { get; set; }

        [JsonProperty("Telephone_home")]
        public string TelephoneHome { get; set; }

        [JsonProperty("Telephone_work")]
        public string TelephoneWork { get; set; }

        [JsonProperty("Telephone_alt")]
        public string TelephoneAlt { get; set; }

        [JsonProperty("Telephone_mobile")]
        public string TelephoneMobile { get; set; }

        [JsonProperty("Pager")]
        public string Pager { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("PostalAddress_main")]
        public LocationSummaryType PostalAddressMain { get; set; }

        [JsonProperty("PostalAddress_alt")]
        public LocationSummaryType PostalAddressAlt { get; set; }
    }
}