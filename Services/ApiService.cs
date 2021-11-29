using Countries.Models;
using Countries.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Services
{
    public class ApiService
    {

        /// <summary>
        /// Recebe o caminho da API: https://restcountries.com/v3.1/all
        /// </summary>
        /// <param name="urlBase"></param>
        /// <param name="controller"></param>
        /// <returns></returns>
        public async Task<Response> GetCountries(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var response = await client.GetAsync(controller);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var countries = JsonConvert.DeserializeObject<List<Country>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = countries,
                };

            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
