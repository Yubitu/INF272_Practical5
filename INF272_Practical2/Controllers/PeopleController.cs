using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Practical2.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult ListStudents()
        {
            //List using Person model
            List<Models.PersonModel> students = new List<Models.PersonModel>
            {
                //values for properties to be used in table
                new Models.PersonModel { StudentNumber = "u23614286", FirstName = "Tristan", LastName = "Bosman", Email = "u23614286@tuks.co.za", MyLink = Url.Content("~/HTML/Tristan.html") },
                new Models.PersonModel { StudentNumber = "u23541416", FirstName = "Tayla", LastName = "Walther", Email = "u23541416@tuks.co.za", MyLink = Url.Content("~/HTML/Tayla.html") },
                new Models.PersonModel { StudentNumber = "u23543681", FirstName = "Tia", LastName = "Naidoo", Email = "u23543681@tuks.co.za", MyLink = Url.Content("~/HTML/Tia.html") },
                new Models.PersonModel { StudentNumber = "u24650677", FirstName = "Ashton", LastName = "Theron", Email = "u24650677@tuks.co.za", MyLink = Url.Content("~/HTML/Ashton.html") },
                new Models.PersonModel { StudentNumber = "u24924718", FirstName = "Gundo", LastName = "Ndou", Email = "u24924718@tuks.co.za", MyLink = Url.Content("~/HTML/Gundo.html") }
            };
            //return the view
            return View(students);
        }
    }
}