using _2106_Project.Domain.Models;
using _2106_Project.Domain.Services;
using _2106_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _2106_Project.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAccountService accountService;

        public LoginController(IAccountService accountSerivceParam)
        {
            this.accountService = accountSerivceParam;
        }

        public IActionResult Guest()
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Login Failed";
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account LoginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string e = LoginModel.Email;
                    string p = LoginModel.Password;
                    if (accountService.Login(LoginModel))
                    {
                        return RedirectToAction("Demo", "Home", new { area = "" });

                    }
                    else
                    {
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                TempData["Failed"] = "Failed";
            }
            return View();
        }
    }
}
