using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS_Rest_API.EntityLayer.Entities.Concrete
{
    public class Product:BaseEntity<int>
    {
        [Required, MinLength(2, ErrorMessage = "Mininum lenght is 2")]
        public string Name { get; set; }

        [Required, MinLength(2, ErrorMessage = "Mininum lenght is 2")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }  
      

        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "You must to choose a category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
