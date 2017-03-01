using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cryptogram
{
    public class TabButton : ButtonDecorator
    {
        private static readonly Color BG_COLOR_SELECTED = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
        private static readonly Color BG_COLOR_UNSELECTED = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
        private static readonly Color FORE_COLOR = Color.White;
        private static readonly Color FORE_COLOR_MOUSE_OVER = Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));

        public TabButton(InteractiveButton decorated) 
            : base(decorated)
        {
            
        }

        public override void TurnOn()
        {
            if (!Decorated.IsSelected)
            {
                Decorated.TurnOn();
                Decorated.ChangeBackgroundColor(BG_COLOR_SELECTED);
                Decorated.ChangeMouseDownBackColor(BG_COLOR_SELECTED);
                Decorated.ChangeMouseOverBackColor(BG_COLOR_SELECTED);
                Decorated.ChangeTextColor(FORE_COLOR);
            }
        }

        public override void TurnOff()
        {
            if(Decorated.IsSelected)
            {
                Decorated.TurnOff();
                Decorated.ChangeBackgroundColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeMouseDownBackColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeMouseOverBackColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeTextColor(FORE_COLOR);
            }
        }

        public void MouseOverHint()
        {
            if(!Decorated.IsSelected)
            {
                Decorated.ChangeBackgroundColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeMouseDownBackColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeMouseOverBackColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeTextColor(FORE_COLOR_MOUSE_OVER);
            }
        }

        public void MouseLeaveHint()
        {
            if(!Decorated.IsSelected)
            {
                Decorated.ChangeBackgroundColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeMouseDownBackColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeMouseOverBackColor(BG_COLOR_UNSELECTED);
                Decorated.ChangeTextColor(FORE_COLOR);
            }
        }
    }
}
