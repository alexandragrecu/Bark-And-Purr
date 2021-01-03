using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Entities;
using PetShop.IServices;
using PetShop.Services;
using PetShop.Helpers;

namespace PetShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _service;
        public PetsController(IPetService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetPet(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdatePet(Pet pet)
        {
            _service.Update(pet);
            return Ok("The pet details have been successfully updated!");
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult CreatePet(Pet pet)
        {
            _service.Add(pet);
            return Ok("The pet has been successfully recorded in our database!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePet(int id)
        {
            _service.Delete(id);
            return Ok("The pet has been successfully deleted!");
        }
    }

}
