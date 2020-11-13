using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Nguoidi
{
    public interface INguoidiRepo
    {
        NguoiDis Get(int id);
        bool Add(NguoiDis d);
        bool UpdateKH(string list_kh,int id);
        bool UpdateNV(string list_kh,int id);
        IEnumerable<NguoiDis> GetAll();
        IEnumerable<NguoiDis> GetAllID(int id);
        int CountKH(string list_kh);
        int CountNV(string list_nv);
        String getKH(int id);
        String getNV(int id);
        bool DeleteKH(string list_kh,string id);
        bool removeIndex(string list_kh,string list_nv,int id);
    }
}
