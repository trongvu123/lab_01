using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iProductService;

        public ProductService()
        {
            iProductService = new ProductRepository();
        }

        public void DeleteProduct(Product p)
        {
            iProductService.DeleteProduct(p);
        }

        public ObservableCollection<Product> GetAllProducts()
        {
           return iProductService.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return iProductService.FindProductById(id);
        }

        public void SaveProduct(Product p)
        {
            iProductService.SaveProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            iProductService.UpdateProduct(p);
        }

    }
}
