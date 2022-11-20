using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Models
{
    public class UserEditProfile
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String ImageURL { get; set; }
        public IFormFile Image { get; set; }

    }
}
