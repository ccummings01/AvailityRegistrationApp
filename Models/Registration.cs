using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static AvailityRegistrationApp.API.HttpClient;

namespace AvailityRegistrationApp.Models
{
    public class Registration
    {
        public string FirstName { get; set; } //
        public string LastName { get; set; }//
        public int NPINumber { get; set; }//
        public string BusinessAddress { get; set; }
        public string PhoneNumber { get; set; } //
        public string EmailAddress {get;set;}



      
        public static AvailityAPIResponse<Registration> RegisterForAvaility(Registration Registration)
        {
            AvailityAPIResponse<Registration> registration = new AvailityAPIResponse<Registration>();
            // make an instance of the client 
            try
            {
                // set the request object equal to the client response. 
                //registration = client.FunctionThatCallsAPI<Registration>(Registration);
            }
            catch (Exception ex)
            {
                // write to logger "Registration.RegisterForAvaility()" , ex.Message
                throw;
            }

            return registration;
        }
    }



   
}