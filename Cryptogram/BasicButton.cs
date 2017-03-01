using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptogram
{
    public class BasicButton : InteractiveButton
    {
        private Button _button;

        private bool _isSelected = false;

        public BasicButton(Button button)
        {
            _button = button;
        }

        public override bool IsSelected
        {
            get { return _isSelected; }
        }

        public override void TurnOn()
        {
            _isSelected = true;
        }

        public override void TurnOff()
        {
            _isSelected = false;
        }

        public override void ChangeMouseOverBackColor(Color color)
        {
            _button.FlatAppearance.MouseOverBackColor = color;
        }

        public override void ChangeMouseDownBackColor(Color color)
        {
            _button.FlatAppearance.MouseDownBackColor = color;
        }

        public override void ChangeTextColor(Color color)
        {
            _button.ForeColor = color;
        }

        public override void ChangeBackgroundColor(Color color)
        {
            _button.BackColor = color;
        }
    }
}
