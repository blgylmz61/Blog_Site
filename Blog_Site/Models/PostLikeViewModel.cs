using Blog_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class PostLikeviewModel:BaseViewModel
    {
        public UserViewModel UserViewModel { get; set; }
        public int UserId { get; set; }
        public PostViewModel PostViewModel { get; set; }
        public int PostId { get; set; }
    }
}
