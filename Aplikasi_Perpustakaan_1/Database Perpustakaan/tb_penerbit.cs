//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikasi_Perpustakaan_1.Database_Perpustakaan
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_penerbit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_penerbit()
        {
            this.tb_buku = new HashSet<tb_buku>();
        }
    
        public int id_penerbit { get; set; }
        public string nama_penerbit { get; set; }
        public string alamat { get; set; }
        public string no_hp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_buku> tb_buku { get; set; }
    }
}
