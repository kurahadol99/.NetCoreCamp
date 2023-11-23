using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactRepository());
        //[HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            contactManager.ContactAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
