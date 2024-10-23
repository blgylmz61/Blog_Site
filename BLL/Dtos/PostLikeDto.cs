using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class PostLikeDto:BaseDto
    {
        public UserDto UserDto { get; set; }
        public int UserId { get; set; }
        public PostDto PostDto { get; set; }
        public int PostId { get; set; }
        
    }
}
