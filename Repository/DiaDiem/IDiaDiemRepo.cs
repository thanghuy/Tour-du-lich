using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.DiaDiem
{
    public interface IDiaDiemRepo
    {
        DiaDiems Get(int id);
        bool Add(DiaDiems d);
        bool Update(DiaDiems d);
        IEnumerable<DiaDiems> GetAll();
        int Count();
    }
}
