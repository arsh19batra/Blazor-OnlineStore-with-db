using Cud_Api.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cud_Api.Services
{
    public class CudProductService: ICudProductService
    {
        private readonly online_storeContext _context;
        public CudProductService(online_storeContext context)
        {
            _context = context;
        }

        public void CreateDetail(Product dtl)
        {
            if (dtl == null)
            {
                throw new ArgumentNullException(nameof(dtl));
            }
            _context.Products.Add(dtl);
        }

        public void DeleteDetail(int id)
        {
            var dtl=_context.Products.Find(id);
            _context.Products.Remove(dtl);
            _context.SaveChanges();
        }   

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateDetail(int id,Product dtl)
        {
            var prodToUpdate =_context.Products.Find(id);
            //_context.Entry(dtl).State = EntityState.Modified;
            prodToUpdate.CategoryId = dtl.CategoryId;
            prodToUpdate.GenderId = dtl.GenderId;
            prodToUpdate.ProductName = dtl.ProductName;
            prodToUpdate.ListPrice = dtl.ListPrice;
            
        }
        
    }
}
