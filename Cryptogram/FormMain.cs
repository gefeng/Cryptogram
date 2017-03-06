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

        private Point _prevMouseLocation;
        private bool _dragging = false;

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

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                _prevMouseLocation = e.Location;
                _dragging = true;
            }
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(_dragging)
            {
                Point winLocation = this.Location;
                Point currMouseLocation = e.Location;

                winLocation.Offset(currMouseLocation.X - _prevMouseLocation.X, currMouseLocation.Y - _prevMouseLocation.Y);

                this.Location = winLocation;
            }
        }

        private void lbClose_MouseEnter(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
        }

        private void lbClose_MouseLeave(object sender, EventArgs e)
        {
            lbClose.ForeColor = Color.Transparent;
        }

        private void lbMinimize_MouseEnter(object sender, EventArgs e)
        {
            lbMinimize.ForeColor = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
        }

        private void lbMinimize_MouseLeave(object sender, EventArgs e)
        {
            lbMinimize.ForeColor = Color.Transparent;
        }

        //-------------------------------------------------------------------------------------------------------
        #endregion
        //-------------------------------------------------------------------------------------------------------
    }
}
