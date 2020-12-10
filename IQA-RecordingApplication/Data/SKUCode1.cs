using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Data
{
    public class SKUCode1
    {
        [Key]
       public int SKUCodeId { get; set; }
        public String SKU_Code { get; set; }
        public String SKUCodeDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
