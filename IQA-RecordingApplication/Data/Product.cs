﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public String ProductName { get; set; }

        public String ProductDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
