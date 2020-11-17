using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository
{
    public class Repository
    {
        public readonly Tour_DBContext _context;

        public Repository(Tour_DBContext context) => _context = context;
        internal QuanLyChiPhi GetGroupQL(int id)
        {
            return _context.Doans.Where(d => d.DoanId == id).Join(
                _context.Tours,
                d => d.TourId,
                t => t.TourId,
                (d, t) => new QuanLyChiPhi()
                {
                    IdDoan = d.DoanId,
                    TenDoan = d.Ten,
                    IdTour = t.TourId,
                    TenTour = t.Ten
                }
                ).FirstOrDefault();
        }

        internal List<ChiTietDoanhThu> GetChiTietDoanhThu(int id)
        {
            List<ChiTietDoanhThu> ds = _context.Tours.Where(t => t.TourId == id).Join(
                   _context.Doans,
                       t => t.TourId,
                       d => d.TourId,
               (t, d) => new { t, d }
               ).Select(s => new ChiTietDoanhThu()
               {
                   IdDoan = s.d.DoanId,
                   TenDoan = s.d.Ten,
                   IdTour = s.t.TourId
               }).ToList();
            foreach (ChiTietDoanhThu chiTiet in ds)
            {
                chiTiet.GiaTour = getGiaTour(chiTiet.IdTour);
                chiTiet.SoKhach = getSoKhach(chiTiet.IdDoan);
                chiTiet.TongChiPhi = getTongChiPhiCuaDoan(chiTiet.IdDoan);
                chiTiet.DoanhThu = chiTiet.SoKhach * chiTiet.GiaTour;
                chiTiet.Lai = chiTiet.DoanhThu - chiTiet.TongChiPhi;
            }
            return ds;
        }

        private int getGiaTour(int idTour)
        {
            try
            {
                return _context.Gias.Where(g => g.ToudId == idTour).Select(s => new { s.Sotien }).First().Sotien;
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        private int getTongChiPhiCuaDoan(int doanId)
        {
            return _context.ChiPhis.Where(c => c.DoanId == doanId).Select(s => new { Tong = s.Tongchiphi }).Sum(x => (int)x.Tong);
        }

        private int getSoKhach(int idDoan)
        {
            string[] kh = _context.NguoiDis.Where(c => c.DoanId == idDoan).Select(c => new { KH = c.Danhsachkhach }).First().KH.Split(",");
            if (kh.Length == 1 && kh[0].Equals("0")) return 0;
            else return kh.Length-1;
        }

        internal List<ThongKeTour> ThongKeAllTour()
        {
            IEnumerable<ThongKeTour> tour = _context.Tours.Select(t => new ThongKeTour()
            {
                IdTour = t.TourId,
                TenTour = t.Ten
            }
            ).ToList();
            foreach (ThongKeTour tk in tour)
            {
                tk.TongDoanhThu = getGiaTour(tk.IdTour)*getTongSoKhach(tk.IdTour);
                tk.TongDoanDi = getTongDoanDi(tk.IdTour);
                tk.TongChiPhi = getTongChiPhi(tk.IdTour);
            }
            return tour.ToList();
        }

        private int getTongSoKhach(int idTour)
        {
            IEnumerable<string> ds = _context.Tours.Where(t => t.TourId == idTour).Join(
                   _context.Doans,
                       t => t.TourId,
                       d => d.TourId,
               (t, d) => new { t, d }
               ).Join(
                _context.NguoiDis,
                combine2=>combine2.d.DoanId,
                n=>n.DoanId,
                (combine2,n)=> new {combine2,n}
                ).Select(c=>c.n.Danhsachkhach);
            int tong = 0;
            foreach(string s in ds)
            {
                string[] mang = s.Split(",");
                if (mang.Length == 1 && mang[0].Equals("0"))
                {

                }
                else tong +=mang.Length - 1;
            }
            return tong;
        }

        private int getTongChiPhi(int idTour)
        {
            return _context.Tours.Where(t => t.TourId == idTour).Join(
                   _context.Doans,
                       t => t.TourId,
                       d => d.TourId,
               (t, d) => new { t, d }
               ).Join(
                    _context.ChiPhis,
                    combine2 => combine2.d.DoanId,
                    c => c.DoanId,
                    (combine2, c) => new { combine2, c }
                ).Select(s => new { TongChiPhi = s.c.Tongchiphi }).Sum(x => (int)x.TongChiPhi);
        }

        private int getTongDoanDi(int idTour)
        {
            return _context.Tours.Where(t => t.TourId == idTour).Join(
                   _context.Doans,
                       t => t.TourId,
                       d => d.TourId,
               (t, d) => new { t, d }
               ).Select(c => new { IdDoan = c.d.DoanId }).Count();
        }

        private int getTongDoanhThu(int idTour)
        {
            return _context.Tours.Where(t => t.TourId == idTour).Join(
                    _context.Doans,
                        t => t.TourId,
                        d => d.TourId,
                (t, d) => new { t, d }
                ).Join(
                    _context.Gias,
                    combine2 => combine2.t.TourId,
                    g => g.ToudId,
                    (combine2, g) => new { combine2, g }
                ).Select(c => new { TongDoanhThu = c.g.Sotien }).Sum(c => c.TongDoanhThu);
        }
        internal List<ChiPhis> GetChiTietHoaDon(int id)
        {
            List<ChiPhis> ds = _context.ChiPhis.Where(c => c.DoanId == id).ToList();
            return ds;
        }
    }
}