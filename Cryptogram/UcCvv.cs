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
    public partial class UcCvv : UserControl
    {
        private static UcCvv _instance = new UcCvv();

        private UcCvv()
        {
            InitializeComponent();
        }

        public static UcCvv Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
