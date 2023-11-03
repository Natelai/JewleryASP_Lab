using AutoMapper;
using Domain.Entities;
using DTOs.MaterialDTOs;

namespace Services.Mappers
{
    public class MaterialProfile : Profile
    {
        public MaterialProfile()
        {
            CreateMap<Material, MaterialDTO>();
            CreateMap<MaterialDTO, Material>();
        }
    }
}
