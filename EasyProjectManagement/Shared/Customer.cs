using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EasyProjectManagement.Shared
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        //public string Acronym { get; set; }
        //public string PrimaryEmail { get; set; }
        //public string NamePrimaryEmail { get; set; }

    }
}
