﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Data
{
    public class CustomerCode 
    {
        [Key]
        public String CustomerCodeId { get; set; }
        public String CustomerCodeDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt{get; set;}
    }
}
