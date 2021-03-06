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

    public partial class Vrvirksomhed
    {
        /// <summary>
        /// Initializes a new instance of the Vrvirksomhed class.
        /// </summary>
        public Vrvirksomhed() { }

        /// <summary>
        /// Initializes a new instance of the Vrvirksomhed class.
        /// </summary>
        public Vrvirksomhed(int? cvrNummer = default(int?), IList<object> regNummer = default(IList<object>), object brancheAnsvarskode = default(object), bool? reklamebeskyttet = default(bool?), IList<Navne> navne = default(IList<Navne>), IList<object> binavne = default(IList<object>), IList<object> postadresse = default(IList<object>), IList<Beliggenhedsadresse> beliggenhedsadresse = default(IList<Beliggenhedsadresse>), IList<TelefonNummer> telefonNummer = default(IList<TelefonNummer>), IList<object> telefaxNummer = default(IList<object>), IList<object> elektroniskPost = default(IList<object>), IList<object> hjemmeside = default(IList<object>), IList<object> obligatoriskEmail = default(IList<object>), IList<Livsforloeb> livsforloeb = default(IList<Livsforloeb>), IList<Hovedbranche> hovedbranche = default(IList<Hovedbranche>), IList<object> bibranche1 = default(IList<object>), IList<object> bibranche2 = default(IList<object>), IList<object> bibranche3 = default(IList<object>), IList<object> status = default(IList<object>), IList<Virksomhedsstatu> virksomhedsstatus = default(IList<Virksomhedsstatu>), IList<Virksomhedsform> virksomhedsform = default(IList<Virksomhedsform>), IList<Aarsbeskaeftigelse> aarsbeskaeftigelse = default(IList<Aarsbeskaeftigelse>), IList<Kvartalsbeskaeftigelse> kvartalsbeskaeftigelse = default(IList<Kvartalsbeskaeftigelse>), IList<Maanedsbeskaeftigelse> maanedsbeskaeftigelse = default(IList<Maanedsbeskaeftigelse>), IList<Attributter> attributter = default(IList<Attributter>), IList<Penheder> penheder = default(IList<Penheder>), IList<DeltagerRelation> deltagerRelation = default(IList<DeltagerRelation>), IList<object> fusioner = default(IList<object>), IList<object> spaltninger = default(IList<object>), VirksomhedMetadata virksomhedMetadata = default(VirksomhedMetadata), int? samtId = default(int?), bool? fejlRegistreret = default(bool?), int? dataAdgang = default(int?), long? enhedsNummer = default(long?), string enhedstype = default(string), string sidstIndlaest = default(string), string sidstOpdateret = default(string), bool? fejlVedIndlaesning = default(bool?), object naermesteFremtidigeDato = default(object), object fejlBeskrivelse = default(object))
        {
            CvrNummer = cvrNummer;
            RegNummer = regNummer;
            BrancheAnsvarskode = brancheAnsvarskode;
            Reklamebeskyttet = reklamebeskyttet;
            Navne = navne;
            Binavne = binavne;
            Postadresse = postadresse;
            Beliggenhedsadresse = beliggenhedsadresse;
            TelefonNummer = telefonNummer;
            TelefaxNummer = telefaxNummer;
            ElektroniskPost = elektroniskPost;
            Hjemmeside = hjemmeside;
            ObligatoriskEmail = obligatoriskEmail;
            Livsforloeb = livsforloeb;
            Hovedbranche = hovedbranche;
            Bibranche1 = bibranche1;
            Bibranche2 = bibranche2;
            Bibranche3 = bibranche3;
            Status = status;
            Virksomhedsstatus = virksomhedsstatus;
            Virksomhedsform = virksomhedsform;
            Aarsbeskaeftigelse = aarsbeskaeftigelse;
            Kvartalsbeskaeftigelse = kvartalsbeskaeftigelse;
            Maanedsbeskaeftigelse = maanedsbeskaeftigelse;
            Attributter = attributter;
            Penheder = penheder;
            DeltagerRelation = deltagerRelation;
            Fusioner = fusioner;
            Spaltninger = spaltninger;
            VirksomhedMetadata = virksomhedMetadata;
            SamtId = samtId;
            FejlRegistreret = fejlRegistreret;
            DataAdgang = dataAdgang;
            EnhedsNummer = enhedsNummer;
            Enhedstype = enhedstype;
            SidstIndlaest = sidstIndlaest;
            SidstOpdateret = sidstOpdateret;
            FejlVedIndlaesning = fejlVedIndlaesning;
            NaermesteFremtidigeDato = naermesteFremtidigeDato;
            FejlBeskrivelse = fejlBeskrivelse;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cvrNummer")]
        public int? CvrNummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regNummer")]
        public IList<object> RegNummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "brancheAnsvarskode")]
        public object BrancheAnsvarskode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reklamebeskyttet")]
        public bool? Reklamebeskyttet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navne")]
        public IList<Navne> Navne { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "binavne")]
        public IList<object> Binavne { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postadresse")]
        public IList<object> Postadresse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "beliggenhedsadresse")]
        public IList<Beliggenhedsadresse> Beliggenhedsadresse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telefonNummer")]
        public IList<TelefonNummer> TelefonNummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "telefaxNummer")]
        public IList<object> TelefaxNummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "elektroniskPost")]
        public IList<object> ElektroniskPost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hjemmeside")]
        public IList<object> Hjemmeside { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "obligatoriskEmail")]
        public IList<object> ObligatoriskEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "livsforloeb")]
        public IList<Livsforloeb> Livsforloeb { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hovedbranche")]
        public IList<Hovedbranche> Hovedbranche { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bibranche1")]
        public IList<object> Bibranche1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bibranche2")]
        public IList<object> Bibranche2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bibranche3")]
        public IList<object> Bibranche3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public IList<object> Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virksomhedsstatus")]
        public IList<Virksomhedsstatu> Virksomhedsstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virksomhedsform")]
        public IList<Virksomhedsform> Virksomhedsform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "aarsbeskaeftigelse")]
        public IList<Aarsbeskaeftigelse> Aarsbeskaeftigelse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kvartalsbeskaeftigelse")]
        public IList<Kvartalsbeskaeftigelse> Kvartalsbeskaeftigelse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maanedsbeskaeftigelse")]
        public IList<Maanedsbeskaeftigelse> Maanedsbeskaeftigelse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributter")]
        public IList<Attributter> Attributter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "penheder")]
        public IList<Penheder> Penheder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deltagerRelation")]
        public IList<DeltagerRelation> DeltagerRelation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fusioner")]
        public IList<object> Fusioner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spaltninger")]
        public IList<object> Spaltninger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virksomhedMetadata")]
        public VirksomhedMetadata VirksomhedMetadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "samtId")]
        public int? SamtId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fejlRegistreret")]
        public bool? FejlRegistreret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataAdgang")]
        public int? DataAdgang { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enhedsNummer")]
        public long? EnhedsNummer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enhedstype")]
        public string Enhedstype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sidstIndlaest")]
        public string SidstIndlaest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sidstOpdateret")]
        public string SidstOpdateret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fejlVedIndlaesning")]
        public bool? FejlVedIndlaesning { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "naermesteFremtidigeDato")]
        public object NaermesteFremtidigeDato { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fejlBeskrivelse")]
        public object FejlBeskrivelse { get; set; }

    }
}
