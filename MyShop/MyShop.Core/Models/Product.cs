using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product : BaseEntity
    {
        [StringLength(20)]
        [DisplayName("Nombre del Producto")]
        public string Name { set; get; }

        [DisplayName("Descripción")]
        public string Description { set; get; }

        [Range(0, 1000)]
        [DisplayName("Precio")]
        public decimal Price { set; get; }

        [DisplayName("Categoría")]
        public string Category { set; get; }

        [DisplayName("Imagen")]
        public string Image { set; get; }
    }
}
