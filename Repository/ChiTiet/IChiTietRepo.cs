using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository.ChiTiet
{
    public interface IChiTietRepo
    {
        public bool Add(ChiTietTours chiTietTours);
    }
}
