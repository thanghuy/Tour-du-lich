using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.Gia
{
    public interface IGiaRepo
    {
        Gias Get(int id);
        bool Add(Gias d);
        IEnumerable<Gias> GetAll();
        int Count();
        int Get(object sotien);
        IEnumerable<Gias> GetAllGiasByIdLoai(int? id);
        bool Update(Gias gias);
        bool Delele(int id);
        bool DeleteByTourId(int id);
        bool UpdateIdTour(ChiTietTourVM chiTietTourVM,int TourId);
    }
}
