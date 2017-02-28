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
    public partial class UcPVV : UserControl
    {
        private static UcPVV _instance = new UcPVV();

        private UcPVV()
        {
            InitializeComponent();
        }

        public static UcPVV Instance
        {
            get { return _instance; }
        }
    }
}
