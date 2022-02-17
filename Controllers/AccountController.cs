using _2106_Project.Domain.Interfaces;
using _2106_Project.Domain.Models;
using _2106_Project.Domain.Services;
using _2106_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _2106_Project.Controllers
{
    public class AccountController : Controller
    {

/*        private IUnitOfWork unitOfWork;
*/        private readonly IAccountService accountService;

        public AccountController(IAccountService accountSerivceParam)
        {
            this.accountService = accountSerivceParam;
        }

        public ActionResult SignUp()
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Sign Up Failed";
            }
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Account acc)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var firstName = HttpContext.Request.Form["first"];
                    var lastName = HttpContext.Request.Form["last"];
                    var dob = HttpContext.Request.Form["DOB"];
                    var password = HttpContext.Request.Form["password"];
                    var confirmpassword = HttpContext.Request.Form["confirmpassword"];

                    /*                    accountService.AddAccount(SignUpModel);
                    */
                    return RedirectToAction("Guest", "Login", new { area = "" });
                }
                else
                {
                    return View();
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
