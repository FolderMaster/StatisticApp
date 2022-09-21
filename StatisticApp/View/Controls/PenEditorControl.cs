using StatisticApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StatisticApp.View.Controls
{
    public partial class PenEditorControl : UserControl
    {
        private Pen _pen = new Pen(Color.Black);

        public Pen Pen
        {
            get => _pen;
            set
            {
                _pen = value;
                UpdateProperty();
            }
        }

        public SettingsFormat Settings { get; set; } = new SettingsFormat();

        public event EventHandler PenChanged;

        public PenEditorControl()
        {
            InitializeComponent();
        }

        public void UpdateProperty()
        {
            WidthTextBox.Text = Pen.Width.ToString();
            ColorEditorControl.Color = Pen.Color;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Pen.Width = float.Parse(WidthTextBox.Text);
                PenChanged?.Invoke(this, EventArgs.Empty);

            }
            catch
            {
                WidthTextBox.BackColor = Settings.ErrorColor;
            }
        }

        private void ColorEditorControl_ColorChanged(object sender, EventArgs e)
        {
            Pen.Color = ColorEditorControl.Color;
            PenChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}