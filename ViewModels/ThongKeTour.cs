using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tour.ViewModels
{
    public class ThongKeTour
    {
        public int IdTour { get; set; }
        public string TenTour { get; set; }
        public int TongDoanDi { get; set; }
        public int TongDoanhThu { get; set; }
        public int TongChiPhi { get; set; }
        public int Lai { get; set; }

        public string FormatTongDoandi() => string.Format("{0:#,0}", TongDoanDi);
        public string FormatTongDoanhThu() => string.Format("{0:#,0}", TongDoanhThu);
        public string FormatTongChiPhi() => string.Format("{0:#,0}", TongChiPhi);
        public string FormatLai() => string.Format("{0:#,0}", Lai);
    }
}
