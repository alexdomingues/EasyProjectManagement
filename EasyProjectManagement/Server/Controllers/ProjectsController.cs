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
    public class ProjectsController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        public ProjectsController (ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Project project)
        {
            context.Add(project);
            await context.SaveChangesAsync();
            return project.Id;
        }
    }

}
