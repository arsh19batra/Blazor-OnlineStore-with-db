using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadApi.Data;
using ReadApi.Services;

namespace ReadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadValuesController : ControllerBase
    {

        private readonly IReadService _readService;
        public List<Product> Products;
        public ReadValuesController(IReadService read)
        {
            _readService = read;
        }

        [HttpGet]
        [Route("product/{id}")]
        public async Task<Product> GetById(int Id)
        {
            var result = await Task.FromResult(_readService.Get<Product>($"Select * from [production].[products] where product_id = {Id}", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet]
        [Route("api/{num}")]
        public async Task<List<Product>> GetAll(int num)
        {
            var result = await Task.FromResult(_readService.GetAll<Product>($"Select * from [production].[products] where gender_id={num}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpGet]
        [Route("api")]
        public async Task<List<Product>> GetAllProducts()
        {
            var result = await Task.FromResult(_readService.GetAll<Product>($"Select * from [production].[products]", null, commandType: CommandType.Text));
            return result;
        }
        [HttpGet]
        [Route("order/{id}")]
        public async Task<Order> GetOrderById(int Id)
        {
            var result = await Task.FromResult(_readService.Get<Order>($"Select * from [sales].[order_items] where order_id = {Id}", null, commandType: CommandType.Text));
            return result;
        }

        [HttpGet]
        [Route("apiorder")]
        public async Task<List<Order>> GetAllOrders()
        {
            var result = await Task.FromResult(_readService.GetAll<Order>($"Select * from [sales].[order_items] ", null, commandType: CommandType.Text));
            return result;
        }
        [HttpGet]
        [Route("stock/{id}")]
        public async Task<Stocks> GetStockById(int Id)
        {
            var result = await Task.FromResult(_readService.Get<Stocks>($"Select * from [production].[stocks] where product_id = {Id}", null, commandType: CommandType.Text));
            return result;
        }
        [HttpGet]
        [Route("stocks")]
        public async Task<List<Stocks>> GetAllStocks()
        {
            var result = await Task.FromResult(_readService.GetAll<Stocks>($"Select * from [production].[stocks] ", null, commandType: CommandType.Text));
            return result;
        }
    }
}

