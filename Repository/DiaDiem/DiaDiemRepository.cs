using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using tour.Models;

namespace tour.Repository.DiaDiem
{
    public class DiaDiemRepository : IDiaDiemRepo
    {
        private readonly Tour_DBContext _context;
        public DiaDiemRepository(Tour_DBContext context) => _context = context;
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

        public bool Update(DiaDiems d)
        {
            
            return true;
        }

        List<DiaDiems> IDiaDiemRepo.GetAllDiaDiems()
        {
            return _context.Set<DiaDiems>().ToList();
        }
    }
}
