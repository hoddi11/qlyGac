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
    }
}
