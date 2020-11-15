using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class KhachHangs
    {
        public int KhId { get; set; }
        [Required(ErrorMessage = "Tên không được để trống!")]
        public string KhTen { get; set; }
        [Required(ErrorMessage = "SDT không được để trống!")]
        public string KhSdt { get; set; }
        [Required(ErrorMessage = "Ngày sinh không được để trống!")]
        public string KhNgaysinh { get; set; }
        [Required(ErrorMessage = "Email không được để trống!")]
        public string KhEmail { get; set; }
        [Required(ErrorMessage = "CMND không được để trống!")]
        public string KhCmnd { get; set; }
    }
}
