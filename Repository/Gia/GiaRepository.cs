using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.Gia
{
    public class GiaRepository :Repository, IGiaRepo
    {
        public GiaRepository(Tour_DBContext context) : base(context)
        {
        }

        public bool Add(Gias d)
        {
            _context.Add(d);
            return _context.SaveChanges() != 0;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delele(int id)
        {
            Gias gia = _context.Gias.Find(id);
            _context.Gias.Remove(gia);
            return _context.SaveChanges()!=0;
        }

        public bool DeleteByTourId(int id)
        {
            _context.Gias.RemoveRange(_context.Gias.Where(g => g.ToudId == id));
            return _context.SaveChanges()!=0;
        }

        public Gias Get(int id)
        {
            DateTime today = DateTime.Today;
            return _context.Gias.Where(c => c.ToudId == id && c.Tungay <= today && today <= c.Denngay).First();
        }

        public int Get(object sotien)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Gias> GetAll()
        {
            return _context.Gias.AsEnumerable();
        }

        public IEnumerable<Gias> GetAllGiasByIdLoai(int? id)
        {
            return _context.Gias.Where(g => g.ToudId == id).AsEnumerable();
        }

        public bool Update(Gias d)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIdTour(ChiTietTourVM chiTietTourVM,int Id)
        {
            _context.Gias.UpdateRange(_context.Gias.Where(g => g.ToudId == chiTietTourVM.TourId).Select(s => new Gias
            {
                ToudId = Id,
                GiaId = s.GiaId,
                Sotien = s.Sotien,
                Tungay = s.Tungay,
                Denngay = s.Denngay
            }));
            return _context.SaveChanges()!=0;
        }

        bool IGiaRepo.Update(Gias gias)
        {
            _context.Update(gias);
            return _context.SaveChanges()!=0;
        }
    }
}
