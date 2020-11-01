using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.DataAccess.SqlAccess;
using tour.Models.DTOs;

namespace tour.Services
{
    public class DoanService
    {
        private readonly IDoanAccess _doanAccess;
        public List<DoanDTO> GetAll()
        {
            List<DoanDTO> list = _doanAccess.GetAll();
            return list;
        }
    }
}
