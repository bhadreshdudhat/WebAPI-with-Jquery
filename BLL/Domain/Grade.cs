//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public string std_code { get; set; }
        public string std_fname { get; set; }
        public string std_lname { get; set; }
        public Nullable<decimal> gr_t1 { get; set; }
        public Nullable<decimal> gr_t2 { get; set; }
        public Nullable<decimal> gr_hw { get; set; }
        public Nullable<decimal> gr_pr { get; set; }
        public Nullable<decimal> gr_avg { get; set; }
        public string gr_lg { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
