using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace tour.Models.Entities
{
    public class Doan
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public string DoanName { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayVe { get; set; }
        public string ChiTietChuongTrinh { get; set; }
    }
}
