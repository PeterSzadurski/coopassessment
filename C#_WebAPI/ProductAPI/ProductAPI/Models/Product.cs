using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductAPI.Models
{
    // adding [Table("Product")] solved a primary key issue:
    //https://stackoverflow.com/questions/20203492/entitytype-has-no-key-defined-error
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}