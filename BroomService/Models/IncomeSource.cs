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
    
    public partial class IncomeSource
    {
        public int Id { get; set; }
        public Nullable<int> User_Id { get; set; }
        public Nullable<decimal> Income { get; set; }
        public Nullable<decimal> Pending { get; set; }
        public Nullable<decimal> Outcome { get; set; }
    }
}
