using Cud_Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cud_Api.Services
{
    public interface ICudService
    {
        bool SaveChanges();
        Task<ActionResult<IEnumerable<OrderItem>>> GetAllOrder();
        Task<ActionResult<OrderItem>> GetDetailById(int id);
        ActionResult<OrderItem> CreateDetail(Product product, int quantity);
        void UpdateDetail(OrderItem dtl);
        void DeleteDetail(OrderItem dtl);
        void UpdateQuantityInOrder(int id, OrderItem orderItem);
        OrderItem GetFor(int id);
        public bool OrderExists(int id); 
    }
}