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
    
    public partial class tb_pegawai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_pegawai()
        {
            this.tb_user = new HashSet<tb_user>();
        }
    
        public int id_pegawai { get; set; }
        public string nama_pegawai { get; set; }
        public string jenis_kelamin { get; set; }
        public string alamat { get; set; }
        public string no_hp { get; set; }
        public string tempat_lahir { get; set; }
        public System.DateTime tanggal_lahir { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_user> tb_user { get; set; }
    }
}
