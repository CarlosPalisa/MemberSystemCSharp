using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Churchs
{
    public class CentralChurch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        //public Groups? Groups { get; set; }
        //public MemberLeader? MemberLeader { get; set; }
        //public MemberPastor MemberPastor { get; set; }
    }
}