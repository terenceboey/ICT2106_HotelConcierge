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
        public ActionResult SignUp(Account SignUpVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var firstName = HttpContext.Request.Form["first"];
                    var lastName = HttpContext.Request.Form["last"];
                    var dob = HttpContext.Request.Form["DOB"];
                    var email = HttpContext.Request.Form["email"];
                    var password = HttpContext.Request.Form["password"];
                    var confirmpassword = HttpContext.Request.Form["confirmpassword"];

                    if ( password == confirmpassword)
                    {
                        Account a = new Account();
                        Guest g = new Guest();

                        g.FirstName = firstName;
                        g.LastName = lastName;
                        g.DOB = Convert.ToDateTime(dob);
                        a.Email = email;
                        a.Password = password;
                        accountService.AddAccount(a,g);
                    }

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
