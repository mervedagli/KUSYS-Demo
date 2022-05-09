using Entity.Model;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS_Demo.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<User> _userManager;
        
        public RegisterUserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel userSignUpViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    UserName = userSignUpViewModel.UserNamee,
                    Email=userSignUpViewModel.Mail,
                    NormalizedUserName=userSignUpViewModel.UserNamee,
                    
                };

                var result= await _userManager.CreateAsync(user,userSignUpViewModel.Password);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userSignUpViewModel);
        }
    }
}
