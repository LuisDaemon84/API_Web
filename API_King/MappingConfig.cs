using API_King.Modelos;
using API_King.Modelos.Dto;
using AutoMapper;
using System.Runtime.InteropServices;

namespace API_King
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaCreateDto>().ReverseMap();
        }
    }
}
