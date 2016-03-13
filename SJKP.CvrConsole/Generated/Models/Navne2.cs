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

    public partial class Navne2
    {
        /// <summary>
        /// Initializes a new instance of the Navne2 class.
        /// </summary>
        public Navne2() { }

        /// <summary>
        /// Initializes a new instance of the Navne2 class.
        /// </summary>
        public Navne2(string navn = default(string), Periode periode = default(Periode), string sidstOpdateret = default(string))
        {
            Navn = navn;
            Periode = periode;
            SidstOpdateret = sidstOpdateret;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navn")]
        public string Navn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "periode")]
        public Periode Periode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sidstOpdateret")]
        public string SidstOpdateret { get; set; }

    }
}