using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJKP.CvrConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SJKP.CvrClient.SJKPCvrLookup();
            
            var res = client.Cvr.SearchByPostbodyWithHttpMessagesAsync(new CvrClient.Models.SearchQuery()
            {
                SearchTerm = "Delegate"
            }).Result;

            Console.WriteLine(res.Body.Hits.HitsProperty[0].LowLinesource.Vrvirksomhed.Navne.First().Navn);
            Console.ReadKey();
        }
    }
}
