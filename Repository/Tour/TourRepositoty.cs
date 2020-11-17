using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.Tour
{
    public class TourRepositoty : Repository, ITourRepo
    {
        public TourRepositoty(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(Tours d)
        {
            throw new NotImplementedException();
        }

        public int AddAndGetLastId(Tours t)
        {
            _ = _context.Add(t);
            _ = _context.SaveChanges();
            return t.TourId;
        }

        public int Count()
        {
            return _context.Tours.Count();
        }

        public ChiTietTourVM CreateNewTour(int id)
        {
           Tours tours = _context.Tours.Find(id);
            return new ChiTietTourVM()
            {
                TourId = tours.TourId,
                TenTour = tours.Ten,
                Mota = tours.Mota,
                IdLoai = tours.LoaiId
            };
        }

        public bool Delete(int id)
        {
            Tours tour = _context.Tours.Find(id);
            _context.Remove(tour);
            return _context.SaveChanges()!=0;
        }

        public Tours Get(int id)
        {
            return _context.Tours.Find(id);
        }

        public IEnumerable<Tours> GetAll()
        {
            return _context.Tours.AsEnumerable();
        }

        public bool Update(ChiTietTourVM ct)
        {
            Tours tour = _context.Tours.Find(ct.TourId);
            tour.Ten = ct.TenTour;
            tour.Mota = ct.Mota;
            tour.LoaiId = tour.LoaiId;
            return _context.SaveChanges() != 0;
        }
    }
}
