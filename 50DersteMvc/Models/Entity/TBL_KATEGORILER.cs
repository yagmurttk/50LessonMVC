//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _50DersteMvc.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_KATEGORILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_KATEGORILER()
        {
            this.TBL_URUNLER = new HashSet<TBL_URUNLER>();
        }

        public short KATEGORIID { get; set; }
        [Required(ErrorMessage = "Kategori Ad�n� Bo� B�rakamazs�n�z...!")]
        public string KATEGORIADI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_URUNLER> TBL_URUNLER { get; set; }
    }
}
