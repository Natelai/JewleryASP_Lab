using AutoMapper;
using Domain.Entities;
using DTOs.GoodDTOs;

namespace Services.Mappers
{
    public class GoodProfile : Profile
    {
        public GoodProfile()
        {
            CreateMap<Good, ShortGoodDTO>();
            CreateMap<ShortGoodDTO, Good>();

            CreateMap<Good, GoodDTO>();
            CreateMap<GoodDTO, Good>();
        }
    }
}
