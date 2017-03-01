using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptogram
{
    public class ButtonDecorator : InteractiveButton
    {
        public ButtonDecorator(InteractiveButton decorated)
        {
            Decorated = decorated;
        }

        protected InteractiveButton Decorated { get; private set; }

        public override bool IsSelected
        {
            get { return Decorated.IsSelected; }
        }

        public override void TurnOn()
        {
            Decorated.TurnOn();
        }

        public override void TurnOff()
        {
            Decorated.TurnOff();
        }

        public override void ChangeMouseOverBackColor(Color color)
        {
            Decorated.ChangeMouseOverBackColor(color);
        }

        public override void ChangeMouseDownBackColor(Color color)
        {
            Decorated.ChangeMouseDownBackColor(color);
        }

        public override void ChangeTextColor(Color color)
        {
            Decorated.ChangeTextColor(color);
        }

        public override void ChangeBackgroundColor(Color color)
        {
            Decorated.ChangeBackgroundColor(color);
        }
    }
}
