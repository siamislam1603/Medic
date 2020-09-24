using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Http.Cors;

namespace Medic.Controllers
{
    public class DiseaseDetectionController : Controller
    {
        
        // GET: DiseaseDetection
        public ActionResult Index()
        {
            return View();
        }
    }
}