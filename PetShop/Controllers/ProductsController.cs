using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Entities;
using PetShop.IServices;

namespace PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        public IActionResult UpdateProduct(Product product)
        {
            _service.Update(product);
            return Ok("The Product details have been successfully updated!");
        }

        [HttpPost("create")]
        public IActionResult CreateProduct(Product product)
        {
            _service.Add(product);
            return Ok("The product has been successfully recorded in our database!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _service.Delete(id);
            return Ok("The product has been successfully deleted!");
        }
    }
}
