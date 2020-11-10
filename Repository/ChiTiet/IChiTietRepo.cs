using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.ChiTiet
{
    public interface IChiTietRepo
    {
        public bool Add(ChiTietTours chiTietTours);
        List<ChiTietTourVM> getAllChiTietTour();
        bool Delete(int id);
    }
}
