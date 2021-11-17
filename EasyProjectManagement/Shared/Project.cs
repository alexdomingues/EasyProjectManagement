using System.ComponentModel.DataAnnotations;

namespace EasyProjectManagement.Shared
{
    public class Project
    {
        public int Id { get; set; }

        //  (ErrorMessage = "This field is required") if we want to change the error message
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string State { get; set; }

        // public int CustomerId { get; set; }

        //public DateTime kickoffDate { get; set; };
        //public DateTime expectedEndDate { get; set; };

    }
}
