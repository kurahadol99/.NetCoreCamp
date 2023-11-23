using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EFNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            newsLetterManager.AddNewsLetter(p);
            return RedirectToAction("BlogReadAll", "Blog",4);
        }
    }
}
