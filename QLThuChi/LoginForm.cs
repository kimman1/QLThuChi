using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QLThuChi.BUS;

namespace QLThuChi
{
    public partial class LoginForm : Form
    {
        Ultis ultis = new Ultis();
        Login_BUS Bus_Login = new Login_BUS();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                ultis.ShowMessBox("Tài Khoản không được để trống", "Warning");
            }
            else if (txtPassword.Text == "")
            {
                ultis.ShowMessBox("Mật Khẩu không được để trống", "Warning");
            }
            else
            {
                //ultis.ShowMessBox("Đăng nhập thành công", "Info");
                int result_Login = Bus_Login.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (result_Login == 1)
                {
                    this.Hide();
                    MainForm form = new MainForm();
                    form.Show();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result_Dialog = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result_Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
            private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                 if (e.CloseReason == CloseReason.UserClosing)
                    { 
                        dynamic result = MessageBox.Show("Do You Want To Exit?", "Application Name", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }

                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                    }
            }
    }
    }
