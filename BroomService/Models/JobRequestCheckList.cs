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
    
    public partial class JobRequestCheckList
    {
        public long Id { get; set; }
        public string TaskDetail { get; set; }
        public Nullable<long> JobRequestId { get; set; }
        public Nullable<bool> IsDone { get; set; }
    
        public virtual JobRequest JobRequest { get; set; }
        public virtual JobRequest JobRequest1 { get; set; }
    }
}