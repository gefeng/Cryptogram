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
    public partial class UcXor : UserControl
    {
        private static UcXor _instance = new UcXor();

        private UcXor()
        {
            InitializeComponent();
        }

        public static UcXor Instance
        {
            get { return _instance; }
        }
    }
}
