using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.ChiTiet
{
    public class ChiTietRepository : Repository, IChiTietRepo
    {
        public ChiTietRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(ChiTietTours chiTietTours)
        {
            _ = _context.ChiTietTours.Add(chiTietTours);
            return _context.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            _context.ChiTietTours.RemoveRange(_context.ChiTietTours.Where(c => c.TourId == id));
            return _context.SaveChanges()!=0;
        }

        public bool DeleteByDiaDiemId(int id)
        {
            _context.ChiTietTours.RemoveRange(_context.ChiTietTours.Where(c => c.DiadiemId == id));
            return _context.SaveChanges()!=0;
        }

        public List<ChiTietTourVM> getAllChiTietTour()
        {

            IEnumerable<ChiTietTourVM> chiTietTours = _context.Tours.Join(
                _context.Loais,
                t=>t.LoaiId,
                l=>l.LoaiId,
                (t,l) => new ChiTietTourVM()
                {
                    TourId = t.TourId,
                    TenTour = t.Ten,
                    Mota = t.Mota,
                    IdLoai = l.LoaiId,
                    TenLoai = l.Ten
                }
                ).AsEnumerable();
            IEnumerable<ChiTietTourVM> DiaDiem = _context.ChiTietTours.Join(
                _context.DiaDiems,
                c=>c.DiadiemId,
                d=>d.DiadiemId,
                (c,d)=>new ChiTietTourVM
                {
                    TourId = c.TourId,
                    ThanhPho = d.Thanhpho,
                    TenDiaDiem = d.Ten
                }
                ).AsEnumerable();
            List<ChiTietTourVM> list = chiTietTours.ToList();
            foreach (ChiTietTourVM c in chiTietTours)
            {
                c.TenDiaDiem = "";
                foreach(ChiTietTourVM d in DiaDiem)
                {
                    if (c.TourId == d.TourId)
                    {
                        c.TenDiaDiem=d.TenDiaDiem;
                    }
                }
            }
            foreach(ChiTietTourVM c in list)
            {
                foreach (ChiTietTourVM d in DiaDiem)
                {
                    if (c.TourId == d.TourId)
                    {
                        c.DanhSachDiaDiem.Add(d.TenDiaDiem+" - "+d.ThanhPho);
                    }
                }
            }
            return list;
        }
    }
}
