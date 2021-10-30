using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class MailSubscribeController : Controller
    {
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail subscribeMail)
        {
            SubscribeMailRepository subscribeMailRepository = new SubscribeMailRepository();
            subscribeMailRepository.Add(subscribeMail);
            return PartialView();
        }
    }
}