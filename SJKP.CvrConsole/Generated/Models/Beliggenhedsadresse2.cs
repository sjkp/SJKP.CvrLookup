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

    public partial class Beliggenhedsadresse2
    {
        /// <summary>
        /// Initializes a new instance of the Beliggenhedsadresse2 class.
        /// </summary>
        public Beliggenhedsadresse2() { }

        /// <summary>
        /// Initializes a new instance of the Beliggenhedsadresse2 class.
        /// </summary>
        public Beliggenhedsadresse2(string landekode = default(string), object fritekst = default(object), int? vejkode = default(int?), Kommune2 kommune = default(Kommune2), string husnummerFra = default(string), string husnummerTil = default(string), string bogstavFra = default(string), object bogstavTil = default(object), string etage = default(string), string sidedoer = default(string), string conavn = default(string), object postboks = default(object), string vejnavn = default(string), string bynavn = default(string), int? postnummer = default(int?), string postdistrikt = default(string), Periode periode = default(Periode), string sidstOpdateret = default(string))
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
        public Kommune2 Kommune { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "husnummerFra")]
        public string HusnummerFra { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "husnummerTil")]
        public string HusnummerTil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bogstavFra")]
        public string BogstavFra { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bogstavTil")]
        public object BogstavTil { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "etage")]
        public string Etage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sidedoer")]
        public string Sidedoer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conavn")]
        public string Conavn { get; set; }

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
        public string Bynavn { get; set; }

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
