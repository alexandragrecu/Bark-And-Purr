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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomersController(ICustomerService service)
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
        public IActionResult GetCustomer(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _service.Update(customer);
            return Ok("The customer details have been successfully updated!");
        }

        [HttpPost("create")]
        public IActionResult CreatePet(Customer customer)
        {
            _service.Add(customer);
            return Ok("The customer has been successfully recorded in our database!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePet(int id)
        {
            _service.Delete(id);
            return Ok("The customer has been successfully deleted!");
        }
    }
}
