using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class Tours
    {

        public int TourId { get; set; }

        [Required]
        public string Ten { get; set; }

        [Required]
        public string Mota { get; set; }

        [Required]
        public int LoaiId { get; set; }
    }
}
