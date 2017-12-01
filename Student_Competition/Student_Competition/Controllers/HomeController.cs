using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student_Competition.Models;


namespace Student_Competition.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // returns index.cshtml view
        }

        [HttpGet]
        public ViewResult RegistrationForm()
        {
            // returns the view of the Registration form
            return View();
        }

        [HttpPost]
        public ViewResult RegistrationForm(GuestResponse guestResponse, string submit)
        {
            if (ModelState.IsValid) // if there are no validation errors continue to the thanks page
            {
                if (submit == "true") // if the button selected was to accept the invitation then set the WillAttend attribute of the guestResponse object to true
                {
                    guestResponse.WillAttend = true;
                }
                else {
                    guestResponse.WillAttend = false; // if the user clicked the send regrets button then the value will be set to false
                }

                // add the response to the Repository and return the information to the thanks view
                Repository.AddResponse(guestResponse); 
                return View("Thanks", guestResponse); // send the guestResponse object to the thanks view so that it can display the name of the user and his interest

            }
            else
           {
               // there is a validation error
                return View();
            }
       }



        public ViewResult ListStudents()
        {
            // this method will return the ListStudents.cshtml view if the person selected they are attending the Student Competition
            // it will select all of the students who selected they will attend and send it to the view
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }


    }
}
