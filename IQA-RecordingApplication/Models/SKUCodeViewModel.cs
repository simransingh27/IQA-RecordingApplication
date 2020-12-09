using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Models
{
    public class SKUCodeViewModel
    {
        [Required]
        [Key]
        public String SKUCodeId { get; set; }
        public String SKUCodeDescription { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
