using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurrencyConverter.Response
{
    public class CurrencyResponse
    {
        [JsonPropertyName("rates")]
        public Rate Rates { get; set; }

        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("license")]
        public string License { get; set; }
    }

    public class Rate
    {
        public double INR { get; set; }
        public double JPY { get; set; }
        public double USD { get; set; }
        public double NZD { get; set; }
        public double EUR { get; set; }
        public double CAD { get; set; }
        public double ISK { get; set; }
        public double PHP { get; set; }
        public double DKK { get; set; }
        public double CZK { get; set; }
    }
}
