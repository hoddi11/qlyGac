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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private int imgNum = 1;
        private void loadImg()
        {
            timer1.Start();
            imgNum++;
            if (imgNum > 3)
            {
                imgNum = 1;
            }
            if (imgNum == 1)
                anh1.Checked = true;
            else if (imgNum == 2)
                anh2.Checked = true;
            else anh3.Checked = true;
            anhPicbox.ImageLocation = string.Format(@"D:\download55\QLgac\QLgac\images\"+imgNum+".jpg");
        }
        private void changeCheck()
        {
            timer1.Start();
            if (anh1.Checked == true)
                imgNum = 1;
            if (anh2.Checked == true)
                imgNum = 2;
            if (anh3.Checked == true)
                imgNum = 3;
            anhPicbox.ImageLocation = string.Format(@"D:\download55\QLgac\QLgac\images\" + imgNum + ".jpg");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImg();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            anh1.Checked = true;
            anhPicbox.ImageLocation = string.Format(@"D:\download55\QLgac\QLgac\images\" + imgNum + ".jpg");
        }

        private void anh1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            changeCheck();
        }

        private void anh2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            changeCheck();
        }

        private void anh3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            changeCheck();
        }
    }
}
