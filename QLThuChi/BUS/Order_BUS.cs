using QLThuChi.DAO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuChi.BUS
{
    class Order_BUS
    {
        OrderDAO Order_DAO = new OrderDAO();
        public void addOrder( int ProductID, int Quantity, DateTime dt)
        {
            Order od = new Order();
            od.ProductID = ProductID;
            od.OrderDate = dt;
            od.Quantity = Quantity;
            Order_DAO.AddOrder(od);
        }
        public void loadDataGridViewOrder(DataGridView dg, DateTime dt)
        {
            dg.DataSource = null;
            dg.DataSource = Order_DAO.getListOrderByDate(dt);
            dg.Columns["Product"].Visible = false;
            dg.Columns["ProductID"].Visible = false;
        }
        public void countTotalPriceforOneDay(TextBox textbox)
        {
            textbox.Clear();
            textbox.Text =  Order_DAO.countTotalPriceCurrentday().ToString("N1",CultureInfo.InvariantCulture) ;
                
        }
    }
}
