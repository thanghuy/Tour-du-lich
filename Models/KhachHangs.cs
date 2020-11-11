using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class KhachHangs
    {
        public int KhId { get; set; }
        [Required]
        public string KhTen { get; set; }
        [Required]
        public string KhSdt { get; set; }
        [Required]
        public string KhNgaysinh { get; set; }
        [Required]
        public string KhEmail { get; set; }
        [Required]
        public string KhCmnd { get; set; }
    }
}
