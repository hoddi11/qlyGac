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
    public partial class VongGac : UserControl
    {
        private static VongGac _instance;
        public static VongGac Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VongGac();
                return _instance;
            }
        }
        public VongGac()
        {
            InitializeComponent();
        }
    }
}
