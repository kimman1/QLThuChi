using QLThuChi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuChi.DAO
{
    class ProductViewModelDAO
    {
        QuanLyThuChiEntities db = new QuanLyThuChiEntities();
        public List<ProductViewModel> convertToListProductViewModel(List<Product> listProduct)
        {
            List<ProductViewModel> Temp = new List<ProductViewModel>();
            foreach (Product product in listProduct)
            {
                ProductViewModel pvm = new ProductViewModel();
                pvm.CategoryID = (int)product.CategoryID;
                pvm.ProductID = product.ProductID;
                pvm.ProductName = product.ProductName;
                pvm.UnitPrice = (int)product.UnitPrice;
                pvm.CategoryName = db.Categories.Where(s => s.CategoryID == product.CategoryID).Select(s=>s.CategoryName).FirstOrDefault();
                Temp.Add(pvm);
            }
            return Temp;
        }
    }
}
