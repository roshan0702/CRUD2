using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD2.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product Price is Required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Product Details Is Required")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Please Select Quantity of Product")]
        public int Quantity { get; set; }

        [Required]
        [Range(1,5, ErrorMessage ="Rating must be between 1 and 5")]
        public int Rating { get; set; }

    }

    public class ProductDetailsTable : DbContext
    {
        public DbSet<ProductDetails> ProductDetails { get; set; }
    }
}