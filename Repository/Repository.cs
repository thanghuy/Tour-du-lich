using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;

namespace tour.Repository
{
    public class Repository
    {
        public readonly Tour_DBContext _context;

        public Repository(Tour_DBContext context) => _context = context;

    }
}
