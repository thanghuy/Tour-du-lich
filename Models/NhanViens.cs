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
        public string Nhiemvu
        {
            get
            {
                string ten_nhiem_vu = "";
                if(NvNhiemvu == 0)
                {
                    ten_nhiem_vu = "Hướng dẫn viên";
                }
                if(NvNhiemvu == 1)
                {
                    ten_nhiem_vu = "Thông dịch viên";
                }
                if(NvNhiemvu == 2)
                {
                    ten_nhiem_vu = "Tài xế";
                }
                return ten_nhiem_vu;
            }
        }
    }
}
