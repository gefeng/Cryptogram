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
    public partial class UcTripleDes : UserControl
    {
        private static UcTripleDes _instance = new UcTripleDes();

        private UcTripleDes()
        {
            InitializeComponent();
        }

        public static UcTripleDes Instance
        {
            get { return _instance; }
        }
    }
}
