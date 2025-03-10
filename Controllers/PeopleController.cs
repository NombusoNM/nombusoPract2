
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nombusoStudyGroup.Models;


namespace nombusoStudyGroup.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { StudentNumber = 12345, Name = "Nombuso", Surname = "Mdletshe", Email = "nombuso.mdletshe@tuks.co.za", myLink = "~\\Content\\HTML\\Nombuso.html" });
            people.Add(new Models.PersonModel { StudentNumber = 12346, Name = "Mbalenhle", Surname = "Mdletshe", Email = "mbalenhle.mdletshe@tuks.co.za", myLink = "~\\Content\\HTML\\Mbalenhle.html" });
            people.Add(new Models.PersonModel { StudentNumber = 12347, Name = "Nothando", Surname = "Mdletshe", Email = "nothando.mdletshe@tuks.co.za", myLink = "~\\Content\\HTML/Nothando.html" });
            people.Add(new Models.PersonModel { StudentNumber = 12348, Name = "Laska", Surname = "Mdletshe", Email = "laska.mdletshe@tuks.co.za", myLink = "~\\Content\\HTML\\Laska.html" });
            people.Add(new Models.PersonModel { StudentNumber = 12349, Name = "Lola", Surname = "Mdletshe", Email = "lola.mdletshe@tuks.co.za", myLink = "~\\Content\\HTML\\Lola.html" });


            return View(people);
        }
    }
}