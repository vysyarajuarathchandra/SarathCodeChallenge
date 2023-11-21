using AutoMapper;
using SarathCodeChallenge.DTOs;
using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
