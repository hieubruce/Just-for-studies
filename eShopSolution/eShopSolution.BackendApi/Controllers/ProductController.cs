using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        //localhost:port/product
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var products = await _publicProductService.GetAll();
        //    return Ok(products);
        //}


        //localhost:port/products?PageIndex=1&PageSize=10&CategoryId=
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategoryId(request);

            return Ok(products);
        }

        //localhost:port/product/{id}
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _manageProductService.GetById(productId);
            if (product == null)
                return BadRequest("Can not find product");
            return Ok(product);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _manageProductService.Create(request);
            if (result == 0)
                return BadRequest();

            var product = await _manageProductService.GetById(result);

            return Created(nameof(GetById), product);
        }

        
        [HttpPut]
        public async Task<IActionResult> Update([FromForm]ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _manageProductService.Update(request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var result = await _manageProductService.Delete(productId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }


        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var result = await _manageProductService.UpdatePrice(productId, newPrice);
            if (result)
                return Ok();
            return BadRequest();
        }
    }
}
