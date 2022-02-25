using QLThuChi.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuChi
{
    public partial class MainForm : Form
    {
        Ultis ultis = new Ultis();
        Category_BUS categoryBUS = new Category_BUS();
        Product_BUS productBUS = new Product_BUS();
        Order_BUS orderBUS = new Order_BUS();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //categoryBUS.loadComboBoxCategory(cbCategory);
            //productBUS.loadComboBoxProduct(cbProduct);
            //productBUS.loadDataGridViewProduct(dgProduct);
            //orderBUS.loadDataGridViewOrder(dgProduct, DateTimePicker.Value.Date);
            reloadAllComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //productBUS.AddProduct(cbProduct.SelectedText.ToString(), int.Parse(cbCategory.SelectedValue.ToString()), 12); ;
            if (int.Parse(cbProduct.SelectedIndex.ToString()) == -1)
            {
                ultis.ShowMessBox("Vui lòng chọn sản phẩm", "Warning");
            }
            else if (int.Parse(cbCategory.SelectedIndex.ToString()) == -1)
            {
                ultis.ShowMessBox("Vui lòng chọn loại sản phẩm", "Warning");
            }
            else if (txtQuantity.Text == "")
            {
                ultis.ShowMessBox("Vui lòng điền số lượng", "Warning");
            }
            else
            {
                orderBUS.addOrder(int.Parse(cbProduct.SelectedValue.ToString()), int.Parse(txtQuantity.Text), DateTimePicker.Value.Date);
                reloadAllComponent();
            }
        }
        private void reloadAllComponent()
        {
            categoryBUS.loadComboBoxCategory(cbCategory);
            productBUS.loadComboBoxProduct(cbProduct);
            orderBUS.loadDataGridViewOrder(dgProduct, DateTimePicker.Value.Date);
            orderBUS.countTotalPriceforOneDay(txtTotal);
            txtQuantity.Clear();
        }
    }
}
