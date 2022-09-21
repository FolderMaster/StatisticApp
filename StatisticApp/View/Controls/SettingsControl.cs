using StatisticApp.Model;
using System;
using System.Windows.Forms;

namespace StatisticApp.View.Controls
{
    public partial class SettingsControl : UserControl
    {
        private SettingsFormat _settings = new SettingsFormat();

        public SettingsFormat Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;
                UpdateProperty();
            }
        }

        public SettingsControl()
        {
            InitializeComponent();
        }

        public void UpdateProperty()
        {
            FontSolidBrushEditorControl.SolidBrush = Settings.FontSolidBrush;
            AxisXPenEditorControl.Pen = Settings.AxisXPen;
            AxisYPenEditorControl.Pen = Settings.AxisYPen;
            LineXSizeTextBox.Text = Settings.LineXSize.ToString();
            LineXPenEditorControl.Pen = Settings.LineXPen;
            LineYSizeTextBox.Text = Settings.LineYSize.ToString();
            LineYPenEditorControl.Pen = Settings.LineYPen;
            PointSizeTextBox.Text = Settings.PointSize.ToString();
            InnerPointSolidBrushEditorControl.SolidBrush = Settings.InnerPointSolidBrush;
            OuterPointPenEditorControl.Pen = Settings.OuterPointPen;
            LinePenEditorControl.Pen = Settings.LinePen;
        }

        private void ValueFontButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = Settings.ValueFont;
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.ValueFont = fontDialog.Font;
            }
        }

        private void FontSolidBrushEditorControl_SolidBrushChanged(object sender, EventArgs e)
        {
            Settings.FontSolidBrush = FontSolidBrushEditorControl.SolidBrush;
        }

        private void AxisXPenEditorControl_PenChanged(object sender, EventArgs e)
        {
            Settings.AxisXPen = AxisXPenEditorControl.Pen;
        }

        private void AxisYPenEditorControl_PenChanged(object sender, EventArgs e)
        {
            Settings.AxisYPen = AxisYPenEditorControl.Pen;
        }

        private void LineXSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.LineXSize = int.Parse(LineXSizeTextBox.Text);
                LineXSizeTextBox.BackColor = Settings.CorrectColor;
            }
            catch
            {
                LineXSizeTextBox.BackColor = Settings.ErrorColor;
            }
        }

        private void LineXPenEditorControl_PenChanged(object sender, EventArgs e)
        {
            Settings.LineXPen = LineXPenEditorControl.Pen;
        }

        private void LineYSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.LineYSize = int.Parse(LineYSizeTextBox.Text);
                LineYSizeTextBox.BackColor = Settings.CorrectColor;
            }
            catch
            {
                LineYSizeTextBox.BackColor = Settings.ErrorColor;
            }
        }

        private void LineYPenEditorControl_PenChanged(object sender, EventArgs e)
        {
            Settings.LineYPen = LineYPenEditorControl.Pen;
        }

        private void PointSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.PointSize = int.Parse(PointSizeTextBox.Text);
                PointSizeTextBox.BackColor = Settings.CorrectColor;
            }
            catch
            {
                PointSizeTextBox.BackColor = Settings.ErrorColor;
            }
        }

        private void InnerPointSolidBrushEditorControl_SolidBrushChanged(object sender, EventArgs e)
        {
            Settings.InnerPointSolidBrush = InnerPointSolidBrushEditorControl.SolidBrush;
        }

        private void OuterPointPenEditorControl_PenChanged(object sender, EventArgs e)
        {
            Settings.OuterPointPen = OuterPointPenEditorControl.Pen;
        }

        private void LinePenEditorControl_PenChanged(object sender, EventArgs e)
        {
            Settings.LinePen = LinePenEditorControl.Pen;
        }
    }
}