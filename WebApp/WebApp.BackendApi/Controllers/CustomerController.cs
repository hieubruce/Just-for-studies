using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Application;
using WebApp.ViewModels.Catalog.Customers;

namespace WebApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customService;

        public CustomerController(ICustomerService customService)
        {
            _customService = customService;
        }

        //localhost:port/product
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _customService.GetAll();
            return Ok(products);
        }

        //localhost:port/product/{id}
        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetById(int customerId)
        {
            var product = await _customService.GetById(customerId);
            if (product == null)
                return BadRequest("Can not find customer");
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CustomerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _customService.Create(request);
            if (result == 0)
                return BadRequest();

            var product = await _customService.GetById(result);

            return Created(nameof(GetById), product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] CustomerUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _customService.Update(request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{customerId}")]
        public async Task<IActionResult> Delete(int customerId)
        {
            var result = await _customService.Delete(customerId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
    }
}
