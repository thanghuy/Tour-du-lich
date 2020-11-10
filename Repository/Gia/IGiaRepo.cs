using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

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
    }
}
