using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExampMigration.Models
{
    public class Sales
    {
        //prop:
        [Key]
        public int id { get; set; }
        
        public int quantity { get; set; }
        public decimal unit { get; set; }

        public int product_id { get; set; }
        [ForeignKey("product_id")]
        public Product product { get; set; }

        public int customer_id { get; set; }
        [ForeignKey("customer_id")]
        public Customer customer { get; set; }
    }
}