using QLThuChi.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuChi.BUS
{
    class Category_BUS
    {
        CategoryDAO daoCategory = new CategoryDAO();
        
        public void loadComboBoxCategory(ComboBox ComboBoxname)
        {
            
            ComboBoxname.DataSource = null;
            ComboBoxname.DataSource = daoCategory.getlistCategory();
            ComboBoxname.DisplayMember = "CategoryName";
            ComboBoxname.ValueMember = "CategoryID";
            ComboBoxname.SelectedIndex = -1;
            ComboBoxname.Text = "----Select Category----";

        }
    }
}
