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

    public partial class Deltager
    {
        /// <summary>
        /// Initializes a new instance of the Deltager class.
        /// </summary>
        public Deltager() { }

        /// <summary>
        /// Initializes a new instance of the Deltager class.
        /// </summary>
        public Deltager(object enhedsNummer = default(object), string enhedstype = default(string), string forretningsnoegle = default(string), object organisationstype = default(object), string sidstIndlaest = default(string), IList<Navne2> navne = default(IList<Navne2>), IList<Beliggenhedsadresse2> beliggenhedsadresse = default(IList<Beliggenhedsadresse2>))
        {
            EnhedsNummer = enhedsNummer;
            Enhedstype = enhedstype;
            Forretningsnoegle = forretningsnoegle;
            Organisationstype = organisationstype;
            SidstIndlaest = sidstIndlaest;
            Navne = navne;
            Beliggenhedsadresse = beliggenhedsadresse;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enhedsNummer")]
        public object EnhedsNummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enhedstype")]
        public string Enhedstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "forretningsnoegle")]
        public string Forretningsnoegle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organisationstype")]
        public object Organisationstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sidstIndlaest")]
        public string SidstIndlaest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navne")]
        public IList<Navne2> Navne { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "beliggenhedsadresse")]
        public IList<Beliggenhedsadresse2> Beliggenhedsadresse { get; set; }

    }
}