using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static ObservableCollection<Product> listProducts = new ObservableCollection<Product>
        {
            new Product(1, "Chai", 3, 12, 18),
            new Product(2, "Chang", 1, 23, 19),
            new Product(3, "Aniseed Syrup", 2, 23, 10)
        };

        public static ObservableCollection<Product> GetProductsInDb()
        {
            return new ObservableCollection<Product>(listProducts);
        }

        public static void SaveProduct(Product product)
        {
            if (product != null)
            {
                listProducts.Add(product);
            }
        }

        // Cập nhật thông tin cho một sản phẩm
        public static void UpdateProduct(Product updatedProduct)
        {
            var product = listProducts.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if (product != null)
            {
                product.ProductName = updatedProduct.ProductName;
                product.UnitPrice = updatedProduct.UnitPrice;
                product.UnitsInStock = updatedProduct.UnitsInStock;
                product.CategoryId = updatedProduct.CategoryId;
            }
        }

        // Xóa một sản phẩm khỏi danh sách
        public static void DeleteProduct(Product productToDelete)
        {
            var product = listProducts.FirstOrDefault(p => p.ProductId == productToDelete.ProductId);
            if (product != null)
            {
                listProducts.Remove(product);
            }
        }

        // Lấy một sản phẩm theo ID
        public static Product GetProductById(int id)
        {
            return listProducts.FirstOrDefault(product => product.ProductId == id);
        }
    }
}
