using AutoMapper;
using MagicVilla_aPi.Models;
using MagicVilla_aPi.Models.Dto;

namespace MagicVilla_aPi
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa,VillaUpdateDto>().ReverseMap();
        }
    }
}
