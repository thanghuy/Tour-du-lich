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
        public int Sotienformat{
            get {
                int sotien = Convert.ToInt32(string.Format("{0:C}", Sotien.ToString()));
                return sotien;
            }
        }
    }
}
