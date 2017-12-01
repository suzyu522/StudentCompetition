using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Student_Competition.Models
{
    public class GuestResponse
    {
        // getters and setters for variables
        [Required(ErrorMessage = "Please enter your name")] // error message for the name attribute
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your social network interest")]
        public string SocialNetworkInterest { get; set; }

        [Required(ErrorMessage = "Please enter your technical interest")]
        public  TechnicalInterest? Interest { get; set; } // the TechnicalInterest incase the user did not select an option

       // [Required(ErrorMessage = "Please specify whether you'll attend")]
       // The user must press a button to select if they are attending or not
        public bool? WillAttend { get; set; } // the value of the button is determined in the homecontroller.cs
       
    }
}
