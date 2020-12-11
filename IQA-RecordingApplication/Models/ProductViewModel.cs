using Microsoft.AspNetCore.Mvc.Rendering;
using IQA_RecordingApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        [Required]
        public String ProductName { get; set; }

        public String ProductDescription { get; set; }
        public String Tag { get; set; }

        public SKUCodeViewModel SKUCode { get; set; }
        public String SKUCodeId { get; set; }

     
        public CreateCustomerCodeViewModel CustomerCode { get; set; }
        public string CustomerCodeId { get; set; }

      
        public ProductTypeViewModel ProductType { get; set; }
        public int ProductTypeId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<SelectListItem> ProductTypes { get; set; }

        public IEnumerable<SelectListItem> CustomerCodes { get; set; }

        public IEnumerable<SelectListItem> SKUCodes { get; set; }
        
    }
}
