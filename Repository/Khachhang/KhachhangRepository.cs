using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tour.Models;

namespace tour.Repository.Khachhang
{
    public class KhachangRepository : Repository, IKhachhangRepo
    {
        public KhachangRepository(Tour_DBContext context) : base(context)
        {
        }

        public int Add(KhachHangs d)
        {
            _context.Add(d);
            _context.SaveChanges();
            return d.KhId;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public KhachHangs Get(int id)
        {
            return _context.KhachHangs.Find(id);
        }

        public List<KhachHangs> GetAll(String id)
        {
            string[] list_id = id.Split(",");
            List<KhachHangs> kh = new List<KhachHangs>();
            foreach (var i in list_id)
            {
               var query = (from c in _context.KhachHangs
                            where c.KhId == Convert.ToInt32(i)
                            select c).ToList();
                kh.AddRange(query);
            }
            return kh;
        }

        public IEnumerable<KhachHangs> GetAlll()
        {
            return _context.KhachHangs.AsEnumerable();
        }

        public bool Update(KhachHangs d)
        {
            throw new NotImplementedException();
        }
    }
}
