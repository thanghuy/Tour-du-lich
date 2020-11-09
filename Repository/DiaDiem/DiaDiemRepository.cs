using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
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

        public IEnumerable<DiaDiems> FindByName(string name)
        {
            return _context.DiaDiems.Where(c=>c.Thanhpho == name).AsEnumerable();
        }

        public DiaDiems Get(int id)
        {
            return null;
        }

        public IEnumerable<DiaDiems> GetAll()
        {
            return _context.DiaDiems.AsEnumerable();
        }

        public IEnumerable<DiaDiems> GetGroupNameCity()
        {
            Console.WriteLine(_context.DiaDiems.GroupBy(s => s.Thanhpho).Select(c=>c.Key).AsEnumerable());
            return _context.DiaDiems
                .GroupBy(tp => tp.Thanhpho)
                .Select(tp => new DiaDiems 
                {
                    Thanhpho = tp.Key 
                }
                ).AsEnumerable();
            //return _context.DiaDiems.Select(tp => new DiaDiems() { Thanhpho = tp.Thanhpho, DiadiemId = tp.DiadiemId }).ToList();  
        }

        public bool Update(DiaDiems d)
        {
            
            return true;
        }

       
    }
}
