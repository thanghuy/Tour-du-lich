using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using tour.Models;

namespace tour.Repository.DiaDiem
{
    public class DiaDiemRepository : Repository,IDiaDiemRepo
    {
        public DiaDiemRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(DiaDiems d)
        {
            _context.Add(d);
            return _context.SaveChanges()!=0;
        }

        public int Count()
        {
            return 1;
        }

        public DiaDiems Get(int id)
        {
            return null;
        }

        public IEnumerable<DiaDiems> GetAll()
        {
            return _context.DiaDiems.AsEnumerable();
        }

        public bool Update(DiaDiems d)
        {
            
            return true;
        }
    }
}
