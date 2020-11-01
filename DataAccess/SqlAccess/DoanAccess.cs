using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using tour.DataAccess.Internal;
using tour.Models.DTOs;

namespace tour.DataAccess.SqlAccess
{
    public class DoanAccess : IDoanAccess
    {
        private readonly IDataAccess _dataAccess;
        public DoanAccess(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<DoanDTO> GetAll()
        {
            string connectionString = _dataAccess.GetConn();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM DOAN";
                List<DoanDTO> list = connection.Query<DoanDTO>(sql).ToList();
                return list;
            }
        }
    }
}
