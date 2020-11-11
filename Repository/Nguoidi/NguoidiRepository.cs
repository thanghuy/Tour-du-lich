using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Nguoidi
{
    public class NguoidiRepository : Repository, INguoidiRepo
    {
        public NguoidiRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(NguoiDis d)
        {
            _context.Add(d);
            return _context.SaveChanges()!=0;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public NguoiDis Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NguoiDis> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NguoiDis> GetAllID(int id)
        {
            throw new NotImplementedException();
        }

        public string getKH(int id)
        {
            return _context.NguoiDis.Where(i => i.DoanId == id).Select(c=>c.Danhsachkhach).FirstOrDefault();
        }
        public string getNV(int id)
        {
            return _context.NguoiDis.Where(i => i.DoanId == id).Select(c=>c.Danhsachnhanvien).FirstOrDefault();
        }
        public bool Update(NguoiDis d)
        {
            throw new NotImplementedException();
        }
    }
}
