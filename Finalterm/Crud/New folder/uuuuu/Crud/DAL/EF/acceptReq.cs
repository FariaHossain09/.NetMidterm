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
    
    public partial class acceptReq
    {
        public int acceptedid { get; set; }
        public Nullable<int> aid { get; set; }
        public Nullable<int> eid { get; set; }
        public Nullable<int> raiserId { get; set; }
        public Nullable<int> uId { get; set; }
        public string uName { get; set; }
        public string uraiseAmount { get; set; }
        public string uDescription { get; set; }
        public string uAddress { get; set; }
        public string uEmail { get; set; }
        public string uMobile { get; set; }
        public string reqDate { get; set; }
        public string acceptDate { get; set; }
        public byte[] image { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual employee employee { get; set; }
    }
}
