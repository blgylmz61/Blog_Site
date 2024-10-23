using BLL.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Blog_Site.Models
{
    public class UserViewModel : BaseViewModel
    {
       
        public string Name { get; set; }
       public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;

        public string Email { get; set; }
        public List<PostViewModel>? PostViewModels { get; set; }
    }
}

