using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.LoaiChiPhi
{
    public class LoaiChiPhiRepository : Repository,ILoaiChiPhiRepo
    {
        public LoaiChiPhiRepository(Tour_DBContext context) : base(context)
        {
        }

        public async Task<bool> AddAsync(LoaiChiPhis l)
        {
            _ = _context.LoaiChiPhis.Add(l);
            return await _context.SaveChangesAsync()!=0;
        }

        public IEnumerable<LoaiChiPhis> GetAll()
        {
            return _context.LoaiChiPhis.AsEnumerable();
        }
    }
}
