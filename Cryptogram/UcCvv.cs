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

        private HintLabel _hLabelClearCvk;
        private HintLabel _hLabelPan;
        private HintLabel _hLabelExpireDate;
        private HintLabel _hLabelServiceCode;

        private bool _validClearCvk = false;
        private bool _validPan = false;
        private bool _validExpireDate = false;
        private bool _validServiceCode = false;

        private UcCvv()
        {
            InitializeComponent();

            _hLabelClearCvk = new HintLabel(lbClearCvkHint);
            _hLabelPan = new HintLabel(lbPanHint);
            _hLabelExpireDate = new HintLabel(lbExpireDateHint);
            _hLabelServiceCode = new HintLabel(lbServiceCodeHint);
        }

        public static UcCvv Instance
        {
            get
            {
                return _instance;
            }
        }

        private void tbClearCvk_TextChanged(object sender, EventArgs e)
        {
            string content = tbClearCvk.Text;
        
            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelClearCvk.Clear();
                _validClearCvk = false;
                return;
            }

            content = content.Replace(" ", "");

            foreach (char c in content)
            {
                if (!Helper.IsHexChar(c))
                {
                    _hLabelClearCvk.SetHint(Color.Red, "CVK must only contain hex digits");
                    _validClearCvk = false;
                    return;
                }
            }

            if (content.Length != 32)
            {
                _hLabelClearCvk.SetHint(Color.Red, "CVK size must be 16 bytes");
                _validClearCvk = false;
                return;
            }

            _hLabelClearCvk.SetHint(Color.Black, "Check value: " + Encryptor.Instance.CalKCV(content));
            _validClearCvk = true;
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
                if(!Helper.IsDigit(c))
                {
                    _hLabelPan.SetHint(Color.Red, "PAN must only contain digits");
                    _validPan = false;
                    return;
                }
            }

            if(content.Length < 13 || content.Length > 19)
            {
                _hLabelPan.SetHint(Color.Red, "Invalid PAN length");
                _validPan = false;
                return;
            }

            _hLabelPan.Clear();
            _validPan = true;
        }

        private void tbExpireDate_TextChanged(object sender, EventArgs e)
        {
            string content = tbExpireDate.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelExpireDate.Clear();
                _validExpireDate = false;
                return;
            }

            foreach (char c in content)
            {
                if (!Helper.IsDigit(c))
                {
                    _hLabelExpireDate.SetHint(Color.Red, "Expire date must only contain digits");
                    _validExpireDate = false;
                    return;
                }
            }

            if(content.Length != 4)
            {
                _hLabelExpireDate.SetHint(Color.Red, "Invalid expire date length");
                _validExpireDate = false;
                return;
            }

            _hLabelExpireDate.Clear();
            _validExpireDate = true;
        }

        private void tbServiceCode_TextChanged(object sender, EventArgs e)
        {
            string content = tbServiceCode.Text;

            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                _hLabelServiceCode.Clear();
                _validServiceCode = false;
                return;
            }

            foreach (char c in content)
            {
                if (!Helper.IsDigit(c))
                {
                    _hLabelServiceCode.SetHint(Color.Red, "Service code must only contain digits");
                    _validServiceCode = false;
                    return;
                }
            }

            if (content.Length != 3)
            {
                _hLabelServiceCode.SetHint(Color.Red, "Invalid service code length");
                _validServiceCode = false;
                return;
            }

            _hLabelServiceCode.Clear();
            _validServiceCode = true;
        }

        private void btnGenerateCvv_Click(object sender, EventArgs e)
        {
            if (_validClearCvk && _validPan && _validExpireDate && _validServiceCode)
            {
                string cvk = tbClearCvk.Text.Replace(" ", "");

                tbCvv.Text = Encryptor.Instance.CalCVV(tbPan.Text, tbExpireDate.Text, tbServiceCode.Text, cvk);
            }           
        }
    }
}
