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

        private HintLabel _hLabelBlockA;
        private HintLabel _hLabelBlockB;

        private bool _validBlockA = false;
        private bool _validBlockB = false;

        private UcXor()
        {
            InitializeComponent();

            _hLabelBlockA = new HintLabel(lbBlockAHint);
            _hLabelBlockB = new HintLabel(lbBlockBHint);
        }

        public static UcXor Instance
        {
            get { return _instance; }
        }

        private void tbBlockA_TextChanged(object sender, EventArgs e)
        {
            string content = tbBlockA.Text;

            if(string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelBlockA.Clear();
                _validBlockA = false;
                tbXor.Text = string.Empty;
                return;
            }

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelBlockA.SetHint(Color.Red, "Block can only contain hex digit");
                    _validBlockA = false;
                    return;
                }
            }

            _validBlockA = true;
            _hLabelBlockA.Clear();

            if (_validBlockA && _validBlockB)
            {
                tbXor.Text = Encryptor.Instance.Xor(content, tbBlockB.Text);
            }
        }

        private void tbBlockB_TextChanged(object sender, EventArgs e)
        {
            string content = tbBlockB.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelBlockB.Clear();
                _validBlockB = false;
                tbXor.Text = string.Empty;
                return;
            }

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelBlockB.SetHint(Color.Red, "Block can only contain hex digit");
                    _validBlockB = false;
                    return;
                }
            }

            _validBlockB = true;
            _hLabelBlockB.Clear();

            if (_validBlockA && _validBlockB)
            {
                tbXor.Text = Encryptor.Instance.Xor(tbBlockA.Text, content);
            }
        }
    }
}
