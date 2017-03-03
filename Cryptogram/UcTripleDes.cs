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

        private HintLabel _hLabelDataBlock;
        private HintLabel _hLabelKey;

        private bool _validDataBlock = false;
        private bool _validKey = false;

        private UcTripleDes()
        {
            InitializeComponent();

            _hLabelDataBlock = new HintLabel(lbDataBlockHint);
            _hLabelKey = new HintLabel(lbKeyHint);
        }

        public static UcTripleDes Instance
        {
            get { return _instance; }
        }

        //-------------------------------------------------------------------------------------------------------
        #region Event handlers
        //-------------------------------------------------------------------------------------------------------

        private void tbDataBlock_TextChanged(object sender, EventArgs e)
        {
            string content = tbDataBlock.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelDataBlock.Clear();
                _validDataBlock = false;
                return;
            }

            content = content.Replace(" ", "");

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelDataBlock.SetHint(Color.Red, "Block must only contain hex digits");
                    _validDataBlock = false;
                    return;
                }
            }

            if (content.Length < 16)
            {
                _hLabelDataBlock.SetHint(Color.Red, "Block size must be at leaset 8 bytes");
                _validDataBlock = false;
                return;
            }

            if (!IsPowOfTwo(content.Length))
            {
                _hLabelDataBlock.SetHint(Color.Red, "Block size must be power of two");
                _validDataBlock = false;
                return;
            }

            _validDataBlock = true;
            _hLabelDataBlock.Clear();
        }

        private void tbKey_TextChanged(object sender, EventArgs e)
        {
            string content = tbKey.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelKey.Clear();
                _validKey = false;
                return;
            }

            content = content.Replace(" ", "");

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelKey.SetHint(Color.Red, "Key must only contain hex digits");
                    _validKey = false;
                    return;
                }
            }

            if (content.Length != 32)
            {
                _hLabelKey.SetHint(Color.Red, "Key size must be 16 bytes");
                _validKey = false;
                return;
            }

            _validKey = true;
            _hLabelKey.SetHint(Color.Black, "Check value: " + Encryptor.Instance.CalKCV(content));
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (_validDataBlock && _validKey)
            {
                string data = tbDataBlock.Text.Replace(" ", "");
                string key = tbKey.Text.Replace(" ", "");

                tbOutput.Text = Encryptor.Instance.Encrypt3DES(data, key);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (_validDataBlock && _validKey)
            {
                string data = tbDataBlock.Text.Replace(" ", "");
                string key = tbKey.Text.Replace(" ", "");

                tbOutput.Text = Encryptor.Instance.Decrypt3DES(data, key);
            }
        }

        //-------------------------------------------------------------------------------------------------------
        #endregion
        //-------------------------------------------------------------------------------------------------------

        private bool IsPowOfTwo(int number)
        {
            if (number % 2 != 0)
                return false;
            else if (number == 2)
                return true;
            else
                return IsPowOfTwo(number / 2);
        }
    }
}
