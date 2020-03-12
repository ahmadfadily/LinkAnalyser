using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinkAnalyser.Models;

namespace LinkAnalyser.Controllers
{
    public class LinkController : Controller
    {
        // GET: Link
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AnalysIN()
        {
            return View();
        }
        public ActionResult Submit()
        {
            LinkSource LS = new LinkSource();
            LS.Link = Request.Form["Link"];
            LS.LinkSorter();
            return View("ModelLink",LS);
        }

    }
}