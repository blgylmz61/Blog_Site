using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PostLike:BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
       
    }
}
