using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class PostDto:BaseDto
    {
        public string Title { get; set; }
        public bool IsApproved { get; set; }
        public string Description { get; set; }
        public String Photo { get; set; }
        public int UserId { get; set; }
        public UserDto UserDto { get; set; }
        public  int LikeCount { get; set; }
    }
}
