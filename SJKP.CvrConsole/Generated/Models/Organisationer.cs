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

    public partial class Organisationer
    {
        /// <summary>
        /// Initializes a new instance of the Organisationer class.
        /// </summary>
        public Organisationer() { }

        /// <summary>
        /// Initializes a new instance of the Organisationer class.
        /// </summary>
        public Organisationer(object enhedsNummerOrganisation = default(object), string hovedtype = default(string), IList<OrganisationsNavn> organisationsNavn = default(IList<OrganisationsNavn>), IList<Attributter2> attributter = default(IList<Attributter2>), IList<MedlemsData> medlemsData = default(IList<MedlemsData>))
        {
            EnhedsNummerOrganisation = enhedsNummerOrganisation;
            Hovedtype = hovedtype;
            OrganisationsNavn = organisationsNavn;
            Attributter = attributter;
            MedlemsData = medlemsData;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enhedsNummerOrganisation")]
        public object EnhedsNummerOrganisation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hovedtype")]
        public string Hovedtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organisationsNavn")]
        public IList<OrganisationsNavn> OrganisationsNavn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributter")]
        public IList<Attributter2> Attributter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "medlemsData")]
        public IList<MedlemsData> MedlemsData { get; set; }

    }
}
