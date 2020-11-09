using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Loai
{
    public interface ILoaiRepo
    {
        Loais Get(int id);
        bool Add(Loais d);
        bool Update(Loais d);
        IEnumerable<Loais> GetAll();
        int Count();
    }
}
