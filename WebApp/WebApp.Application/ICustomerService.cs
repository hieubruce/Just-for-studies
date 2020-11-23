using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.ViewModels.Catalog.Customers;
using WebApp.ViewModels.Common;

namespace WebApp.Application
{
    public interface ICustomerService
    {
        Task<int> Create(CustomerCreateRequest request);
        Task<int> Update(CustomerUpdateRequest request);
        Task<int> Delete(int customerId);
        Task<CustomerViewModel> GetById(int customerId);
        Task<List<CustomerViewModel>> GetAll();
        Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request);
    }
}
