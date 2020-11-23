using System;
using System.Collections.Generic;
using System.Text;
using WebApp.ViewModels.Common;

namespace WebApp.ViewModels.Catalog.Customers
{
    public class GetCustomerPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> UserId { get; set; }
    }
}
