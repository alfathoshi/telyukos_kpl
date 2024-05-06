using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace telyukos_library.apiLib
{
    public  class apiLibraries
    {
        private readonly HttpClient _httpClient;

        public apiLibraries(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<T[]> GetAsync<T>(string apiUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            T[] result = await response.Content.ReadFromJsonAsync<T[]>();
            return result;
        }
    }
}
