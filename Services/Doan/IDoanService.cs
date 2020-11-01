using System.Collections.Generic;
using tour.Models.DTOs;

namespace tour.Services.Doan
{
    public interface IDoanService
    {
        List<DoanDTO> GetAll();
    }
}