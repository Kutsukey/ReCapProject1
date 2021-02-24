using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCapProject1.Business.Abstract;
using ReCapProject1.Entities;
using ReCapProject1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalsService _rentalsService;

        public RentalsController(IRentalsService rentalsDal)
        {
            _rentalsService = rentalsDal;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalsService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost("add")]
        public IActionResult Add(Rentals rentals)
        {
            var result = _rentalsService.Add(rentals);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Rentals rentals)
        {
            var result = _rentalsService.Update(rentals);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rentals rentals)
        {
            var result = _rentalsService.Delete(rentals);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
