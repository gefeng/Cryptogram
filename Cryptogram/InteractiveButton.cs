using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cryptogram
{
    public abstract class InteractiveButton
    {
        public abstract bool IsSelected { get; }

        public abstract void TurnOn();

        public abstract void TurnOff();

        public abstract void ChangeMouseOverBackColor(Color color);

        public abstract void ChangeMouseDownBackColor(Color color);

        public abstract void ChangeTextColor(Color color);

        public abstract void ChangeBackgroundColor(Color color);
    }
}
