//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depo.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblFirmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblFirmalar()
        {
            this.tblMalzeme = new HashSet<tblMalzeme>();
            this.tblYiyecek = new HashSet<tblYiyecek>();
        }
    
        public int ID { get; set; }
        public string isim { get; set; }
        public string sektor { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMalzeme> tblMalzeme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblYiyecek> tblYiyecek { get; set; }
    }
}