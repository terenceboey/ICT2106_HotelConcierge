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

/*        public ActionResult Login()
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
            *//*            var model = accountService.GetAllAccounts();
                        Console.WriteLine(model);*//*
            try
            {
                if (ModelState.IsValid)
                {
                    Account a = new Account();
                    a.Email= LoginModel.Email;
                    a.Password= LoginModel.Password;
                    accountService.Login(LoginModel);
                    return RedirectToAction("/Home/Demo");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                TempData["Failed"] = "Failed";
            }
            return RedirectToAction("/SignUp");
        }*/

        public ActionResult SignUp()
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Sign Up Failed";
            }
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Account account, Guest guestDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    accountService.AddAccount(account, guestDetails);
                    return RedirectToAction("Guest", "Login", new { area = "" });
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
                TempData["Failed"] = "Failed";
            }
            return View(account);
        }

    }
}
