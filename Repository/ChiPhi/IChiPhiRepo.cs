using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.ViewModels;

namespace tour.Repository.ChiPhi
{
    public interface IChiPhiRepo
    {
        bool Add(QuanLyChiPhi quanLyChiPhi);
        bool Delete(int id);
    }
}
