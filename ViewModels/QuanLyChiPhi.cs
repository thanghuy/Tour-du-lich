using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tour.ViewModels
{
    public class QuanLyChiPhi
    {
        public int IdTour { get; set; }
        [Required]
        public string TenTour{ get; set; }
        public int IdDoan { get; set; }
        [Required]
        public string TenDoan { get; set; }
        public int IdLoaiChiPhi { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [Required]
        public string HoaDon { get; set; }
        [Required]
        public int Gia{ get; set; }
    }
}
