using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssentManagementBusinessObject
{
    public class UserResponse
    {
        public int UserResponseCount { get; set; }
        public string UserResponseMessage { get; set; }
    }

    public class EmailResponse
    {
        public string EmailResponseMessage { get; set; }
    }

    public class MobileResponse
    {
        public string MobileResponseMessage { get; set; }
    }
}
