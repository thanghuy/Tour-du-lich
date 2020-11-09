using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class Doans
    {
        public int DoanId { get; set; }
        [Required(ErrorMessage ="Bạn chưa chọn tour")]
        public int TourId { get; set; }
        [Required(ErrorMessage ="Tên đoàn không được để trống")]
        public string Ten { get; set; }
        [Required(ErrorMessage ="Ngày đi không được để trống")]
        public DateTime NgayDi { get; set; }
        [Required(ErrorMessage ="Ngày về không được để trống")]
        public DateTime NgayVe { get; set; }
        [Required(ErrorMessage ="Chi tiết không được để trống")]
        public string ChiTietChuongTrinh { get; set; }
    }
}
