using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReadTrial1.Data
{
    public interface IGenderApparelService
    {
        Task<List<Product>> GetProductByGenderId(int w);
        Task<string> DeleteById(int id);
        Task<string> PostOrderByProductId(string url, ProductUpdate product);
        Task<HttpResponseMessage> PostAsJsonAsync<T>(string requestUri, T value);
        Task<List<Product>> GetAsync(string requestUri);
        Task<Product> GetProductAsync(string requestUri);
        Task<string> DeleteProductById(int id);
        Task<List<OrderDetails>> GetCartDetails(string uri);
        Task UpdateQuantity(string uri, OrderDetailsCud orderDetailsCud);
        Task<OrderDetails> GetOrderByIdAsync(string requestUri);
        Task<List<StockRead>> GetStockAsync(string requestUri);
        Task<StockRead> GetStockByIdAsync(string requestUri);
        Task UpdateQuantityInStocks(string uri, StockUpdate orderDetailsCud);
    }
}
