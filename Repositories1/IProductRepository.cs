using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        // Lưu một sản phẩm
        void SaveProduct(Product product);

        // Xóa một sản phẩm
        void DeleteProduct(Product product);

        // Cập nhật một sản phẩm
        void UpdateProduct(Product product);

        // Lấy danh sách tất cả sản phẩm
        ObservableCollection<Product> GetAllProducts();

        // Lấy một sản phẩm theo ID
        Product FindProductById(int id);
    }
}
