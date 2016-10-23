using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhoramShop.Models;
using System.Data.Entity.Validation;
using System.Web.Security;

namespace KhoramShop.Areas.FrontOffice.Controllers
{
    public class AccountController : Controller
    {
        // GET: FrontOffice/Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(Models.Customer userr)
        {
            FormsAuthentication.SetAuthCookie(userr.UserName,false);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Models.Customer user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new KhoramContext())
                    {
                        var newUSer = db.Customer.Create();
                        newUSer.UserName = user.UserName;
                        newUSer.Password = user.Password;
                        db.Customer.Add(newUSer);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Home");
                    }
                }
                else {
                    ModelState.AddModelError("", "اطلاعات صحیح نیست");
                     }
            }
            catch(DbEntityValidationException e)
            {
                foreach(var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                    throw;
                }
            }
            return View();
                }
            }
        }