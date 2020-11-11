using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Khachhang
{
    public class KhachangRepository : Repository, IKhachhangRepo
    {
        public KhachangRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(KhachHangs d)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public KhachHangs Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<KhachHangs> GetAll(String id)
        {
            string[] list_id = id.Split(",");
            List<KhachHangs> kh = new List<KhachHangs>();
            var db = _context;
            foreach (var i in list_id)
            {
               var query = (from c in db.KhachHangs
                            where c.KhId == Convert.ToInt32(i)
                            select c).ToList();
                kh.AddRange(query);
            }
            return kh;
        }

        public IEnumerable<KhachHangs> GetAllID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(KhachHangs d)
        {
            throw new NotImplementedException();
        }
    }
}
