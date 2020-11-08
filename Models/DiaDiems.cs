using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class DiaDiems
    {
        public int DiadiemId { get; set; }

        [Required]
        public string Thanhpho { get; set; }

        [Required]
        public string Ten { get; set; }

        [Required]
        public string Mota { get; set; }
    }
}
