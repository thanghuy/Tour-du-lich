using System;
using System.Collections.Generic;

namespace tour.Models
{
    public partial class Tours
    {
        public int TourId { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public int LoaiId { get; set; }
        public int GiaId { get; set; }
    }
}
