using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssentManagementBusinessObject
{
    public class UserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string ProfileImage { get; set; }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
