using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutRepository aboutRepository = new AboutRepository();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
            var aboutContentList = aboutRepository.GetAll();
            return PartialView(aboutContentList);
        }
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}