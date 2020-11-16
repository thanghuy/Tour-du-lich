using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tour.Models
{
    public partial class Gias
    {
        public int GiaId { get; set; }

        [Required(ErrorMessage = "Số tiền không được để trống!")]
        public int Sotien { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu không được để trống!")]
        public DateTime Tungay { get; set; }

        [Required(ErrorMessage = "Ngày kết thúc không được để trống!")]
        public DateTime Denngay { get; set; }

        [Required]
        public int? ToudId { get; set; }
        public int Sotienformat {
            get {
                int sotien = Convert.ToInt32(string.Format("{0:C}", Sotien.ToString()));
                return sotien;
            }
        }

        public string FormatGia { get { return string.Format("{0:#,0}", Sotien); } }
    }
}
