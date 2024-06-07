using System.Collections.Generic;
using BusinessObjects;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            // Khởi tạo các danh mục
            var beverages = new Category(1, "Beverages");
            var condiments = new Category(2, "Condiments");
            var confections = new Category(3, "Confections");
            var dairy = new Category(4, "Dairy Products");
            var grains = new Category(5, "Grains/Cereals");
            var meat = new Category(6, "Meat/Poultry");
            var produce = new Category(7, "Produce");
            var seafood = new Category(8, "Seafood");

            // Tạo danh sách các danh mục
            var listCategories = new List<Category>
            {
                beverages,
                condiments,
                confections,
                dairy,
                grains,
                meat,
                produce,
                seafood
            };

            return listCategories;
        }
    }
}
