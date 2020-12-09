using Cud_Api.Data;

namespace Cud_Api.Services
{
    public interface ICudStockService
    {
        bool SaveChanges();
        void CreateDetail(Stock dtl);
        void UpdateDetail(int id, Stock dtl);
        void DeleteDetail(int dtl);
    }
}