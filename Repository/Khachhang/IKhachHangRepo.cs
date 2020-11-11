using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.Khachhang
{
    public interface IKhachhangRepo
    {
        KhachHangs Get(int id);
        int Add(KhachHangs d);
        bool Update(KhachHangs d);
        List<KhachHangs> GetAll(string id);
        IEnumerable<KhachHangs> GetAlll();
        int Count();
    }
}
