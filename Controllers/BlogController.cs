using Medic.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Medic.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private ApplicationDbContext context;
        public BlogController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        public ActionResult PostUser(Post pst)
        {
            if (ModelState.IsValid)
            {

                try
                {

                    bool td = string.IsNullOrEmpty(pst.post);

                   /* if (!string.IsNullOrEmpty(pst.post))
                    {
                        return Json(new { status = "Please Write Something.." });
                    } */

                    string currentUserId = User.Identity.GetUserId();

                 //   Post obj = new Post();
                    var obj = new Post
                    {
                        post = pst.post,
                        postDate = DateTime.Now,
                        UserId = currentUserId
                    };


                     context.Posts.Add(obj);
                     context.SaveChanges();

                    return Json(new { status = "DATA SAVED SUCCESSFULLY" });
                }
                catch (Exception e)
                {
                    return Json(new { status = "PROBLEM OCCURED " + e });
                }

            }
            else
            {
                return Json(new { status = "INVALID" });
            }
        }
        /*public class Post
        {
            public string postString { get; set; }
        } */
    }
}