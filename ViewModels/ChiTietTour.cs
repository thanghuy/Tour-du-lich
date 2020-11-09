using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.ViewModels
{
    public class ChiTietTour
    {
        private Tours tours;
        private DiaDiems diaDiems;
        private Loais loais;
        private Gias gias;

        public Tours Tours { get => tours; set => tours = value; }
        public DiaDiems DiaDiems { get => diaDiems; set => diaDiems = value; }
        public Loais Loais { get => loais; set => loais = value; }
        public Gias Gias { get => gias; set => gias = value; }
    }
}
