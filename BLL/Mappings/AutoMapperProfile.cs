using AutoMapper;
using BLL.Dtos;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappings
{
    public class AutoMapperProfile:Profile //profile automapper classsıdır.
    {
        public AutoMapperProfile()
        {

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<PostLike, PostLikeDto>().ReverseMap();
        }
    }
}
