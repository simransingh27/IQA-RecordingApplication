﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Data
{
    public class ErrorMessageTrack
    {
        [Key]
        public int ErrorMessageTrackId { get; set; }
       
        [ForeignKey("CustomerCodeId")]
        public CustomerCode CustomerCode { get; set; }
        public string CustomerCodeId { get; set; }
    
        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
            
        [ForeignKey("SKUCodeId")]
        public SKUCode SKUCode { get; set; }
        public String SKUCodeId { get; set; }
      
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}