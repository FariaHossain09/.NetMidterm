//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        public employee()
        {
            this.acceptReqs = new HashSet<acceptReq>();
            this.leaves = new HashSet<leave>();
        }
    
        public int eId { get; set; }
        public string eName { get; set; }
        public string eUserName { get; set; }
        public string eEmail { get; set; }
        public string eGender { get; set; }
        public string ePassword { get; set; }
    
        public virtual ICollection<acceptReq> acceptReqs { get; set; }
        public virtual ICollection<leave> leaves { get; set; }
    }
}
