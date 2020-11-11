using System;
using System.Collections.Generic;

namespace tour.Models
{
    public partial class NhanViens
    {
        public int NvId { get; set; }
        public string NvTen { get; set; }
        public string NvSdt { get; set; }
        public string NvNgaysinh { get; set; }
        public string NvEmail { get; set; }
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
