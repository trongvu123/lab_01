using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;
using Services;
using DataAccessLayer;
namespace Assignment_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IProductService _productService;
        private readonly ICatergoryService _catergoryService;
        public MainWindow()
        {
            InitializeComponent();
            _productService = new ProductService();
            _catergoryService = new CategoryService();
        }
        public void loadCategoryList()
        {
            try
            {
                var catList = _catergoryService.GetCategories();
                cboCategory.ItemsSource = catList;
                cboCategory.DisplayMemberPath = "CategoryName";
                cboCategory.SelectedValuePath = "CategoryId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }
        public void loadProductList()
        {
            try
            {
                var productList = _productService.GetAllProducts();
                dgData.ItemsSource = productList;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                resetInput();
            }
        }
        private void resetInput()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtUnitsInStock.Text = "";
            cboCategory.SelectedValue = 0;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadCategoryList();
            loadProductList();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var products = ProductDAO.GetProductsInDb();

                
                var lastProduct = products.LastOrDefault();
                Product product = new Product();
                product.ProductId = lastProduct.ProductId+1;
                product.ProductName = txtProductName.Text;
                product.UnitPrice = decimal.Parse(txtPrice.Text);
                product.UnitsInStock = short.Parse(txtUnitsInStock.Text);
                product.CategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                _productService.SaveProduct(product);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadProductList();
            }
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row =
            (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn =
            dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)RowColumn.Content).Text;
            Product product = _productService.GetProductById(Int32.Parse(id));
            txtProductID.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProductName;
            txtPrice.Text = product.UnitPrice.ToString();
            txtUnitsInStock.Text = product.UnitsInStock.ToString();
            cboCategory.SelectedValue = product.CategoryId;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtProductID.Text.Length > 0)
                {
                    int id = int.Parse(txtProductID.Text);

                    Product product = ProductDAO.GetProductById(id);
                    product.ProductName = txtProductName.Text;
                    product.UnitPrice = decimal.Parse(txtPrice.Text);
                    product.UnitsInStock = short.Parse(txtUnitsInStock.Text);
                    product.CategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                    _productService.UpdateProduct(product);

                }
                else
                {
                    MessageBox.Show("You must select product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadProductList();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtProductID.Text.Length > 0)
                {
                    int id = int.Parse(txtProductID.Text);
                    
                    Product product = ProductDAO.GetProductById(id);
                    //product.ProductName = txtProductName.Text;
                    //product.UnitPrice = decimal.Parse(txtPrice.Text);
                    //product.UnitsInStock = short.Parse(txtUnitsInStock.Text);
                    //product.CategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                    _productService.DeleteProduct(product);

                }
                else
                {
                    MessageBox.Show("You must select product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                loadProductList();
            }
        }
    }
}