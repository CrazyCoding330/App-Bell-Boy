//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BroomService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProviderScheduleByDate
    {
        public long Id { get; set; }
        public Nullable<long> ProviderId { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string Date { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> IsAbsent { get; set; }
    }
}