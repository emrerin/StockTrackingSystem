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
    
    public partial class tblKullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKullanici()
        {
            this.tblBelgeler = new HashSet<tblBelgeler>();
        }
    
        public int KullaniciID { get; set; }
        public int PersonelID { get; set; }
        public string KullaniciAdi { get; set; }
        public bool YetkiliID { get; set; }
        public string Sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBelgeler> tblBelgeler { get; set; }
        public virtual tblPersonel tblPersonel { get; set; }
    }
}
