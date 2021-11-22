using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyProjectManagement.Shared;
using EasyProjectManagement.Client.Helpers;

namespace EasyProjectManagement.Client.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/customers";
        public CustomerRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateCustomer(Customer customer)
        {
            var response = await httpService.Post(url, customer);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

        }


    }
}
