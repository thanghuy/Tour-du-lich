using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.NhanVien
{
    public class NhanVienRepository : Repository, INhanVienRepo
    {
        public NhanVienRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(NhanViens d)
        {
            _context.Add(d);
            return _context.SaveChanges()!=0;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public NhanViens Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NhanViens> GetAll()
        {
            return _context.NhanViens.AsEnumerable();
        }

        public bool Update(NhanViens d)
        {
            throw new NotImplementedException();
        }
    }
}
