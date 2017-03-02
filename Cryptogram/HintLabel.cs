using System.Drawing;
using System.Windows.Forms;

namespace Cryptogram
{
    public class HintLabel
    {
        private Label _label;

        public HintLabel(Label label)
        {
            _label = label;
        }

        public void SetHint(Color color, string content)
        {
            _label.ForeColor = color;
            _label.Text = content;
        }

        public void Clear()
        {
            _label.ForeColor = Color.Transparent;
            _label.Text = string.Empty;
        }
    }
}
