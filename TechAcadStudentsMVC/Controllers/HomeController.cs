﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };
            return View();
        }

        public ActionResult Instructors()
        {
            return View();
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                Id = 1,
                FirstName = "Rick",
                LastName = "Ramen"
            },
            new Instructor
            {
                Id = 2,
                FirstName = "Brett",
                LastName = "Calandar"
            },
            new Instructor
            {
                Id = 3,
                FirstName = "Adam",
                LastName = "Smithonian"
            }
            };

            return View(instructors);
        }

        
    }
}