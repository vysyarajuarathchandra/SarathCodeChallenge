using AutoMapper;
using SarathCodeChallenge.DTOs;
using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.profiles
{
    public class UserProfile :Profile
    {
        public UserProfile() 
        {
            CreateMap<User, userDTO>();
            CreateMap<userDTO, User>();
        }
    }
}
