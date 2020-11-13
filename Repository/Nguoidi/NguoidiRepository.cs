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

        public int CountKH(string list_kh)
        {
            string[] a = list_kh.Split(",");
            return a.Length - 1;
        }
        public int CountNV(string list_nv)
        {
            string[] a = list_nv.Split(",");
            return a.Length - 1;
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
        public bool removeIndex(string list_kh,string list_nv,int idND){
            // remove 0 khach hang
            string[] list = list_nv.Split(',');
            int numIndex = Array.IndexOf(list,0);
            if(numIndex == 1){
                List<string> tmp = new List<string>(list);
                tmp.RemoveAt(numIndex);
                string newList = string.Join(",",tmp);
                UpdateNV(newList,idND);
            }
            //remove 0 nhan vien
            string[] list1 = list_kh.Split(',');
            int numIndex1 = Array.IndexOf(list1,0);
            if(numIndex1 == 1){
                List<string> tmp1 = new List<string>(list1);
                tmp1.RemoveAt(numIndex1);
                string newList1 = string.Join(",",tmp1);
                UpdateKH(newList1,idND);
            }
            return false;
        }
        public bool UpdateKH(string list_kh,int id)
        {
            NguoiDis s = _context.NguoiDis.Find(id);
            s.Danhsachkhach = list_kh;
            _context.NguoiDis.Attach(s);
            _context.Entry(s).Property(x => x.Danhsachkhach).IsModified = true;
            return _context.SaveChanges()!=0;
        }
        public bool UpdateNV(string list_nv,int id)
        {
            NguoiDis s = _context.NguoiDis.Find(id);
            s.Danhsachnhanvien = list_nv;
            _context.NguoiDis.Attach(s);
            _context.Entry(s).Property(x => x.Danhsachnhanvien).IsModified = true;
            return _context.SaveChanges()!=0;
        }
        public bool DeleteKH(string list_kh,string id)
        {
            string[] a = list_kh.Split(",");
            return false;
        }
    }
}
