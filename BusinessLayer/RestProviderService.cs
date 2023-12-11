using WebAPIDapperDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RestProviderService
    {
        HttpClient client = null;

        public RestProviderService()
        {
            client = new HttpClient();
        }


        public string Get(string url)
        {
            try
            {
                var responseTask = client.GetAsync(url);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    };

                    var resultJSONString = result.Content.ReadAsStringAsync().Result;
                    var finalreult = JsonSerializer.Deserialize<List<TicketModelSP>>(resultJSONString, options);
                    return resultJSONString;


                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}

