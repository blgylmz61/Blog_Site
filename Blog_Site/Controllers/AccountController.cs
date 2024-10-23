using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using Blog_Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public AccountController(IUserService userService, IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel userViewModel)
        {
            var userDto = _mapper.Map<UserDto>(userViewModel);
            await _userService.Register(userDto);
            return RedirectToAction("Login");

        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            //Session'a bilgi ekleme 
            var userDto = await _userService.Login(username, password);
            

            if (userDto != null)
            {
                var userViewModel = _mapper.Map<UserViewModel>(userDto);
                HttpContext.Session.SetInt32("UserId", userViewModel.Id);
                HttpContext.Session.SetString("UserName", userViewModel.UserName);
                HttpContext.Session.SetString("IsAdmin", userViewModel.IsAdmin.ToString());
                return RedirectToAction("Index", "Post", userViewModel);
            }
            //viewbag - ViewData - TempData 
            //bu üç adet terim mvc de controllerdaki actiondan cshtml e veri taşımamaıza gerek validationda gerekse belli başlık listelerde veya direk entititynin kendisinde sağlar.ViewBag ve viewdata sadece kendi actionından cshtmle veri taşıyabilirken temp data ise özellikle redirectioaction kullanılırken yani başka olay sonucu bizi başka actiona yönlendirilirken kullanılır. viewbag ve viewdata farklı actiona veri taşıyamaz sadece temp data taşır.
            ViewBag.Hata = "Kullanıcı Adı veya Şifre yanlış yazıldı"; //Hata Keyi ile mesaj yakalancak buna dikkat edilmeli.
            
            return View();
        }

    }
}
