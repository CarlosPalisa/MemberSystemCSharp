using MemberSystemCSharp.Models.Members;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Users
{
    public class User : Member
    {
       
        public string Email { get; set; } 
        public string Password { get; set; }

    }
}