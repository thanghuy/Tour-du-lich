using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Gia
{
    public class GiaRepository :Repository, IGiaRepo
    {
        public GiaRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(Gias d)
        {
            _context.Add(d);
            return _context.SaveChanges() != 0;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Gias Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gias> GetAll()
        {
            return _context.Gias.AsEnumerable();
        }

        public bool Update(Gias d)
        {
            throw new NotImplementedException();
        }
    }
}
