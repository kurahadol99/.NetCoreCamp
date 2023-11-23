using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = 4;
            cm.Add(p);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var result = cm.GetComment(id);
            return PartialView(result);
        }
    }
}
