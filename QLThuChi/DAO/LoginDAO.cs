using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuChi.DAO
{
    class LoginDAO
    {
        QuanLyThuChiEntities db = new QuanLyThuChiEntities();
        public int Login(string UserName, string Password)
        {
            int result = -1;
            List<Login> listLogin = db.Logins.Select(s=>s).Where(s => s.Username == UserName && s.Password == Password).ToList();
            if (listLogin.Count() == 0)
            {
                result = 0;
            }
            else
            {
                result = 1; 
            }
            return result; 
        }

        
    }
}
