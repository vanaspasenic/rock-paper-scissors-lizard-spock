using Game.Interfaces;
using Game.Models;

namespace Game.Services
{
    public class HelperApisService : IHelperApisService
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;
        public HelperApisService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _endpoint = config["RandomNumber:Endpoint"];
        }

        public async Task<int> GetRandomIndexAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<RandomNumberModel>(_endpoint);
            return response.random_number;
        }
    }
}
