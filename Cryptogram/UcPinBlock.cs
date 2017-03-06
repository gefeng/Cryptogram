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

        private HintLabel _hLabelClearAwk;
        private HintLabel _hLabelPan;
        private HintLabel _hLabelPin;
        private HintLabel _hLabelPinBlockEncrypted;

        private bool _validClearAwk = false;
        private bool _validPan = false;
        private bool _validPin = false;
        private bool _validPinBlockEncrypted = false;

        private UcPinBlock()
        {
            InitializeComponent();

            _hLabelClearAwk = new HintLabel(lbClearAwkHint);
            _hLabelPan = new HintLabel(lbPanHint);
            _hLabelPin = new HintLabel(lbPinHint);
            _hLabelPinBlockEncrypted = new HintLabel(lbPinBlockEncryptedHint);
        }

        public static UcPinBlock Instance
        {
            get { return _instance; }
        }

        private void tbClearAwk_TextChanged(object sender, EventArgs e)
        {
            string content = tbClearAwk.Text;

            if(string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelClearAwk.Clear();
                _validClearAwk = false;
                return;
            }

            content = content.Replace(" ", "");

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelClearAwk.SetHint(Color.Red, "AWK must only contain hex digits");
                    _validClearAwk = false;
                    return;
                }
            }

            if (content.Length != 32)
            {
                _hLabelClearAwk.SetHint(Color.Red, "AWK size must be 16 bytes");
                _validClearAwk = false;
                return;
            }

            _hLabelClearAwk.SetHint(Color.Black, "Check value: " + Encryptor.Instance.CalKCV(content));
            _validClearAwk = true;
        }

        private void tbPan_TextChanged(object sender, EventArgs e)
        {
            string content = tbPan.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelPan.Clear();
                _validPan = false;
                return;
            }

            foreach (char c in content)
            {
                if (!Helper.IsDigit(c))
                {
                    _hLabelPan.SetHint(Color.Red, "PAN must only contain digits");
                    _validPan = false;
                    return;
                }
            }

            if (content.Length < 13 || content.Length > 19)
            {
                _hLabelPan.SetHint(Color.Red, "Invalid PAN length");
                _validPan = false;
                return;
            }

            _hLabelPan.Clear();
            _validPan = true;
        }

        private void tbPin_TextChanged(object sender, EventArgs e)
        {
            if (!tbPin.ReadOnly)
            {
                string content = tbPin.Text;

                if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
                {
                    _hLabelPin.Clear();
                    _validPin = false;

                    tbPinBlockEncrypted.ReadOnly = false;
                    btnCalculatePin.Enabled = true;

                    tbPinBlockEncrypted.Text = string.Empty;
                    tbPinBlock.Text = string.Empty;

                    return;
                }

                tbPinBlockEncrypted.ReadOnly = true;
                btnCalculatePin.Enabled = false;

                foreach (char c in content)
                {
                    if (!Helper.IsDigit(c))
                    {
                        _hLabelPin.SetHint(Color.Red, "PIN must only contain digits");
                        _validPin = false;
                        return;
                    }
                }

                if (content.Length < 4 || content.Length > 6)
                {
                    _hLabelPin.SetHint(Color.Red, "Invalid PIN length");
                    _validPin = false;
                    return;
                }

                _hLabelPin.Clear();
                _validPin = true;
            }
        }

        private void tbPinBlockEncrypted_TextChanged(object sender, EventArgs e)
        {
            if (!tbPinBlockEncrypted.ReadOnly)
            {
                string content = tbPinBlockEncrypted.Text;

                if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
                {
                    _hLabelPinBlockEncrypted.Clear();
                    _validPinBlockEncrypted = false;

                    tbPin.ReadOnly = false;
                    btnCalculatePinBlock.Enabled = true;

                    tbPinBlock.Text = string.Empty;
                    tbPin.Text = string.Empty;

                    return;
                }

                tbPin.ReadOnly = true;
                btnCalculatePinBlock.Enabled = false;

                foreach (char c in content)
                {
                    if (!Helper.IsHexChar(c))
                    {
                        _hLabelPinBlockEncrypted.SetHint(Color.Red, "Block must only contain hex digits");
                        _validPinBlockEncrypted = false;
                        return;
                    }
                }

                if (content.Length != 16)
                {
                    _hLabelPinBlockEncrypted.SetHint(Color.Red, "Block size must be 8 bytes");
                    _validPinBlockEncrypted = false;
                    return;
                }

                _hLabelPinBlockEncrypted.Clear();
                _validPinBlockEncrypted = true;
            }
        }

        private void btnCalculatePin_Click(object sender, EventArgs e)
        {
            PinBlockFormat format;
            string pin = string.Empty;

            tbPinBlock.Text = string.Empty;
            tbPin.Text = string.Empty;

            if (_validClearAwk && _validPan && _validPinBlockEncrypted)
            {
                format = (cbPinFormat.SelectedItem as string) == "ISO-0" ? PinBlockFormat.ISO0 : PinBlockFormat.VISA3;

                pin = Encryptor.Instance.CalPin(tbPan.Text, tbPinBlockEncrypted.Text, format);

                tbPin.Text = pin;
            }
        }

        private void btnCalculatePinBlock_Click(object sender, EventArgs e)
        {
            PinBlockFormat format;
            string clearPinBlock = string.Empty;

            tbPinBlock.Text = string.Empty;
            tbPinBlockEncrypted.Text = string.Empty;

            if (_validClearAwk && _validPan && _validPin)
            {
                format = (cbPinFormat.SelectedItem as string) == "ISO-0" ? PinBlockFormat.ISO0 : PinBlockFormat.VISA3;

                clearPinBlock = Encryptor.Instance.CalPinBlock(tbPan.Text, tbPin.Text, format);

                tbPinBlock.Text = clearPinBlock;

                tbPinBlockEncrypted.Text = Encryptor.Instance.Encrypt3DES(clearPinBlock, tbClearAwk.Text);
            }
        }
    }
}
