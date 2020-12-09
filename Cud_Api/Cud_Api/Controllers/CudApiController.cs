using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cud_Api.Data;
using Cud_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CudApiController : ControllerBase
    {
        private readonly ICudService _cudService;
        
        
        public CudApiController(ICudService cudService)
        {
            _cudService = cudService;
                        
        }
       // [HttpGet]
       //
       // public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrders()
       // {
       //     return await _cudService.GetAllOrder();
       // }
       //
       // [HttpGet("{id}")]
       // public async Task<ActionResult<OrderItem>> GetOrderById(int id)
       // {
       //     return await _cudService.GetDetailById(id);
       // }
        [HttpPost("{quantity}")]
        public ActionResult<OrderItem> CreateDetail(int quantity,Product product)
        {
             var qwe= _cudService.CreateDetail(product, quantity);
            return Ok(qwe);
        }

       //[HttpPatch("{id}")]
       //public ActionResult PartialDetailUpdate(int id, JsonPatchDocument<OrderItem> patchDoc)
       //{
       //    var detailModelFromRepo = _cudService.GetFor(id);
       //    if (detailModelFromRepo == null)
       //    {
       //        return NotFound();
       //    }
       //    
       //    patchDoc.ApplyTo(detailModelFromRepo, ModelState);
       //    if (!TryValidateModel(detailModelFromRepo))
       //    {
       //        return ValidationProblem(ModelState);
       //    }
       //    //_mapper.Map(detailToPatch, detailModelFromRepo);
       //    _cudService.UpdateDetail(detailModelFromRepo);
       //    _cudService.SaveChanges();
       //
       //    return NoContent();
       //}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            
            _cudService.DeleteDetail(_cudService.GetFor(id));
            return NoContent();

        }
        [HttpPut("{id}")]
        public ActionResult PutQuantity(int id,OrderItem order)
        {
            if(!_cudService.OrderExists(id))
            {
                return BadRequest();
            }
            _cudService.UpdateQuantityInOrder(id, order);
            _cudService.SaveChanges();
            return Ok();
        }

    }
}
