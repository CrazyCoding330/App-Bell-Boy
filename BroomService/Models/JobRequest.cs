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
    
    public partial class JobRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobRequest()
        {
            this.JobRequestCheckLists = new HashSet<JobRequestCheckList>();
            this.JobRequestCheckLists1 = new HashSet<JobRequestCheckList>();
            this.JobRequestQuoteTypes = new HashSet<JobRequestQuoteType>();
            this.JobRequestQuoteTypes1 = new HashSet<JobRequestQuoteType>();
            this.PropertyJobRequests = new HashSet<PropertyJobRequest>();
            this.PropertyJobRequests1 = new HashSet<PropertyJobRequest>();
            this.RejectJobRequests = new HashSet<RejectJobRequest>();
            this.JobRequestRefImages = new HashSet<JobRequestRefImage>();
        }
    
        public long Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<decimal> QuotePrice { get; set; }
        public Nullable<bool> IsQuoteApproved { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public Nullable<bool> IsPaymentDone { get; set; }
        public Nullable<bool> HasPrice { get; set; }
        public Nullable<bool> IsFastOrder { get; set; }
        public string FastOrderName { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<int> RepeatService { get; set; }
        public Nullable<bool> IsAddedBySupervisor { get; set; }
        public Nullable<long> SupervisorId { get; set; }
        public Nullable<decimal> ClientQuotePrice { get; set; }
        public Nullable<bool> RequestSupervisior { get; set; }
        public Nullable<decimal> ServicePrice { get; set; }
        public Nullable<long> QuotedBy { get; set; }
        public string PayPageId { get; set; }
        public string SaleUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRequestCheckList> JobRequestCheckLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRequestCheckList> JobRequestCheckLists1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRequestQuoteType> JobRequestQuoteTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRequestQuoteType> JobRequestQuoteTypes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyJobRequest> PropertyJobRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyJobRequest> PropertyJobRequests1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RejectJobRequest> RejectJobRequests { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRequestRefImage> JobRequestRefImages { get; set; }
    }
}
