using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Churchs
{
    public class BranchChurchs : CentralChurch
    {
        public int BranchChurchId { get; set; }
        public string BranchChurchName { get; set; }
    }
}