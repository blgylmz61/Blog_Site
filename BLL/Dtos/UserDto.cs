using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class UserDto:BaseDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public string Email { get; set; }
        public List<PostDto> PostDtos { get; set; }
    }
}
