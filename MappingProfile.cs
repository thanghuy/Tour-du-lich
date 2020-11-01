using AutoMapper;
using tour.Models.DTOs;
using tour.ViewModels;

namespace tour
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DoanDTO, DoanViewModel>();
            CreateMap<DoanViewModel, DoanDTO>();
        }
    }
}
