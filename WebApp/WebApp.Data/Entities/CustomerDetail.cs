using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Data.Entities
{
    public class CustomerDetail
    {
        public int CustomerId { get; set; }
        public Guid UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public AppUser AppUser { get; set; }
        public Customer Customer { get; set; }
    }
}
