//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TACGIA
    {
        public TACGIA()
        {
            this.VIETSACHes = new HashSet<VIETSACH>();
        }
    
        public int MaTG { get; set; }
        public string TenTG { get; set; }
        public string Diachi { get; set; }
        public string Tieusu { get; set; }
        public string Dienthoai { get; set; }
    
        public virtual ICollection<VIETSACH> VIETSACHes { get; set; }
    }
}
