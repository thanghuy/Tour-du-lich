using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class LoaiChiPhis
    {
        public int ChiphiId { get; set; }
        [Required(ErrorMessage = "Loại không được để trống!")]
        public string Ten { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống!")]
        public string Mota { get; set; }
    }
}
