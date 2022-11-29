using MemberSystemCSharp.Models.Churchs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberSystemCSharp.Models.Members
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int MemberNumber { get; set; }
        public List<TypeMember> Type { get; set; }
        public List<Adress> Adress { get; set; }
        public List<BranchChurchs> ServicesChurchs{ get; set;}
        public bool IsActive { get; set; }
        public bool IsBaptized { get; set; }
        public List<EvangelicalHistory> EvanHistory { get; set; }
        public List<CategoryMembers> Category { get; set; }

    }   



}