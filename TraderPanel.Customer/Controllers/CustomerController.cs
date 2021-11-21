using Microsoft.AspNetCore.Mvc;
using TraderPanel.Customer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TraderPanel.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        public CustomerController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            return Ok(await _repository.Customers.GetAllAsync());
        }
    }
}
