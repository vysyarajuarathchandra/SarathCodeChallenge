using AutoMapper;
using SarathCodeChallenge.DTOs;
using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile() 
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }

    }
}
