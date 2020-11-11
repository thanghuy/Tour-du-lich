using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.NhanVien
{
    public interface INhanVienRepo
    {
        NhanViens Get(int id);
        bool Add(NhanViens d);
        bool Update(NhanViens d);
        List<NhanViens> GetAllId(string id);
        IEnumerable<NhanViens> GetAll();
        int Count();
    }
}
