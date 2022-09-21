using System;
using System.Drawing;
using System.Windows.Forms;

namespace StatisticApp.View.Controls
{
    public partial class ColorEditorControl : UserControl
    {
        public Color _color = Color.Black;

        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                Button.BackColor = _color;
                ColorChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ColorChanged;

        public ColorEditorControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Color;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialog.Color;
            }
        }
    }
}