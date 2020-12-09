using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace ReadTrial1.Data
{
    public class GenderApparelService : IGenderApparelService
    {
        private readonly HttpClient _client;
        public GenderApparelService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Product>> GetProductByGenderId(int w) 
        {
            var q= await GetAsync("https://localhost:5001/api/ReadValues/api/" + w);
            return q;
        }

        public async Task<string> DeleteById(int id)
        {
            await _client.DeleteAsync("https://localhost:3001/api/CudProduct/" + Convert.ToInt32(id));
            return "OK";
        }

        public async Task<string> PostOrderByProductId(string url,ProductUpdate product)
        {
            await PostAsJsonAsync(url, product);
            return "Created";
        }
       
        
        private static HttpClient GetHttpClient() => new HttpClient(new HttpClientHandler());
        public async Task<List<Product>> GetAsync(string requestUri)
        {
            using var httpClient = GetHttpClient();
            var qwe = await httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<List<Product>>(qwe);
        }
        public async Task<List<StockRead>> GetStockAsync(string requestUri)
        {
            using var httpClient = GetHttpClient();
            var qwe = await httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<List<StockRead>>(qwe);
        }
        public async Task<Product> GetProductAsync(string requestUri)
        
        {
            try
            {
                using var httpClient = GetHttpClient();

                var qwe = await httpClient.GetStringAsync(requestUri);
                return JsonConvert.DeserializeObject<Product>(qwe);
            }
            catch(Exception)
            {
                throw;
            }
        }
        public async Task<HttpResponseMessage> PostAsJsonAsync<T>(string requestUri, T value)
        {
            using var httpClient = GetHttpClient();
            return await httpClient.PostAsJsonAsync(requestUri, value);
        }
        public async Task<List<OrderDetails>> GetCartDetails(string uri)
        {
            return await GetOrderAsync(uri);
            
        }
        public async Task<List<OrderDetails>> GetOrderAsync(string requestUri)
        {
            using var httpClient = GetHttpClient();
            var qwe = await httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<List<OrderDetails>>(qwe);
        }
        public async Task<string> DeleteProductById(int id)
        {
            await _client.DeleteAsync("https://localhost:3001/api/CudApi/" + Convert.ToInt32(id));
            return "OK";
        }


        public async Task UpdateQuantity(string uri, OrderDetailsCud orderDetailsCud)
        {
            using var httpClient = GetHttpClient();
            await httpClient.PutAsJsonAsync(uri, orderDetailsCud);
                
        }
        public async Task UpdateQuantityInStocks(string uri, StockUpdate orderDetailsCud)
        {
            using var httpClient = GetHttpClient();
            await httpClient.PutAsJsonAsync(uri, orderDetailsCud);

        }
        public async Task<OrderDetails> GetOrderByIdAsync(string requestUri)

        {
            try
            {
                using var httpClient = GetHttpClient();

                var qwe = await httpClient.GetStringAsync(requestUri);
                return JsonConvert.DeserializeObject<OrderDetails>(qwe);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<StockRead> GetStockByIdAsync(string requestUri)

        {
            try
            {
                using var httpClient = GetHttpClient();

                var qwe = await httpClient.GetStringAsync(requestUri);
                return JsonConvert.DeserializeObject<StockRead>(qwe);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
