﻿namespace BusinessObjects
{
    public partial class Category
    {

        public Category()
        {
            Products = new HashSet<Product>();
        }


        public Category(int id, string name)
        {
            this.CategoryId = id;
            this.CategoryName = name;
        }


        public int CategoryId { get; set; }


        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
