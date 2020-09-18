using Medic.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medic.Controllers
{
    public class DoctorController : Controller
    {
        private ApplicationDbContext context;
        public DoctorController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        [HttpPost]
        public ActionResult UpdateUserProfile(Doctor doctor)
        {
            if (doctor.id == null)
                context.Doctors.Add(doctor);
            else
            {
                var userInDb = context.Doctors.Single(c => c.id == doctor.id);
                userInDb.name = doctor.name;
                userInDb.specialization = doctor.specialization;
            }
            context.SaveChanges();
            return RedirectToAction("UserProfile", "Doctor", new { id = User.Identity.GetUserId() });
        }
        public ActionResult UserProfile(string id)
        {
            var viewModel = context.Doctors.SingleOrDefault(c => c.id == id);
            return View(viewModel);
        }
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }
    }
}