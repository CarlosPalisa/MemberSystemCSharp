using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Members
{
    public class EvangelicalHistory
    {
        public DateTime day { get; set; }
        public DateTime month { get; set; }
        public DateTime year { get; set; }
        public string NameBaptismChurch { get; set; }
        public string AdressBaptismChurch { get; set; }
        public string CityBaptismChurch { get; set; }
        public string PhoneBaptismChurch { get; set; }
        public string ComentsBaptismChurch { get; set; }

    }
}