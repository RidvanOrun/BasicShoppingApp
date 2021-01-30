using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS_Rest_API.EntityLayer.Entities.Concrete
{
    public class Category:BaseEntity<int>
    {
        [Required(ErrorMessage = "Must type a title")]
        [MinLength(2, ErrorMessage = "Minimum lenght is 2")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only allowed letters")]
        public string Name { get; set; }

        [Required]
        public string Slug { get; set; }

        public List<Product> Products { get; set; }
    }
}
