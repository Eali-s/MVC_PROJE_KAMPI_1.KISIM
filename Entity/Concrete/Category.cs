﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
      
    [StringLength(200)]
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }
        public ICollection<Heading> Headings { get; set; }
    }
