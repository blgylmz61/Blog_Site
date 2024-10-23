using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Post:BaseEntity
    {
        public string Title { get; set; }
        public bool IsApproved  { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int LikeCount { get; set; }

    }
}
