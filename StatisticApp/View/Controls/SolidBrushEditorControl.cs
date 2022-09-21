using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticApp.View.Controls
{
    public partial class SolidBrushEditorControl : UserControl
    {
        private SolidBrush _solidBrush = new SolidBrush(Color.Black);

        public SolidBrush SolidBrush
        {
            get => _solidBrush;
            set
            {
                _solidBrush = value;
                UpdateProperty();
            }
        }

        public event EventHandler SolidBrushChanged;

        public SolidBrushEditorControl()
        {
            InitializeComponent();
        }

        public void UpdateProperty()
        {
            ColorEditorControl.Color = SolidBrush.Color;
        }

        private void ColorEditorControl_ColorChanged(object sender, EventArgs e)
        {
            SolidBrush.Color = ColorEditorControl.Color;
            SolidBrushChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}