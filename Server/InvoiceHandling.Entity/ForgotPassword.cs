//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceHandling.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ForgotPassword
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Nullable<int> ResetedBy { get; set; }
        public Nullable<System.DateTime> ResetedDate { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    }
}