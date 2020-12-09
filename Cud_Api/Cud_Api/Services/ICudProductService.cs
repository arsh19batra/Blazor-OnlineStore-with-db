using Cud_Api.Data;
using System.Collections.Generic;

namespace Cud_Api.Services
{
    public interface ICudProductService
    {
        bool SaveChanges();
        void CreateDetail(Product dtl);
        void UpdateDetail(int id,Product dtl);
        void DeleteDetail(int  dtl);
        
    }
}