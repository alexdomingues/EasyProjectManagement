using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProjectManagement.Shared
{
    public class ProjectTask : Project 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string ETA { get; set; }
        public bool ShowStopper { get; set; }
        public string Type { get; set; }

    }
}
