//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fundProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class admin
    {
        public admin()
        {
            this.acceptReqs = new HashSet<acceptReq>();
        }
    
        public int aId { get; set; }
        public string aName { get; set; }
        public string aUserName { get; set; }
        public string aEmail { get; set; }
        public string aGender { get; set; }
        public string aPassword { get; set; }
    
        public virtual ICollection<acceptReq> acceptReqs { get; set; }
    }
}
