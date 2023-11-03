using AutoMapper;
using Domain.Entities;
using DTOs.OrderDTOs;

namespace Services.Mappers
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, ShortOrderDTO>();
            CreateMap<ShortOrderDTO, Order>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}
