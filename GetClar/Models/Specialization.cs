//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetClar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specialization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialization()
        {
            this.StaffSpecializations = new HashSet<StaffSpecialization>();
        }
    
        public int Specialization_AutoId { get; set; }
        public string Specialization_Area { get; set; }
        public string Specialization_Category { get; set; }
        public Nullable<System.DateTime> Specialization_CreatedOn { get; set; }
        public Nullable<int> Specialization_CreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffSpecialization> StaffSpecializations { get; set; }
    }
}
