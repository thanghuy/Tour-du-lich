using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class LoaiChiPhis
    {
        public int ChiphiId { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public string Mota { get; set; }
    }
}
