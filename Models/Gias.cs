using System;
using System.Collections.Generic;

namespace tour.Models
{
    public partial class Gias
    {
        public int GiaId { get; set; }
        public int Sotien { get; set; }
        public int TourId { get; set; }
        public DateTime Tungay { get; set; }
        public DateTime Denngay { get; set; }
    }
}
