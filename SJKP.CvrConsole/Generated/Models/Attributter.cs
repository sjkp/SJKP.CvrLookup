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

    public partial class Attributter
    {
        /// <summary>
        /// Initializes a new instance of the Attributter class.
        /// </summary>
        public Attributter() { }

        /// <summary>
        /// Initializes a new instance of the Attributter class.
        /// </summary>
        public Attributter(int? sekvensnr = default(int?), string type = default(string), string vaerditype = default(string), IList<Vaerdier> vaerdier = default(IList<Vaerdier>))
        {
            Sekvensnr = sekvensnr;
            Type = type;
            Vaerditype = vaerditype;
            Vaerdier = vaerdier;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sekvensnr")]
        public int? Sekvensnr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vaerditype")]
        public string Vaerditype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vaerdier")]
        public IList<Vaerdier> Vaerdier { get; set; }

    }
}
