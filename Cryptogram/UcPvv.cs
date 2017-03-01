using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptogram
{
    public partial class UcPvv : UserControl
    {
        private static UcPvv _instance = new UcPvv();

        private UcPvv()
        {
            InitializeComponent();
        }

        public static UcPvv Instance
        {
            get { return _instance; }
        }
    }
}
