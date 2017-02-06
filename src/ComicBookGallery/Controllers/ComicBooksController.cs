using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spiderman survives...<strong>will Peter Parker?</strong><p>";

            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazba",
                "Colors: Edgar Delgado",
                "Letters: Chris Elipolous"
            };

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //{
            //    return Redirect("/");
            //}

            //return Content("Hello from the comic books controller!");
            return View();
        }

    }
}