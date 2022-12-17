using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLgac.DAO;
using QLgac.BUS;
using QLgac.DTO;

namespace QLgac
{
    public partial class ThongTin : UserControl
    {
        DAIDOI c = new DAIDOI();
        DaiDoiDAO cDao = new DaiDoiDAO();
        private static ThongTin _instance;
        public static ThongTin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThongTin();
                return _instance;
            }
        }
        public ThongTin()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            dataC.DataSource = cDao.loadDD();
            long qs = cDao.qsTD();
            int qs1 = Convert.ToInt32(qs);
            qsD.Text = qs1.ToString();
            dcTD.Text = cDao.dcTD();
        }

        private void DeleteTextBoxs()
        {
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox6.Text = "";
        }
        private bool CheckTextBoxes()
        {
            //if (txtMabb.Text == "") { MessageBox.Show("Vui lòng nhập mã của bài báo!"); return false; }
            if (guna2TextBox3.Text == "") { MessageBox.Show("Vui lòng nhập mã đại đội!"); return false; }
            if (guna2TextBox4.Text == "") { MessageBox.Show("Vui lòng nhập tên đại đội!"); return false; }
            if (guna2TextBox5.Text == "") { MessageBox.Show("Vui lòng nhập quân số!"); return false; }
            if (guna2TextBox6.Text == "") { MessageBox.Show("Vui lòng nhập địa chỉ đại đội!"); return false; }
            return true;
        }
        private void dataC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox3.Text = dataC.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox4.Text = dataC.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox5.Text = dataC.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox6.Text = dataC.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void GetValuesTextBox()
        {
            c.MaDD = guna2TextBox3.Text;
            c.TenDD = guna2TextBox4.Text;
            c.QuanSo = Int32.Parse(guna2TextBox5.Text);
            c.DiaChi = guna2TextBox6.Text;
        }
        private void themC_Click_1(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        GetValuesTextBox();
                        cDao.themDD(c);
                        MessageBox.Show("Thêm thành công!");
                        ThongTin_Load(sender, e);
                        DeleteTextBoxs();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm vào: " + ex.Message);
                }
            }
        }

        private void xoaC_Click(object sender, EventArgs e)
        {
            if (dataC.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        GetValuesTextBox();
                        cDao.xoaDD(c);
                        MessageBox.Show("Xóa thành công!");
                        ThongTin_Load(sender, e);
                        DeleteTextBoxs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void suaC_Click(object sender, EventArgs e)
        {
            if (dataC.Rows.Count > 1)
            {
                try 
                {
                    if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        GetValuesTextBox();
                        cDao.suaDD(c);
                        MessageBox.Show("Sửa thành công!");
                        ThongTin_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dataC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox3.Text = dataC.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox4.Text = dataC.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox5.Text = dataC.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox6.Text = dataC.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
