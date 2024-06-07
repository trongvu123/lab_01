using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {

        public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);


        public Product FindProductById(int id) => ProductDAO.GetProductById(id);

        public ObservableCollection<Product> GetAllProducts()
        {
            return ProductDAO.GetProductsInDb();
        }

        public void SaveProduct(Product product) => ProductDAO.SaveProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);
    }
}
