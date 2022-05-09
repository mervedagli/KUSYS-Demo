using DataAccessLayer.Data;
using Entity.Model;
using KUSYS_Demo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KUSYS_Demo.Controllers
{
    [AllowAnonymous]  // otantikeden muaf tutar.
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        Context _context=new Context();

        public LoginController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Student");
                }
            }

            return View();
        }




        //[HttpPost]
        //public async Task<IActionResult> Index(User user)
        //{
        //    //var userValue = _context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password==user.Password);
        //    //if (userValue!=null)
        //    //{
        //    //    var claims = new List<Claim>
        //    //    {
        //    //        new Claim(ClaimTypes.Name,user.Email)
        //    //    };
        //    //    var userIdentity = new ClaimsIdentity(claims, "a");
        //    //    ClaimsPrincipal principal=new ClaimsPrincipal(userIdentity);
        //    //    await HttpContext.SignInAsync(principal);
        //    //    return RedirectToAction("Index","Student");
        //    //}
        //    return View();
        //}


    }
}
