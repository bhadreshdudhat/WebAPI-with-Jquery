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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Std_Act = new HashSet<Std_Act>();
        }
    
        public string std_code { get; set; }
        public string std_fname { get; set; }
        public string std_lname { get; set; }
        public string std_gend { get; set; }
        public string maj_code { get; set; }
        public Nullable<System.DateTime> std_dob { get; set; }
    
        public virtual Grade Grade { get; set; }
        public virtual Major Major { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Std_Act> Std_Act { get; set; }
    }
}