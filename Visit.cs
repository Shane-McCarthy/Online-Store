//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspIndAssignment1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public Visit()
        {
            this.ProductVisits = new HashSet<ProductVisit>();
        }
    
        public string sessionID { get; set; }
    
        public virtual ICollection<ProductVisit> ProductVisits { get; set; }
    }
}
