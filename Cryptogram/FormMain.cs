using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptogram
{
    public partial class FormMain : Form
    {
        private IEncryptor encryptor = new Encryptor();

        public FormMain()
        {
            InitializeComponent();

            if (!panelMain.Controls.Contains(UcCvv.Instance))
            {
                panelMain.Controls.Add(UcCvv.Instance);
                UcCvv.Instance.Dock = DockStyle.Fill;
            }

            UcCvv.Instance.BringToFront();
        }

        /*private void tbClearPVK_TextChanged(object sender, EventArgs e)
        {
            if(tbClearPVK.TextLength == 32)
            {
                tbKCV.Text = encryptor.CalKCV(tbClearPVK.Text);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string pan = tbPAN.Text;
            string pin = tbPIN.Text;
            string pvki = tbPVKI.Text;
            string clearPVK = tbClearPVK.Text;
            
            tbPVV.Text = encryptor.CalPVV(pan, pin, pvki, clearPVK);
        }*/

        private void btnCvv_Click(object sender, EventArgs e)
        {
            if(!panelMain.Controls.Contains(UcCvv.Instance))
            {
                panelMain.Controls.Add(UcCvv.Instance);
                UcCvv.Instance.Dock = DockStyle.Fill;
            }

            UcCvv.Instance.BringToFront();
        }
    }
}
