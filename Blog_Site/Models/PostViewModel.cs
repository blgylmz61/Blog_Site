using DAL.Entities;

namespace Blog_Site.Models
{
    public class PostViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public bool IsApproved { get; set; }
        public string Description { get; set; }
        public IFormFile PhotoUrl { get; set; } // viewmodelde tanımı deiştir.
        public string? Photo {  get; set; }
        public int UserId { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public  int LikeCount { get; set; }

    }
}
