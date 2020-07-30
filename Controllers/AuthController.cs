using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestorantManagement.Models;
using RestorantManagement.ViewModels;

namespace RestorantManagement.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AuthController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Overview", "Table");
            }

            PinLoginModel model = new PinLoginModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(PinLoginModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = userManager.Users.FirstOrDefault(x => x.UserPin.Equals(model.Pin));

                await signInManager.SignInAsync(user, false);
                return RedirectToAction("Overview", "Table");
            }
            return View(model);
        }

    }
}