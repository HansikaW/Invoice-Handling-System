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
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.WorkOrders = new HashSet<WorkOrder>();
            this.QuoteRequests = new HashSet<QuoteRequest>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string PropertyHolderName { get; set; }
        public string PHAddress { get; set; }
        public string PHPhoneNumber { get; set; }
        public string AssignStatus { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public int CallerSystemUserId { get; set; }
        public int JobCategoryId { get; set; }
        public Nullable<decimal> MaximumBudget { get; set; }
        public Nullable<int> ServiceProviderId { get; set; }
        public string Purpose { get; set; }
    
        public virtual SystemUser SystemUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteRequest> QuoteRequests { get; set; }
        public virtual JobCategory JobCategory { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
    }
}
