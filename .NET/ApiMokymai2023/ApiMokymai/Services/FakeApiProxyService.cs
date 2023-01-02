﻿using ApiMokymai.Models.ApiModels;
using Newtonsoft.Json;

namespace ApiMokymai.Services
{
    public class FakeApiProxyService : IFakeApiProxyService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public FakeApiProxyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<BookApiModel>> GetBooks()
        {
            var httpClient = _httpClientFactory.CreateClient("FakeApi");
            //httpClient.DefaultRequestHeaders.Add("api_key", "ljhnkjdfdskxcvbnkjxcbvkcdxsbkvxdsvkbsxdjfnjkxc");
            var endpoint = "api/v1/Books";

            var reponse = await httpClient.GetAsync(endpoint);
            if (reponse.IsSuccessStatusCode)
            {
                var content = await reponse.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<List<BookApiModel>>(content);
                return res;
            }

            return null;
        }

        public async Task<IEnumerable<BookApiModel>> GetBooks_AsString()
        {
            var httpClient = _httpClientFactory.CreateClient("FakeApi");
            var endpoint = "api/v1/Books";

            var content = await httpClient.GetStringAsync(endpoint);
            var res = JsonConvert.DeserializeObject<List<BookApiModel>>(content);
            return res;
        }

        public async Task<IEnumerable<BookApiModel>> GetBooks_AsJson()
        {
            var httpClient = _httpClientFactory.CreateClient("FakeApi");
            var endpoint = "api/v1/Books";
            var res = await httpClient.GetFromJsonAsync<List<BookApiModel>>(endpoint);
            return res;
        }

        public async Task CreateBook(BookApiModel data)
        {
            var httpClient = _httpClientFactory.CreateClient("FakeApi");
            var endpoint = "api/v1/Books";
            var res = await httpClient.PostAsJsonAsync(endpoint, data);
            
        }

    }
}
