using System.Collections.Generic;
using tour.DataAccess.SqlAccess;
using tour.Models.DTOs;

namespace tour.Services.Doan
{
    public class DoanService : IDoanService
    {
        private readonly IDoanAccess _doanAccess;

        public DoanService(IDoanAccess doanAccess)
        {
            _doanAccess = doanAccess;
        }
        public List<DoanDTO> GetAll()
        {
            List<DoanDTO> list = _doanAccess.GetAll();
            return list;
        }
    }
}
