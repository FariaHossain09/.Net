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
    
    public partial class users1
    {
        public users1()
        {
            this.raisers = new HashSet<raiser>();
        }
    
        public int uId { get; set; }
        public string uName { get; set; }
        public string uUserName { get; set; }
        public string uEmail { get; set; }
        public string uGender { get; set; }
        public string uPassword { get; set; }
    
        public virtual ICollection<raiser> raisers { get; set; }
    }
}
