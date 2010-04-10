using System.Windows.Forms;
using System.ComponentModel;

namespace MudCartographer
{
    public partial class FlickerFreePanel : Panel
    {
        public FlickerFreePanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        public FlickerFreePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
