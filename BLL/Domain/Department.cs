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
    
    public partial class Department
    {
        public string dept_code { get; set; }
        public string dept_name { get; set; }
        public string dept_phone { get; set; }
        public string fac_code { get; set; }
    
        public virtual Faculty Faculty { get; set; }
    }
}
