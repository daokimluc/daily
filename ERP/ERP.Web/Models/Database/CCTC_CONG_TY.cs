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
    
    public partial class CCTC_CONG_TY
    {
        public CCTC_CONG_TY()
        {
            this.DM_CHUNG_TU = new HashSet<DM_CHUNG_TU>();
            this.DM_DOI_TUONG = new HashSet<DM_DOI_TUONG>();
            this.DM_KHO = new HashSet<DM_KHO>();
            this.DM_TK_NGAN_HANG_NOI_BO = new HashSet<DM_TK_NGAN_HANG_NOI_BO>();
            this.HT_NGUOI_DUNG = new HashSet<HT_NGUOI_DUNG>();
            this.CCTC_CONG_TY1 = new HashSet<CCTC_CONG_TY>();
            this.CCTC_PHONG_BAN = new HashSet<CCTC_PHONG_BAN>();
            this.CN_NGHIEP_VU = new HashSet<CN_NGHIEP_VU>();
        }
    
        public string MA_CONG_TY { get; set; }
        public string TEN_CONG_TY { get; set; }
        public Nullable<System.DateTime> NGAY_THANH_LAP { get; set; }
        public string EMAIL { get; set; }
        public string FAX { get; set; }
        public string SDT { get; set; }
        public string MST { get; set; }
        public string LOGO { get; set; }
        public string DIA_CHI { get; set; }
        public string DIA_CHI_XUAT_HOA_DON { get; set; }
        public string CONG_TY_ME { get; set; }
        public string CAP_TO_CHUC { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual ICollection<DM_CHUNG_TU> DM_CHUNG_TU { get; set; }
        public virtual ICollection<DM_DOI_TUONG> DM_DOI_TUONG { get; set; }
        public virtual ICollection<DM_KHO> DM_KHO { get; set; }
        public virtual ICollection<DM_TK_NGAN_HANG_NOI_BO> DM_TK_NGAN_HANG_NOI_BO { get; set; }
        public virtual ICollection<HT_NGUOI_DUNG> HT_NGUOI_DUNG { get; set; }
        public virtual ICollection<CCTC_CONG_TY> CCTC_CONG_TY1 { get; set; }
        public virtual CCTC_CONG_TY CCTC_CONG_TY2 { get; set; }
        public virtual CCTC_MO_HINH_CONG_TY CCTC_MO_HINH_CONG_TY { get; set; }
        public virtual ICollection<CCTC_PHONG_BAN> CCTC_PHONG_BAN { get; set; }
        public virtual ICollection<CN_NGHIEP_VU> CN_NGHIEP_VU { get; set; }
    }
}
