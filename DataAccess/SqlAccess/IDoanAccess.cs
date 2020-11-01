using System.Collections.Generic;
using tour.Models.DTOs;

namespace tour.DataAccess.SqlAccess
{
    public interface IDoanAccess
    {
        List<DoanDTO> GetAll();
    }
}