using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSB100UserProfileWebSite.Models;

namespace TSB100UserProfileWebSite.Controllers
{
    public class AccountController : Controller
    {

        

        // GET: CreateAccount
        public ActionResult Index()
        {
            var CreateAccount = new CreateAccountViewModel();
            return View(CreateAccount);
        }

        public ActionResult UpdateProfile(UpdateProfileViewModel vm)
        {
            var UpdateProfile = new UpdateProfileViewModel();
            return View(UpdateProfile);
        }
    }
}