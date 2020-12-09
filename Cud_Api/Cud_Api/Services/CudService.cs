using AutoMapper;
using Cud_Api.Data;
using Cud_Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cud_Api.Services
{
    public class CudService: ICudService
    {
        private readonly online_storeContext _context;
        //private readonly IMapper _mapper;
        public CudService(online_storeContext context)
        {
            _context = context;
            //_mapper = mapper;
        }

        public ActionResult<OrderItem> CreateDetail(Product product, int quantity)
        {          
            OrderItem qwe = new OrderItem
            {
                ProductId = product.ProductId,
                ListPrice = product.ListPrice,
                Quantity = quantity
            };
            _context.OrderItems.Add(qwe);
            _context.SaveChanges();
            return _context.OrderItems.Find(qwe.OrderId);
        }
        public OrderItem GetFor(int id)
        {
            return _context.OrderItems.Find(id);
        }
        public Product GetProductFor(int id)
        {
            return _context.Products.Find(id);
        }
        public void DeleteDetail(OrderItem dtl)
        {
            if (dtl == null)
            {
                throw new ArgumentNullException(nameof(dtl));
            }
            _context.OrderItems.Remove(dtl);
            _context.SaveChanges();
        }

        public async Task<ActionResult<IEnumerable<OrderItem>>> GetAllOrder()
        {
            return await _context.OrderItems.ToListAsync();
        }

        public async Task<ActionResult<OrderItem>> GetDetailById(int id)
        {
            var order = await _context.OrderItems.FindAsync(id);

            return order;
        }

        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var order = await _context.Products.FindAsync(id);

            return order;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateDetail( OrderItem dtl)
        {
            
            _context.Entry(dtl).State = EntityState.Modified;
            //_context.SaveChanges();
            //_context.Entry(dtl).State = EntityState.Modified;
            //    _context.SaveChangesAsync();
        }
        public bool OrderExists(int id)
        {
            var order = _context.OrderItems.Find(id);
            if(order==null)
            {
                return false;
            }
            return true;
        }

        public void UpdateQuantityInOrder(int id, OrderItem orderItem)
        {
            var order = _context.OrderItems.Find(id);
            order.Quantity = orderItem.Quantity;
        }
    }
}
