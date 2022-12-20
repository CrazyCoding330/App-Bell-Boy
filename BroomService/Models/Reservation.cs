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
    
    public partial class Reservation
    {
        public long ReservationId { get; set; }
        public string ReservationType { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public long ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string GuestName { get; set; }
        public string Email { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public string CheckIn { get; set; }
        public string Checkout { get; set; }
        public string Notice { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string PricePaid { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public string DepositPaid { get; set; }
        public string Phone { get; set; }
    }
}
