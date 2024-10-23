using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using Blog_Site.Models;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Blog_Site.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var userRole = HttpContext.Session.GetString("IsAdmin");
            if(userRole=="True"){
                var unApprovePosts = await _postService.GetAllUnApprovedPosts();
                return View(_mapper.Map<List<PostViewModel>>(unApprovePosts));
            }
            else
            {
                var posts= await _postService.GetAllPosts();
                return View(_mapper.Map<List<PostViewModel>>(posts));
            }
           
            
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PostViewModel postViewModel)
        {
            if (postViewModel.PhotoUrl != null)
            {
                var fileName = Path.GetFileName(postViewModel.PhotoUrl.FileName);
                var filePath = Path.Combine("wwwroot", "img", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await postViewModel.PhotoUrl.CopyToAsync(stream);
                    
                }
                
                postViewModel.Photo = fileName;

            }
            var userId = HttpContext.Session.GetInt32("UserId");
            postViewModel.UserId = userId.Value;
            await _postService.CreatePost(_mapper.Map<PostDto>(postViewModel));
            return RedirectToAction("ListPost", "Post");
        }

        [HttpGet]
        public async Task<IActionResult> ListPost() {

        var posts= await _postService.GetAllUnApprovedPosts();
            return View(_mapper.Map<List<PostViewModel>>( posts));
        }
        [HttpPost]
        public async Task<IActionResult> ApprovePost(int postId) {
            await _postService.ApprovePost(postId); 
            return RedirectToAction("index","post"); 
        }


    }
}
