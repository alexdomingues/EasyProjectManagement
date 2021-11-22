using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyProjectManagement.Shared;

namespace EasyProjectManagement.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public CustomersController (ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Customer customer)
        {
            context.Add(customer);
            await context.SaveChangesAsync();
            return customer.CustomerId;
        }
    }

}
