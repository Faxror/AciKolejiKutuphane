using KutuphaneAçiKoleji.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneAçiKoleji.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            // Mevcut kullanıcıyı al
            var currentUser = _userManager.GetUserAsync(User).Result;

            // Kullanıcı adını al
            var username = currentUser.UserName;

            // Kullanıcı adını view'e aktar
            ViewBag.Username = username;

            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel user)
        {
            IdentityUser ıdentityUser = new IdentityUser()
            {
                Id = "1",
                UserName = user.Username,
                Email = user.Email


            };
            if (user.Password == user.confrimpassword)
            {
                var result = await _userManager.CreateAsync(ıdentityUser, user.Password);
                if ( result.Succeeded)
                {
                    return RedirectToAction("Index", "School");
                }
                else
                {
                  foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                
            }
            return View(user);
        }
    }
}
