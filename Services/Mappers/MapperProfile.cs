using AutoMapper;
using Domain.Entities;
using DTOs.ClientDTOs;
using DTOs.GoodDTOs;
using DTOs.MaterialDTOs;
using DTOs.OrderDTOs;

namespace Services.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();

            CreateMap<Client, ShortClientDTO>();
            CreateMap<ShortClientDTO, Client>();

            CreateMap<Good, ShortGoodDTO>();
            CreateMap<ShortGoodDTO, Good>();

            CreateMap<Good, GoodDTO>();
            CreateMap<GoodDTO, Good>();

            CreateMap<Material, MaterialDTO>();
            CreateMap<MaterialDTO, Material>();

            CreateMap<Order, ShortOrderDTO>();
            CreateMap<ShortOrderDTO, Order>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}