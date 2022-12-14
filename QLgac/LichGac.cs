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
    public partial class LichGac : UserControl
    {
        private static LichGac _instance;
        public static LichGac Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LichGac();
                return _instance;
            }
        }
        public LichGac()
        {
            InitializeComponent();
        }
    }
}
