//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SigortaMusTakipProjesi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusteriGorusme
    {
        public int Id { get; set; }
        public Nullable<int> MusId { get; set; }
        public Nullable<System.DateTime> GorusmeTarihi { get; set; }
        public string GorusmeKonusu { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Musteri Musteri { get; set; }
    }
}
