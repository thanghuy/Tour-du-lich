using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class Gias
    {
        public int GiaId { get; set; }

        [Required]
        public int Sotien { get; set; }

        [Required]
        public DateTime Tungay { get; set; }

        [Required]
        public DateTime Denngay { get; set; }

        [Required]
        public int? ToudId { get; set; }
    }
}
