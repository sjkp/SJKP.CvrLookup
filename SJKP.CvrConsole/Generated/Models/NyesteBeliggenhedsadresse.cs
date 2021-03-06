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

    public partial class NyesteBeliggenhedsadresse
    {
        /// <summary>
        /// Initializes a new instance of the NyesteBeliggenhedsadresse class.
        /// </summary>
        public NyesteBeliggenhedsadresse() { }

        /// <summary>
        /// Initializes a new instance of the NyesteBeliggenhedsadresse class.
        /// </summary>
        public NyesteBeliggenhedsadresse(string landekode = default(string), object fritekst = default(object), int? vejkode = default(int?), Kommune3 kommune = default(Kommune3), int? husnummerFra = default(int?), int? husnummerTil = default(int?), object bogstavFra = default(object), object bogstavTil = default(object), object etage = default(object), object sidedoer = default(object), object conavn = default(object), object postboks = default(object), string vejnavn = default(string), object bynavn = default(object), int? postnummer = default(int?), string postdistrikt = default(string), Periode periode = default(Periode), string sidstOpdateret = default(string))
        {
            Landekode = landekode;
            Fritekst = fritekst;
            Vejkode = vejkode;
            Kommune = kommune;
            HusnummerFra = husnummerFra;
            HusnummerTil = husnummerTil;
            BogstavFra = bogstavFra;
            BogstavTil = bogstavTil;
            Etage = etage;
            Sidedoer = sidedoer;
            Conavn = conavn;
            Postboks = postboks;
            Vejnavn = vejnavn;
            Bynavn = bynavn;
            Postnummer = postnummer;
            Postdistrikt = postdistrikt;
            Periode = periode;
            SidstOpdateret = sidstOpdateret;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "landekode")]
        public string Landekode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fritekst")]
        public object Fritekst { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vejkode")]
        public int? Vejkode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kommune")]
        public Kommune3 Kommune { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "husnummerFra")]
        public int? HusnummerFra { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "husnummerTil")]
        public int? HusnummerTil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bogstavFra")]
        public object BogstavFra { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bogstavTil")]
        public object BogstavTil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "etage")]
        public object Etage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sidedoer")]
        public object Sidedoer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conavn")]
        public object Conavn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postboks")]
        public object Postboks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vejnavn")]
        public string Vejnavn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bynavn")]
        public object Bynavn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postnummer")]
        public int? Postnummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postdistrikt")]
        public string Postdistrikt { get; set; }

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
