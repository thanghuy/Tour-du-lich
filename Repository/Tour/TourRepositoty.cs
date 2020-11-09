using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Tour
{
    public class TourRepositoty : Repository, ITourRepo
    {
        public TourRepositoty(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(Tours d)
        {
            throw new NotImplementedException();
        }

        public int AddAndGetLastId(Tours t)
        {
            _ = _context.Add(t);
            _ = _context.SaveChanges();
            return t.TourId;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Tours Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tours> GetAll()
        {
            return _context.Tours.AsEnumerable();
        }

        public bool Update(Tours d)
        {
            throw new NotImplementedException();
        }
    }
}
