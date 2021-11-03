using BusinessLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    public class BlogController : Controller
    {
        BlogRepository blogRepository = new BlogRepository();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = blogRepository.GetAll().ToPagedList(page,6);
            return PartialView(blogList);
        }
        public PartialViewResult FeaturedPost()
        {
            //1. Post
            var firstPostTitle = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 1).Select(x => x.BlogTitle).FirstOrDefault();
            var firstPostImage = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 1).Select(x => x.BlogImage).FirstOrDefault();
            var firstPostDate = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 1).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.firstPostTitle = firstPostTitle;
            ViewBag.firstPostImage = firstPostImage;
            ViewBag.firstPostDate = firstPostDate;

            //2.post
            var secondPostTitle = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4).Select(x => x.BlogTitle).FirstOrDefault();
            var secondPostImage = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4).Select(x => x.BlogImage).FirstOrDefault();
            var secondPostDate = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.secondPostTitle = secondPostTitle;
            ViewBag.secondPostImage = secondPostImage;
            ViewBag.secondPostDate = secondPostDate;

            //3.post
            var thirdPostTitle = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 5).Select(x => x.BlogTitle).FirstOrDefault();
            var thirdPostImage = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 5).Select(x => x.BlogImage).FirstOrDefault();
            var thirdPostDate = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 5).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.thirdPostTitle = thirdPostTitle;
            ViewBag.thirdPostImage = thirdPostImage;
            ViewBag.thirdPostDate = thirdPostDate;

            //4.post
            var fourthPostTitle = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4).Select(x => x.BlogTitle).FirstOrDefault();
            var fourthPostImage = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4).Select(x => x.BlogImage).FirstOrDefault();
            var fourthPostDate = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.fourthPostTitle = fourthPostTitle;
            ViewBag.fourthPostImage = fourthPostImage;
            ViewBag.fourthPostDate = fourthPostDate;

            //5.post
            var fifthPostTitle = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 6).Select(x => x.BlogTitle).FirstOrDefault();
            var fifthPostImage = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 6).Select(x => x.BlogImage).FirstOrDefault();
            var fifthPostDate = blogRepository.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 6).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.fifthPostTitle = fifthPostTitle;
            ViewBag.fifthPostImage = fifthPostImage;
            ViewBag.fifthPostDate = fifthPostDate;
            return PartialView();
        }
        public PartialViewResult OtherFeaturedPost()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {            
            return View();
        }
        public PartialViewResult BlogCover(int id)
        {
            var blogDetailList = blogRepository.GetBlogByID(id);
            return PartialView(blogDetailList);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var blogDetailList = blogRepository.GetBlogByID(id);
            return PartialView(blogDetailList);
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}