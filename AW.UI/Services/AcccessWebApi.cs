using Newtonsoft.Json;
using AW.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AW.UI.Services
{
    public class AcccessWebApi : IAcccessWebApi
    {
        public async Task<IEnumerable<T>> GetAsync<T>(string link)
        {
            IEnumerable<T> result = null;

            using (var httpClient = new HttpClient())
            {
                string jsonResult = string.Empty;

                httpClient.BaseAddress = new Uri(Constants.baseLink);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add(Constants.customHeaderKey, Base64Helper.Base64Encode(Constants.customHeaderValue));

                HttpResponseMessage response = await httpClient.GetAsync(link);

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    jsonResult = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<IEnumerable<T>>(jsonResult);
                }
            }


            return result;
        }

        public async Task PostAsync<T>(string link, T model)
        {
            using (var httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri(Constants.baseLink);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add(Constants.customHeaderKey, Base64Helper.Base64Encode(Constants.customHeaderValue));

                HttpResponseMessage response = await httpClient.PostAsJsonAsync(link, model);

                response.EnsureSuccessStatusCode();
            }
        }
    }
}