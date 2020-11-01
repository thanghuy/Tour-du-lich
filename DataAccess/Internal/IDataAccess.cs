using Microsoft.Extensions.Configuration;

namespace tour.DataAccess.Internal
{
    public interface IDataAccess
    {
        public string GetConn();
    }
}
