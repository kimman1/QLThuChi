using QLThuChi.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLThuChi.BUS
{
    class Login_BUS
    {
        LoginDAO Login_DAO = new LoginDAO();
        Ultis ultis = new Ultis();
        public int Login(string Username, string Password)
        {
            int result_Login = -1;
            int result = Login_DAO.Login(Username, Password);
            if (result == 0)
            {
                ultis.ShowMessBox("Đăng Nhập thất bại", "Warning");
                result_Login = 0;
            }
            else if (result == 1)
            {
                ultis.ShowMessBox("Đăng Nhập thành công", "Info");
                result_Login = 1;
            }
            else if (result == -1)
            {
                ultis.ShowMessBox("Contact Administrator", "Info");
            }
            return result_Login;
        }
    }
}
