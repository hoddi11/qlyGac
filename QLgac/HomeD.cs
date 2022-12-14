using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLgac
{
    public partial class HomeD : Form
    {
        public HomeD()
        {
            InitializeComponent();
        }
        private void HomeD_Load(object sender, EventArgs e)
        {
            if (!pnlLoad.Controls.Contains(ThongTin.Instance))
            {
                pnlLoad.Controls.Add(ThongTin.Instance);
                ThongTin.Instance.Dock = DockStyle.Fill;
                ThongTin.Instance.BringToFront();
            }
            else
                ThongTin.Instance.BringToFront();
        }

        private void thongtinBtn_Click(object sender, EventArgs e)
        {
            thongtinBtn.ForeColor = Color.OrangeRed;
            vatchatBtn.ForeColor = Color.Black;
            lichgacBtn.ForeColor = Color.Black;
            tinhhinhBtn.ForeColor = Color.Black;
            vonggacBtn.ForeColor = Color.Black;
            if (!pnlLoad.Controls.Contains(ThongTin.Instance))
            {
                pnlLoad.Controls.Add(ThongTin.Instance);
                ThongTin.Instance.Dock = DockStyle.Fill;
                ThongTin.Instance.BringToFront();
            }
            else
                ThongTin.Instance.BringToFront();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void vonggacBtn_Click(object sender, EventArgs e)
        {
            thongtinBtn.ForeColor = Color.Black;
            vatchatBtn.ForeColor = Color.Black;
            lichgacBtn.ForeColor = Color.Black;
            tinhhinhBtn.ForeColor = Color.Black;
            vonggacBtn.ForeColor = Color.OrangeRed;
            if (!pnlLoad.Controls.Contains(VongGac.Instance))
            {
                pnlLoad.Controls.Add(VongGac.Instance);
                VongGac.Instance.Dock = DockStyle.Fill;
                VongGac.Instance.BringToFront();
            }
            else
                VongGac.Instance.BringToFront();
        }

        private void lichgacBtn_Click(object sender, EventArgs e)
        {
            thongtinBtn.ForeColor = Color.Black;
            vatchatBtn.ForeColor = Color.Black;
            lichgacBtn.ForeColor = Color.OrangeRed;
            tinhhinhBtn.ForeColor = Color.Black;
            vonggacBtn.ForeColor = Color.Black;
            if (!pnlLoad.Controls.Contains(LichGac.Instance))
            {
                pnlLoad.Controls.Add(LichGac.Instance);
                LichGac.Instance.Dock = DockStyle.Fill;
                LichGac.Instance.BringToFront();
            }
            else
                VongGac.Instance.BringToFront();
        }

        private void tinhhinhBtn_Click(object sender, EventArgs e)
        {
            thongtinBtn.ForeColor = Color.Black;
            vatchatBtn.ForeColor = Color.Black;
            lichgacBtn.ForeColor = Color.Black;
            tinhhinhBtn.ForeColor = Color.OrangeRed;
            vonggacBtn.ForeColor = Color.Black;
            if (!pnlLoad.Controls.Contains(LichGac.Instance))
            {
                pnlLoad.Controls.Add(LichGac.Instance);
                LichGac.Instance.Dock = DockStyle.Fill;
                LichGac.Instance.BringToFront();
            }
            else
                VongGac.Instance.BringToFront();
        }
    }
}
