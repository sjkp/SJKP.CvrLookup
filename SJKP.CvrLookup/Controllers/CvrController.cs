using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SJKP.CvrLookup.Controllers
{
    public class CvrController : ApiController
    {
        public async Task<IHttpActionResult> Get(string id)
        {
            var handler = new HttpClientHandler();

            handler.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["cvrUsername"], ConfigurationManager.AppSettings["cvrPassword"]);

            HttpClient client = new HttpClient(handler);
            var body = string.Format(@"{{ ""from"" : 0, ""size"" : 1,
  ""query"": {{
                ""term"": {{
                    ""cvrNummer"": {0}
                }}
            }}
        }}", id);
            var res = await client.PostAsync("http://distribution.virk.dk/cvr-permanent/_search", new StringContent(body));
            return Ok(JsonConvert.DeserializeObject(await res.Content.ReadAsStringAsync()));
        }

        [HttpPost]
        public async Task<IHttpActionResult> Search(SearchQuery postbody)
        {
            var handler = new HttpClientHandler();

            handler.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["cvrUsername"], ConfigurationManager.AppSettings["cvrPassword"]);

            HttpClient client = new HttpClient(handler);
            var body = string.Format(@"{{ ""from"" : 0, ""size"" : 15,
  ""query"": {{
                ""match"": {{
                    ""Vrvirksomhed.navne.navn"": """ + postbody.SearchTerm + @"""
                }}
            }}
        }}");
            var res = await client.PostAsync("http://distribution.virk.dk/cvr-permanent/_search", new StringContent(body));
            return Ok(JsonConvert.DeserializeObject(await res.Content.ReadAsStringAsync()));
        }
    }
}
