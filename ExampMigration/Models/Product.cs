﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExampMigration.Models
{
    public class Product
    {
        //prop:
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public ICollection<Sales> sales { get; set; }
    }
}