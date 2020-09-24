using Medic.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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

        [System.Web.Http.Route("ShowAllPost")]
        [System.Web.Http.HttpGet]
        public  Object ShowAllPost()
        {
            var list =  context.Posts.ToList(); ;
            var x = 10;

            return list;
        }

        [System.Web.Http.Route("GetUsers")]
        [System.Web.Http.HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            return Json(await context.Posts.ToListAsync());
        }

        [System.Web.Http.Route("ShowAllPost2")]
        [System.Web.Http.HttpGet]

        public int ShowAllPost2()
        {
            var list = context.Posts.ToList();
            var x = 10;
            // var obj = new { list = list };
            return Ok(1);


        }

        private int Ok(int v)
        {
            throw new NotImplementedException();
        }

        [System.Web.Http.Route("ShowAllPost3")]
        [System.Web.Http.HttpGet]
        public JsonResult ShowAllPost3()
        {
            var list = context.Posts.ToList();
            var x = 10;
            // var obj = new { list = list };

            return Json(new { success = "Succes from server" }, JsonRequestBehavior.AllowGet);
        }
    }
}