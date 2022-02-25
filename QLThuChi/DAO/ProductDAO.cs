using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuChi.DAO
{
    class ProductDAO
    {
        QuanLyThuChiEntities db = new QuanLyThuChiEntities();
        public List<Product> getAllListProduct()
        {
            return db.Products.Select(s => s).ToList();
        }
        public Product getProductByID(int id)
        {
            return db.Products.Select(s =>s).Where(s=>s.ProductID == id).FirstOrDefault();
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChangesAsync();
        }
    }
}
