﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Data.EF;
using WebApp.Data.Entities;
using WebApp.ViewModels.Catalog.Customers;
using WebApp.ViewModels.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly WebAppDbContext _context;

        public CustomerService(WebAppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CustomerCreateRequest request)
        {
            var customer = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Dob = request.Dob,
                Address = request.Address,
                
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer.Id;

        }

        public async Task<int> Delete(int customerId)
        {
            var customer = await _context.Customers.FindAsync(customerId);
            if (customer == null)
                throw new Exception($"Can not find customer: {customerId}");

            _context.Customers.Remove(customer);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CustomerViewModel>> GetAll()
        {
            var query = from c in _context.Customers
                        select new { c};
            var data = await query.Select(x => new CustomerViewModel()
            {
                Id = x.c.Id,
                FirstName = x.c.FirstName,
                LastName = x.c.LastName,
                PhoneNumber = x.c.PhoneNumber,
                Address = x.c.Address,
                Email = x.c.Email,
                Dob = x.c.Dob,

            }).ToListAsync();
            return data;
        }

        public Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerViewModel> GetById(int customerId)
        {
            var customer = await _context.Customers.FindAsync(customerId);
            var customerViewModel = new CustomerViewModel()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                Address = customer.Address,
                Email = customer.Email,
                Dob = customer.Dob,
            };
            return customerViewModel;
        }

        public async Task<int> Update(CustomerUpdateRequest request)
        {
            var customer = await _context.Customers.FindAsync(request.Id);
            if (customer == null) throw new Exception($"Can not find customer: {request.Id}");
            customer.FirstName = request.FirstName;
            customer.LastName = request.LastName;
            customer.Address = request.Address;
            customer.Dob = request.Dob;

            return await _context.SaveChangesAsync();


        }
    }
}
