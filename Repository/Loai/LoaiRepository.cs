using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Loai
{
    public class LoaiRepository : Repository, ILoaiRepo
    {
        public LoaiRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(Loais d)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Loais Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loais> GetAll()
        {
            return _context.Loais.AsEnumerable();
        }

        public bool Update(Loais d)
        {
            throw new NotImplementedException();
        }
    }
}
