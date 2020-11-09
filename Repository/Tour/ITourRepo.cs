using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Tour
{
    public interface ITourRepo
    {
        Tours Get(int id);
        bool Add(Tours d);
        bool Update(Tours d);
        IEnumerable<Tours> GetAll();
        int Count();
        int AddAndGetLastId(Tours t);
    }
}

