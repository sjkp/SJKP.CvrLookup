// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SJKP.CvrClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Hits
    {
        /// <summary>
        /// Initializes a new instance of the Hits class.
        /// </summary>
        public Hits() { }

        /// <summary>
        /// Initializes a new instance of the Hits class.
        /// </summary>
        public Hits(int? total = default(int?), double? maxScore = default(double?), IList<Hit> hitsProperty = default(IList<Hit>))
        {
            Total = total;
            MaxScore = maxScore;
            HitsProperty = hitsProperty;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_score")]
        public double? MaxScore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public IList<Hit> HitsProperty { get; set; }

    }
}
