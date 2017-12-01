using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Competition.Models
{
    public static class Repository
    {
        // list of responses to save all of the responeses of the students
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            // this method will return all of the students/responses
            get
            {
                return responses;
            }
        }

        // this method will add a new response/student to the list 
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }


    }

}
