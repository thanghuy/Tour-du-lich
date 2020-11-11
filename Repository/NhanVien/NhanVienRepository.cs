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
            return _context.NhanViens.Find(id);
        }

        public IEnumerable<NhanViens> GetAll()
        {
            return _context.NhanViens.AsEnumerable();
        }

        public bool Update(NhanViens d)
        {
            throw new NotImplementedException();
        }

        List<NhanViens> INhanVienRepo.GetAllId(string id)
        {
            string[] list_id = id.Split(",");
            List<NhanViens> nv = new List<NhanViens>();
            var db = _context;
            foreach (var i in list_id)
            {
                var query = (from c in db.NhanViens
                             where c.NvId == Convert.ToInt32(i)
                             select c).ToList();
                nv.AddRange(query);
            }
            return nv;
        }
    }
}
