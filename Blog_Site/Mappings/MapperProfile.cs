using AutoMapper;
using BLL.Dtos;
using Blog_Site.Models;


namespace Blog_Site.Mappings
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<PostDto,PostViewModel>().ReverseMap();
            CreateMap<UserDto,UserViewModel>().ReverseMap();
        }

    }
}
