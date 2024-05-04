using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://localhost:5001/"); // Sesuaikan dengan URL API Anda
    }

    public async Task<string> GetKos()
    {
        HttpResponseMessage response = await _httpClient.GetAsync("api/Kos");
        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        else
        {
            Console.WriteLine("Failed to get Kos");
            return null;
        }
    }
}
