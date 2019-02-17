﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { set; get; }

        [StringLength(20)]
        [DisplayName("Nombre del Producto")]
        public string Name { set; get; }
        public string Description { set; get; }

        [Range(0, 1000)]
        public decimal Price { set; get; }
        public string Category { set; get; }
        public string Image { set; get; }

        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}