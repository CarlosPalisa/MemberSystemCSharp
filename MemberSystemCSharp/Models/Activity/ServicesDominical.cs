using MemberSystemCSharp.Models.Churchs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Activity
{
    public class ServicesDominical
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Pastor { get; set; }
        public DateTime Day { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }
        public DateTime Time { get; set; }
        public BranchChurchs Place { get; set; }

    }
}