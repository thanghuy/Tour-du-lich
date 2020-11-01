using Microsoft.Extensions.Configuration;

namespace tour.DataAccess.Internal
{
    public class DataAccess : IDataAccess
    {
        private readonly IConfiguration _configuration;
        public DataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetConn()
        {
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }
    }
}
