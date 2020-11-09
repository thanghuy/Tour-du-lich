using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.ChiTiet
{
    public class ChiTietRepository : Repository, IChiTietRepo
    {
        public ChiTietRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(ChiTietTours chiTietTours)
        {
            _ = _context.ChiTietTours.Add(chiTietTours);
            return _context.SaveChanges() != 0;
        }
    }
}
