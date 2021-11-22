using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyProjectManagement.Shared;
using EasyProjectManagement.Client.Helpers;

namespace EasyProjectManagement.Client.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/projects";
        public ProjectRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateProject(Project project)
        {
            var response = await httpService.Post(url, project);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

        }


    }
}
