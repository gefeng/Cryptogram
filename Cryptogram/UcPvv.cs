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

        private HintLabel _hLabelClearPvk;
        private HintLabel _hLabelPan;
        private HintLabel _hLabelPvki;
        private HintLabel _hLabelPin;

        private bool _validClearPvk = false;
        private bool _validPan = false;
        private bool _validPvki = false;
        private bool _validPin = false;

        private UcPvv()
        {
            InitializeComponent();

            _hLabelClearPvk = new HintLabel(lbClearPvkHint);
            _hLabelPan = new HintLabel(lbPanHint);
            _hLabelPvki = new HintLabel(lbPvkiHint);
            _hLabelPin = new HintLabel(lbPinHint);
        }

        public static UcPvv Instance
        {
            get { return _instance; }
        }

        private void tbClearPvk_TextChanged(object sender, EventArgs e)
        {
            string content = tbClearPvk.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelClearPvk.Clear();
                _validClearPvk = false;
                return;
            }

            content = content.Replace(" ", "");

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelClearPvk.SetHint(Color.Red, "PVK must only contain hex digits");
                    _validClearPvk = false;
                    return;
                }
            }

            if (content.Length != 32)
            {
                _hLabelClearPvk.SetHint(Color.Red, "PVK size must be 16 bytes");
                _validClearPvk = false;
                return;
            }

            _hLabelClearPvk.SetHint(Color.Black, "Check value: " + Encryptor.Instance.CalKCV(content));
            _validClearPvk = true;
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

        private void tbPvki_TextChanged(object sender, EventArgs e)
        {
            string content = tbPvki.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelPvki.Clear();
                _validPvki = false;
                return;
            }

            foreach (char c in content)
            {
                if (!Helper.IsDigit(c))
                {
                    _hLabelPvki.SetHint(Color.Red, "PVKI must only contain digits");
                    _validPvki = false;
                    return;
                }
            }

            if (content.Length != 1)
            {
                _hLabelPvki.SetHint(Color.Red, "Invalid PVKI length");
                _validPvki = false;
                return;
            }

            _hLabelPvki.Clear();
            _validPvki = true;
        }

        private void tbPin_TextChanged(object sender, EventArgs e)
        {
            string content = tbPin.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelPin.Clear();
                _validPin = false;
                return;
            }

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

        private void btnGeneratePvv_Click(object sender, EventArgs e)
        {
            if (_validClearPvk && _validPan && _validPvki && _validPin)
            {
                string pvk = tbClearPvk.Text.Replace(" ", "");

                tbPvv.Text = Encryptor.Instance.CalPVV(tbPan.Text, tbPin.Text, tbPvki.Text, pvk);
            }
        }
    }
}
