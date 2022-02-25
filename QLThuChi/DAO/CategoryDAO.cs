using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuChi.DAO
{
    class CategoryDAO
    {
        QuanLyThuChiEntities db = new QuanLyThuChiEntities();
        public List<Category> getlistCategory()
        {
            return db.Categories.Select(s => s).ToList();
        }
        public Category getCategoryById(int id)
        {
            return db.Categories.Select(s => s).Where(s => s.CategoryID == id).FirstOrDefault();
        }
    }
}
