using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Members
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Numeration { get; set; }
        public bool? IsApartament { get; set; }
        public int? Floor { get; set; }

    }
}