using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cud_Api.Services;
using Cud_Api.Data;

namespace Cud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CudStockController : ControllerBase
    {
        private readonly ICudStockService _cudStockService;
        public CudStockController(ICudStockService cudStockService)
        {
            _cudStockService = cudStockService;
        }
        [HttpPost]
        public ActionResult<Stock> CreateProduct(Stock stock)
        {
            _cudStockService.CreateDetail(stock);
            _cudStockService.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, Stock dl)
        {
            _cudStockService.UpdateDetail(id,dl);
            _cudStockService.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteDetail(int id)
        {
            _cudStockService.DeleteDetail(id);

            return NoContent();
        }
    }
}
