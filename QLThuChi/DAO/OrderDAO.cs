using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuChi.DAO
{
    class OrderDAO
    {
        QuanLyThuChiEntities db = new QuanLyThuChiEntities();
        public List<Order> getAllListOrder()
        {
            return db.Orders.Select(s => s).ToList();
        }
        public Order getOrderByID(int id)
        {
            return db.Orders.Select(s => s).Where(s => s.OrderID == id).FirstOrDefault();
        }
        public List<Order> getListOrderByDate(DateTime dt)
        {
            return db.Orders.Select(s => s).Where(s => s.OrderDate == dt).ToList();
        }
        public void AddOrder(Order od)
        {
            db.Orders.Add(od);
            db.SaveChanges();
        }
        public int countTotalPriceCurrentday()
        {
            int result = 0;
            List<Order> listOrder = getListOrderByDate(DateTime.Now.Date);
            foreach (Order od in listOrder)
            {
                int QuantityTemp =(int) od.Quantity;
                int UnitPrice = (int)od.Product.UnitPrice;
                result += (QuantityTemp * UnitPrice);
            }
            return result;
        }
        public int countTotalPriceDayChosen(DateTime dt)
        {
            int result = 0;
            List<Order> listOrder = getListOrderByDate(dt);
            foreach (Order od in listOrder)
            {
                int QuantityTemp = (int)od.Quantity;
                int UnitPrice = (int)od.Product.UnitPrice;
                result += (QuantityTemp * UnitPrice);
            }
            return result;
        }

    }
}
