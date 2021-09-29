using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AvailityRegistrationApp.API
{
    public class HttpClient
    {
        public class AvailityAPIResponse<ApiResponse>
        {
            public ApiResponse Data { get; set; }
            public string ErrorMessage { get; set; }
            public bool HasError
            {
                get
                {
                    return !string.IsNullOrEmpty(ErrorMessage);
                }
            }
        }

       
    }
}