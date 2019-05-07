using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSB100UserProfileWebSite.Models
{
    public class CreateAccountViewModel
    {
        [Required(ErrorMessage ="Du måste fylla i ett namn!")]
        public string firstname { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}