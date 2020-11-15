using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.LoaiChiPhi
{
    public interface ILoaiChiPhiRepo
    {
        public Task<bool> AddAsync(LoaiChiPhis l);
        IEnumerable<LoaiChiPhis> GetAll();
    }
}
