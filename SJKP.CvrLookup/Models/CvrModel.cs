using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SJKP.CvrLookup.Models
{

    public class Shards
    {
        public int total { get; set; }
        public int successful { get; set; }
        public int failed { get; set; }
    }

    public class Periode
    {
        public string gyldigFra { get; set; }
        public string gyldigTil { get; set; }
    }

    public class Navne
    {
        public string navn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }


    public class Kommune
    {
        public int kommuneKode { get; set; }
        public string kommuneNavn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }



    public class Beliggenhedsadresse
    {
        public string landekode { get; set; }
        public object fritekst { get; set; }
        public int vejkode { get; set; }
        public Kommune kommune { get; set; }
        public int husnummerFra { get; set; }
        public int? husnummerTil { get; set; }
        public object bogstavFra { get; set; }
        public object bogstavTil { get; set; }
        public string etage { get; set; }
        public object sidedoer { get; set; }
        public object conavn { get; set; }
        public object postboks { get; set; }
        public string vejnavn { get; set; }
        public object bynavn { get; set; }
        public int postnummer { get; set; }
        public string postdistrikt { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }


    public class TelefonNummer
    {
        public string kontaktoplysning { get; set; }
        public bool hemmelig { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }


    public class Livsforloeb
    {
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Hovedbranche
    {
        public string branchekode { get; set; }
        public string branchetekst { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Virksomhedsstatu
    {
        public string status { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }


    public class Virksomhedsform
    {
        public int virksomhedsformkode { get; set; }
        public string kortBeskrivelse { get; set; }
        public string langBeskrivelse { get; set; }
        public string ansvarligDataleverandoer { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Aarsbeskaeftigelse
    {
        public int aar { get; set; }
        public object antalInklusivEjere { get; set; }
        public object antalAarsvaerk { get; set; }
        public object antalAnsatte { get; set; }
        public string sidstOpdateret { get; set; }
        public string intervalKodeAntalInklusivEjere { get; set; }
        public string intervalKodeAntalAarsvaerk { get; set; }
        public string intervalKodeAntalAnsatte { get; set; }
    }

    public class Kvartalsbeskaeftigelse
    {
        public int aar { get; set; }
        public int kvartal { get; set; }
        public object antalAarsvaerk { get; set; }
        public object antalAnsatte { get; set; }
        public string sidstOpdateret { get; set; }
        public string intervalKodeAntalAarsvaerk { get; set; }
        public string intervalKodeAntalAnsatte { get; set; }
    }

    public class Maanedsbeskaeftigelse
    {
        public int aar { get; set; }
        public int maaned { get; set; }
        public object antalAarsvaerk { get; set; }
        public object antalAnsatte { get; set; }
        public string sidstOpdateret { get; set; }
        public string intervalKodeAntalAarsvaerk { get; set; }
        public string intervalKodeAntalAnsatte { get; set; }
    }



    public class Vaerdier
    {
        public string vaerdi { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Attributter
    {
        public int sekvensnr { get; set; }
        public string type { get; set; }
        public string vaerditype { get; set; }
        public List<Vaerdier> vaerdier { get; set; }
    }

    public class Penheder
    {
        public int pNummer { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Navne2
    {
        public string navn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }


    public class Kommune2
    {
        public int kommuneKode { get; set; }
        public string kommuneNavn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Beliggenhedsadresse2
    {
        public string landekode { get; set; }
        public object fritekst { get; set; }
        public int vejkode { get; set; }
        public Kommune2 kommune { get; set; }
        public int? husnummerFra { get; set; }
        public int? husnummerTil { get; set; }
        public string bogstavFra { get; set; }
        public object bogstavTil { get; set; }
        public string etage { get; set; }
        public string sidedoer { get; set; }
        public string conavn { get; set; }
        public object postboks { get; set; }
        public string vejnavn { get; set; }
        public string bynavn { get; set; }
        public int postnummer { get; set; }
        public string postdistrikt { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Deltager
    {
        public object enhedsNummer { get; set; }
        public string enhedstype { get; set; }
        public int? forretningsnoegle { get; set; }
        public object organisationstype { get; set; }
        public string sidstIndlaest { get; set; }
        public List<Navne2> navne { get; set; }
        public List<Beliggenhedsadresse2> beliggenhedsadresse { get; set; }
    }

    public class OrganisationsNavn
    {
        public string navn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Vaerdier2
    {
        public string vaerdi { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Attributter2
    {
        public int sekvensnr { get; set; }
        public string type { get; set; }
        public string vaerditype { get; set; }
        public List<Vaerdier2> vaerdier { get; set; }
    }


    public class Vaerdier3
    {
        public string vaerdi { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Attributter3
    {
        public int sekvensnr { get; set; }
        public string type { get; set; }
        public string vaerditype { get; set; }
        public List<Vaerdier3> vaerdier { get; set; }
    }

    public class MedlemsData
    {
        public List<Attributter3> attributter { get; set; }
    }

    public class Organisationer
    {
        public object enhedsNummerOrganisation { get; set; }
        public string hovedtype { get; set; }
        public List<OrganisationsNavn> organisationsNavn { get; set; }
        public List<Attributter2> attributter { get; set; }
        public List<MedlemsData> medlemsData { get; set; }
    }

    public class DeltagerRelation
    {
        public Deltager deltager { get; set; }
        public List<object> kontorsteder { get; set; }
        public List<Organisationer> organisationer { get; set; }
    }

    public class NyesteNavn
    {
        public string navn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class NyesteVirksomhedsform
    {
        public int virksomhedsformkode { get; set; }
        public string kortBeskrivelse { get; set; }
        public string langBeskrivelse { get; set; }
        public string ansvarligDataleverandoer { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class Kommune3
    {
        public int kommuneKode { get; set; }
        public string kommuneNavn { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class NyesteBeliggenhedsadresse
    {
        public string landekode { get; set; }
        public object fritekst { get; set; }
        public int vejkode { get; set; }
        public Kommune3 kommune { get; set; }
        public int husnummerFra { get; set; }
        public int husnummerTil { get; set; }
        public object bogstavFra { get; set; }
        public object bogstavTil { get; set; }
        public object etage { get; set; }
        public object sidedoer { get; set; }
        public object conavn { get; set; }
        public object postboks { get; set; }
        public string vejnavn { get; set; }
        public object bynavn { get; set; }
        public int postnummer { get; set; }
        public string postdistrikt { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class NyesteHovedbranche
    {
        public string branchekode { get; set; }
        public string branchetekst { get; set; }
        public Periode periode { get; set; }
        public string sidstOpdateret { get; set; }
    }

    public class NyesteAarsbeskaeftigelse
    {
        public int aar { get; set; }
        public object antalInklusivEjere { get; set; }
        public object antalAarsvaerk { get; set; }
        public object antalAnsatte { get; set; }
        public string sidstOpdateret { get; set; }
        public string intervalKodeAntalInklusivEjere { get; set; }
        public string intervalKodeAntalAarsvaerk { get; set; }
        public string intervalKodeAntalAnsatte { get; set; }
    }

    public class NyesteKvartalsbeskaeftigelse
    {
        public int aar { get; set; }
        public int kvartal { get; set; }
        public object antalAarsvaerk { get; set; }
        public object antalAnsatte { get; set; }
        public string sidstOpdateret { get; set; }
        public string intervalKodeAntalAarsvaerk { get; set; }
        public string intervalKodeAntalAnsatte { get; set; }
    }

    public class NyesteMaanedsbeskaeftigelse
    {
        public int aar { get; set; }
        public int maaned { get; set; }
        public object antalAarsvaerk { get; set; }
        public object antalAnsatte { get; set; }
        public string sidstOpdateret { get; set; }
        public string intervalKodeAntalAarsvaerk { get; set; }
        public string intervalKodeAntalAnsatte { get; set; }
    }

    public class VirksomhedMetadata
    {
        public NyesteNavn nyesteNavn { get; set; }
        public NyesteVirksomhedsform nyesteVirksomhedsform { get; set; }
        public NyesteBeliggenhedsadresse nyesteBeliggenhedsadresse { get; set; }
        public NyesteHovedbranche nyesteHovedbranche { get; set; }
        public object nyesteBibranche1 { get; set; }
        public object nyesteBibranche2 { get; set; }
        public object nyesteBibranche3 { get; set; }
        public object nyesteStatus { get; set; }
        public List<string> nyesteKontaktoplysninger { get; set; }
        public List<object> nyesteFadCprnumre { get; set; }
        public int antalPenheder { get; set; }
        public NyesteAarsbeskaeftigelse nyesteAarsbeskaeftigelse { get; set; }
        public NyesteKvartalsbeskaeftigelse nyesteKvartalsbeskaeftigelse { get; set; }
        public NyesteMaanedsbeskaeftigelse nyesteMaanedsbeskaeftigelse { get; set; }
        public string sammensatStatus { get; set; }
        public string stiftelsesDato { get; set; }
        public string virkningsDato { get; set; }
    }

    public class Vrvirksomhed
    {
        public int cvrNummer { get; set; }
        public List<object> regNummer { get; set; }
        public object brancheAnsvarskode { get; set; }
        public bool reklamebeskyttet { get; set; }
        public List<Navne> navne { get; set; }
        public List<object> binavne { get; set; }
        public List<object> postadresse { get; set; }
        public List<Beliggenhedsadresse> beliggenhedsadresse { get; set; }
        public List<TelefonNummer> telefonNummer { get; set; }
        public List<object> telefaxNummer { get; set; }
        public List<object> elektroniskPost { get; set; }
        public List<object> hjemmeside { get; set; }
        public List<object> obligatoriskEmail { get; set; }
        public List<Livsforloeb> livsforloeb { get; set; }
        public List<Hovedbranche> hovedbranche { get; set; }
        public List<object> bibranche1 { get; set; }
        public List<object> bibranche2 { get; set; }
        public List<object> bibranche3 { get; set; }
        public List<object> status { get; set; }
        public List<Virksomhedsstatu> virksomhedsstatus { get; set; }
        public List<Virksomhedsform> virksomhedsform { get; set; }
        public List<Aarsbeskaeftigelse> aarsbeskaeftigelse { get; set; }
        public List<Kvartalsbeskaeftigelse> kvartalsbeskaeftigelse { get; set; }
        public List<Maanedsbeskaeftigelse> maanedsbeskaeftigelse { get; set; }
        public List<Attributter> attributter { get; set; }
        public List<Penheder> penheder { get; set; }
        public List<DeltagerRelation> deltagerRelation { get; set; }
        public List<object> fusioner { get; set; }
        public List<object> spaltninger { get; set; }
        public VirksomhedMetadata virksomhedMetadata { get; set; }
        public int samtId { get; set; }
        public bool fejlRegistreret { get; set; }
        public int dataAdgang { get; set; }
        public long enhedsNummer { get; set; }
        public string enhedstype { get; set; }
        public string sidstIndlaest { get; set; }
        public string sidstOpdateret { get; set; }
        public bool fejlVedIndlaesning { get; set; }
        public object naermesteFremtidigeDato { get; set; }
        public object fejlBeskrivelse { get; set; }
    }

    public class Source
    {
        public Vrvirksomhed Vrvirksomhed { get; set; }
    }

    public class Hit
    {
        public string _index { get; set; }
        public string _type { get; set; }
        public string _id { get; set; }
        public double _score { get; set; }
        public Source _source { get; set; }
    }

    public class Hits
    {
        public int total { get; set; }
        public double max_score { get; set; }
        public List<Hit> hits { get; set; }
    }

    public class CvrResult
    {
        public int took { get; set; }
        public bool timed_out { get; set; }
        public Shards _shards { get; set; }
        public Hits hits { get; set; }
    }
}