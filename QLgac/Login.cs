using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLgac
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUser.PlaceholderText.Equals("Tài khoản"))
            {
                txtUser.PlaceholderText = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUser.PlaceholderText.Equals(""))
            {
                txtUser.PlaceholderText = "Tài khoản";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPass.PlaceholderText.Equals("Mật khẩu"))
            {
                txtPass.PlaceholderText = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPass.PlaceholderText.Equals(""))
            {
                txtPass.PlaceholderText = "Mật khẩu";
            }
        }

        private void ptHideEye_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●')
            {
                ptEye.BringToFront();
                txtPass.PasswordChar = '\0';
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void ptEye_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                ptHideEye.BringToFront();
                txtPass.PasswordChar = '●';
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtUser.Text;
            string mk = Encrypt.HashString(txtPass.Text);
            string query = "select * from DANGNHAP where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
            DataTable dt = new DataTable();
            dt = modify.Table(query);
            if (modify.UserLogins(query).Count != 0)
            {
                this.Hide();
                Home showHome = new Home(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                showHome.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
