using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class DiaDiems
    {
        public int DiadiemId { get; set; }

        [Required(ErrorMessage = "Thành phố không được để trống!")]
        public string Thanhpho { get; set; }

        [Required(ErrorMessage = "Tên địa điểm không được để trống!")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống!")]
        public string Mota { get; set; }
    }
}
