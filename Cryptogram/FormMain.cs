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
        private InteractiveButton _tabCvv;
        private InteractiveButton _tabPvv;
        private InteractiveButton _tabPinBlock;
        private InteractiveButton _tabTripleDes;
        private InteractiveButton _tabXor;

        private InteractiveButton[] _tabList;

        public FormMain()
        {
            InitializeComponent();

            _tabCvv = new TabButton(new BasicButton(btnCvv));
            _tabPvv = new TabButton(new BasicButton(btnPvv));
            _tabPinBlock = new TabButton(new BasicButton(btnPinBlock));
            _tabTripleDes = new TabButton(new BasicButton(btnTripleDes));
            _tabXor = new TabButton(new BasicButton(btnXor));

            _tabList = new InteractiveButton[] { _tabCvv, _tabPvv, _tabPinBlock, _tabTripleDes, _tabXor };

            ShowTab(_tabCvv, UcCvv.Instance);
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

        private void ShowTab(InteractiveButton tab, UserControl tabContainer)
        {
            Array.ForEach(_tabList, t => t.TurnOff());

            tab.TurnOn();

            if (!panelMain.Controls.Contains(tabContainer))
            {
                panelMain.Controls.Add(tabContainer);
                tabContainer.Dock = DockStyle.Fill;
            }

            tabContainer.BringToFront();
        }

        //-------------------------------------------------------------------------------------------------------
        #region Evenet Handlers
        //-------------------------------------------------------------------------------------------------------

        private void btnCvv_Click(object sender, EventArgs e)
        {
            ShowTab(_tabCvv, UcCvv.Instance);
        }

        private void btnCvv_MouseOver(object sender, EventArgs e)
        {
            (_tabCvv as TabButton).MouseOverHint();
        }

        private void btnCvv_MouseLeave(object sender, EventArgs e)
        {
            (_tabCvv as TabButton).MouseLeaveHint();
        }

        private void btnPvv_Click(object sender, EventArgs e)
        {
            ShowTab(_tabPvv, UcPvv.Instance);
        }

        private void btnPvv_MouseOver(object sender, EventArgs e)
        {
            (_tabPvv as TabButton).MouseOverHint();
        }

        private void btnPvv_MouseLeave(object sender, EventArgs e)
        {
            (_tabPvv as TabButton).MouseLeaveHint();
        }

        private void btnPinBlock_Click(object sender, EventArgs e)
        {
            ShowTab(_tabPinBlock, UcPinBlock.Instance);
        }

        private void btnPinBlock_MouseOver(object sender, EventArgs e)
        {
            (_tabPinBlock as TabButton).MouseOverHint();
        }

        private void btnPinBlock_MouseLeave(object sender, EventArgs e)
        {
            (_tabPinBlock as TabButton).MouseLeaveHint();
        }

        private void btnTripleDes_Click(object sender, EventArgs e)
        {
            ShowTab(_tabTripleDes, UcTripleDes.Instance);
        }

        private void btnTripleDes_MouseOver(object sender, EventArgs e)
        {
            (_tabTripleDes as TabButton).MouseOverHint();
        }

        private void btnTripleDes_MouseLeave(object sender, EventArgs e)
        {
            (_tabTripleDes as TabButton).MouseLeaveHint();
        }
        private void btnXor_Click(object sender, EventArgs e)
        {
            ShowTab(_tabXor, UcXor.Instance);
        }

        private void btnXor_MouseOver(object sender, EventArgs e)
        {
            (_tabXor as TabButton).MouseOverHint();
        }

        private void btnXor_MouseLeave(object sender, EventArgs e)
        {
            (_tabXor as TabButton).MouseLeaveHint();
        }


        //-------------------------------------------------------------------------------------------------------
        #endregion
        //-------------------------------------------------------------------------------------------------------
    }
}
