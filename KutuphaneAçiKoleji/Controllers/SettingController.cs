using KutuphaneAçiKoleji.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KutuphaneAçiKoleji.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public SettingController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // Kullanıcı oturum açmamış, gerekli işlemleri yapabilirsiniz.
                // Örneğin, hata mesajı gösterebilir veya yönlendirme yapabilirsiniz.
                return RedirectToAction("Index", "Login");
            }

            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Username = user.UserName;
            userEditViewModel.Email = user.Email;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // Kullanıcı oturum açmamış, gerekli işlemleri yapabilirsiniz.
                // Örneğin, hata mesajı gösterebilir veya yönlendirme yapabilirsiniz.
                return RedirectToAction("Login", "Account");
            }

            user.UserName = p.Username;
            user.Email = p.Email;

            if (!string.IsNullOrEmpty(p.Password))
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            }

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                // Başarısız sonuç durumunda gerekli işlemleri yapabilirsiniz.
                // Örneğin, hata mesajı gösterebilir veya yönlendirme yapabilirsiniz.
                return View();
            }
        }
    }
}
