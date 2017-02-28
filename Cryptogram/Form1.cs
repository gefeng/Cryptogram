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
    public partial class Form1 : Form
    {
        private IEncryptor encryptor = new Encryptor();

        public Form1()
        {
            InitializeComponent();
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

        private void btnPVV_Click(object sender, EventArgs e)
        {
            if(!panelMain.Controls.Contains(UcPVV.Instance))
            {
                panelMain.Controls.Add(UcPVV.Instance);
                UcPVV.Instance.Dock = DockStyle.Fill;
            }

            UcPVV.Instance.BringToFront();
        }
    }
}
