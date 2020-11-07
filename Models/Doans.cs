using System;
using System.Collections.Generic;

namespace tour.Models
{
    public partial class Doans
    {
        public int DoanId { get; set; }
        public int TourId { get; set; }
        public string Ten { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayVe { get; set; }
        public string ChiTietChuongTrinh { get; set; }
    }
}
