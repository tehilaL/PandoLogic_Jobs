//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_views
    {
        public int viewNum { get; set; }
        public Nullable<int> jobNum { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual tbl_jobs tbl_jobs { get; set; }
    }
}
