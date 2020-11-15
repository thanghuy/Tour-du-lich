using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.Doan
{
    public class DoanRepository :Repository, IDoanRepo
    {
        public DoanRepository(Tour_DBContext context) : base(context)
        {
        }

        public int Add(Doans d)
        {
            _context.Add(d);
            _context.SaveChanges();
            return d.DoanId;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Doans Get(int id)
        {
            return _context.Doans.Find(id);
        }

        public IEnumerable<Doans> GetAll()
        {
            return _context.Doans.AsEnumerable();
        }

        public List<DoanViewModel> GetAlll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Doans d)
        {
            throw new NotImplementedException();
        }
    }
}
