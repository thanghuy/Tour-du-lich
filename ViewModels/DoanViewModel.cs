using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tour.ViewModels
{
    public class DoanViewModel
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public string DoanName { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayVe { get; set; }
        public string TongTien { get; set; }
    }
}
