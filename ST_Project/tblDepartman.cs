//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ST_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDepartman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartman()
        {
            this.tblDemirbas = new HashSet<tblDemirbas>();
            this.tblOda = new HashSet<tblOda>();
        }
    
        public int DepartmanID { get; set; }
        public string DepartmanAdi { get; set; }
        public int FakulteID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDemirbas> tblDemirbas { get; set; }
        public virtual tblFakulte tblFakulte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOda> tblOda { get; set; }
    }
}
