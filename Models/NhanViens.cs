using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class NhanViens
    {
        public int NvId { get; set; }
        [Required]
        public string NvTen { get; set; }
        [Required]
        public string NvSdt { get; set; }
        [Required]
        public string NvNgaysinh { get; set; }
        [Required]
        public string NvEmail { get; set; }
        [Required]
        public int NvNhiemvu { get; set; }
    }
}
