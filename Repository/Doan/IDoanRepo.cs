using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.ViewModels;

namespace tour.Repository.Doan
{
    public interface IDoanRepo
    {
        Doans Get(int id);
        int Add(Doans d);
        bool Update(Doans d);
        IEnumerable<Doans> GetAll();
        int Count();
        List<DoanViewModel> GetAlll();
    }
}