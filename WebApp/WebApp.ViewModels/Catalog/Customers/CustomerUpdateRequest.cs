using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.ViewModels.Catalog.Customers
{
    public class CustomerUpdateRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
    }
}
