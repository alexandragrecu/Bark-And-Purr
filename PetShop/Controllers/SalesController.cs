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
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _service;
        public SalesController(ISaleService service)
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
        public IActionResult GetSale(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        public IActionResult UpdateSale(Sale sale)
        {
            _service.Update(sale);
            return Ok("The pet details have been successfully updated!");
        }

        [HttpPost("create")]
        public IActionResult CreateSale(Sale sale)
        {
            _service.Insert(sale);
            return Ok("The sale has been successfully recorded in our database!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSale(int id)
        {
            _service.Delete(id);
            return Ok("The sale has been successfully deleted!");
        }
    }
}
