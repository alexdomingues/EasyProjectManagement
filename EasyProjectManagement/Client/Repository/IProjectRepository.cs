﻿using EasyProjectManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyProjectManagement.Client.Repository
{
    public interface IProjectRepository
    {
        Task CreateProject(Project project);
    }
}
