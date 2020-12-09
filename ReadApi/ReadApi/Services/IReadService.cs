using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ReadApi.Services
{
    public interface IReadService:IDisposable
    {
        //DbConnection GetDbconnection();
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        //int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }
}
