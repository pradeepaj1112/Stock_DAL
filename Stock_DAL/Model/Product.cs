using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_DAL.Model
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? ProductImage { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 10)]
        public string ?  ProductName { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 10)]
        public string ? Brand { get; set; }
        [Required]
        [StringLength(maximumLength:200,MinimumLength=50)]
        public string?  Description { get; set; }
        [Required]
        [Range (minimum: 0, maximum: 500)]
        public int AvaliableCount { get; set; }

        [Required]
        public float Price { get; set; }
        public virtual Cart? Cart { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Product_Details? Product_Details { get; set; }



    }
}
