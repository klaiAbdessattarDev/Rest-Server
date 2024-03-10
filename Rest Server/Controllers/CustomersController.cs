using Microsoft.AspNetCore.Mvc;
using Rest_Server.Models;
using Rest_Server.Services;
using System;
using System.Collections.Generic;

namespace Rest_Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Customer> customers)
        {
            try
            {
                _customerService.AddCustomers(customers);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return _customerService.GetCustomers();
        }
    }
}
