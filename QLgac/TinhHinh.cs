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
    public partial class TinhHinh : UserControl
    {
        private static TinhHinh _instance;
        public static TinhHinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TinhHinh();
                return _instance;
            }
        }
        public TinhHinh()
        {
            InitializeComponent();
        }
    }
}
