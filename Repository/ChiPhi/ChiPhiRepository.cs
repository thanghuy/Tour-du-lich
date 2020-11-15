using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.ChiPhi
{
    public class ChiPhiRepository : Repository, IChiPhiRepo
    {
        public ChiPhiRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(QuanLyChiPhi quanLyChiPhi)
        {
            String ct = _context.LoaiChiPhis.Find(quanLyChiPhi.IdLoaiChiPhi).Ten;
            _context.ChiPhis.Add(new ChiPhis()
            {
                DoanId = quanLyChiPhi.IdDoan,
                Tongchiphi = quanLyChiPhi.Gia,
                Chitiet = ct,
                Hoadon = quanLyChiPhi.HoaDon,
                Noidung = quanLyChiPhi.NoiDung
            }
                );
            return _context.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            _context.ChiPhis.Remove(_context.ChiPhis.Find(id));
            return _context.SaveChanges() != 0;
        }
    }
}
