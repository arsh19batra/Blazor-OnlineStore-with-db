using Cud_Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cud_Api.Services
{
    public class CudStockService : ICudStockService
    {
        private readonly online_storeContext _context;
        public CudStockService(online_storeContext context)
        {
            _context = context;
        }
        public void CreateDetail(Stock dtl)
        {
            if (dtl == null)
            {
                throw new ArgumentNullException(nameof(dtl));
            }
            _context.Stocks.Add(dtl);
        }

        public void DeleteDetail(int id)
        {
            var dtl = _context.Stocks.Find(id);
            _context.Stocks.Remove(dtl);
            _context.SaveChanges();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateDetail(int id, Stock dtl)
        {
            var quantityToUpdate = _context.Stocks.Find(id);
            //_context.Entry(dtl).State = EntityState.Modified;
            quantityToUpdate.Quantity = dtl.Quantity;
        }
    }
}
