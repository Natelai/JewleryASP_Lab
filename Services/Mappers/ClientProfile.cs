using AutoMapper;
using Domain.Entities;
using DTOs.ClientDTOs;

namespace Services.Mappers
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ShortClientDTO>();
            CreateMap<ShortClientDTO, Client>();

            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();
        }
    }
}
