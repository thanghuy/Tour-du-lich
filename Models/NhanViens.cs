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
    }
}
