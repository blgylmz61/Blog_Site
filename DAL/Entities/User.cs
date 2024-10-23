using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }= false;
        public string Email { get; set; }
        public List<Post> Posts { get; set; }
    }
}
