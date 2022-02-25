using QLThuChi.DAO;
using QLThuChi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuChi.BUS
{
    class Product_BUS
    {
        ProductDAO product_DAO = new ProductDAO();
        ProductViewModelDAO productViewModel_DAO = new ProductViewModelDAO();
        public void loadComboBoxProduct(ComboBox comboBoxName)
        {
            comboBoxName.DataSource = null;
            comboBoxName.DataSource = product_DAO.getAllListProduct();
            comboBoxName.DisplayMember = "ProductName";
            comboBoxName.ValueMember = "ProductID";
            comboBoxName.SelectedIndex = -1;
            comboBoxName.Text = "----Select Product----";
        }
        public void loadDataGridViewProduct(DataGridView dg)
        {
            List<ProductViewModel> ListProductViewModel =  productViewModel_DAO.convertToListProductViewModel(product_DAO.getAllListProduct());
            //dg.DataSource = null;
            dg.DataSource = ListProductViewModel;
        }

        public void AddProduct( string ProductName, int CategoryID, int UnitPrice)
        {
            Product product = new Product();
            product.CategoryID = CategoryID;
            product.ProductName = ProductName.ToString().Trim();
            product.UnitPrice = UnitPrice;
            product_DAO.AddProduct(product);
        }
    }
}
