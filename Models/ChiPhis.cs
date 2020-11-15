using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class ChiPhis
    {
        public int ChiphiId { get; set; }
        public int DoanId { get; set; }
        [Required(ErrorMessage ="Chi phí không được để trống!")]
        public float Tongchiphi { get; set; }
        [Required(ErrorMessage = "Chi tiết không được để trống!")]
        public string Chitiet { get; set; }
        [Required(ErrorMessage = "Hoá đơn không được để trống!")]
        public string Hoadon { get; set; }
        [Required(ErrorMessage = "Nội dung không được để trống!")]
        public string Noidung { get; set; }
    }
}
