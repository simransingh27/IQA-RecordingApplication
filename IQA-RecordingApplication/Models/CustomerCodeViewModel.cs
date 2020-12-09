using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Models
{
    public class CreateCustomerCodeViewModel
    {
        [Required]
        public String CustomerCodeId { get; set; }
        public String CustomerCodeDescription { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class DetailsCustomerCodeViewModel
    {
        
        public String CustomerCodeId { get; set; }
        public String CustomerCodeDescription { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
