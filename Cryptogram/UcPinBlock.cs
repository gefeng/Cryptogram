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
    public partial class UcPinBlock : UserControl
    {
        private static UcPinBlock _instance = new UcPinBlock();

        private UcPinBlock()
        {
            InitializeComponent();
        }

        public static UcPinBlock Instance
        {
            get { return _instance; }
        }
    }
}
