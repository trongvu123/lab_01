﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessObjects
{
    public partial class Product
    {
        public Product()
        {
        }

        public Product(int productId, string productName, int categoryId, short unitsInStock, decimal unitPrice)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.CategoryId = categoryId;
            this.UnitsInStock = unitsInStock;
            this.UnitPrice = unitPrice;
        }


        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int? CategoryId { get; set; }

        public short? UnitsInStock { get; set; }

        public decimal? UnitPrice { get; set; }

        public virtual Category Category { get; set; }
    }
}
