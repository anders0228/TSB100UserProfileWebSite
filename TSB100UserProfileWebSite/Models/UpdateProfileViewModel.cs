using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TSB100UserProfileWebSite.Models
{
    public class UpdateProfileViewModel
    {
        public string personalnumber { get; set; }
        public string userCity { get; set; }
        public string userAddress { get; set; }
        public string userZipCode { get; set; }
        public string userPhoneNumber { get; set; }
        public string userProfilePicture { get; set; }
    }
}