//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_LOAI_DOI_TUONG
    {
        public DM_LOAI_DOI_TUONG()
        {
            this.DM_DOI_TUONG = new HashSet<DM_DOI_TUONG>();
            this.KHO_NHAP_KHO = new HashSet<KHO_NHAP_KHO>();
        }
    
        public string MA_LOAI_DOI_TUONG { get; set; }
        public string TEN_LOAI_DOI_TUONG { get; set; }
    
        public virtual ICollection<DM_DOI_TUONG> DM_DOI_TUONG { get; set; }
        public virtual ICollection<KHO_NHAP_KHO> KHO_NHAP_KHO { get; set; }
    }
}
