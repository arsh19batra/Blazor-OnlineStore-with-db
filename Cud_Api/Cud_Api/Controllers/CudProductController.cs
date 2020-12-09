using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cud_Api.Data;
using Cud_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CudProductController : ControllerBase
    {
        private readonly ICudProductService _cudProduct;
        public CudProductController(ICudProductService cudProduct)
        {
            _cudProduct = cudProduct;
        }
        /*[HttpPost("{quantity}")]
        public ActionResult<Product> CreateProduct(Product product,int quantity)
        {
            _cudProduct.CreateDetail(product);
            _cudProduct.CreateStock(product.ProductId, quantity);
            _cudProduct.SaveChanges();
            return Ok(product);
        }*/
        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            _cudProduct.CreateDetail(product);
            
            _cudProduct.SaveChanges();
            return Ok(product);
        }
        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, Product dl)
        {
            
            _cudProduct.UpdateDetail(id,dl);
            _cudProduct.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteDetail(int id)
        {
            _cudProduct.DeleteDetail(id);
            
            return NoContent();
        }
    }
}
