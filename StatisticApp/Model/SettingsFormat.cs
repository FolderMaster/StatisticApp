using System.Drawing;

namespace StatisticApp.Model
{
    public class SettingsFormat
    {
        public Color ErrorColor { get; set; } = Color.LightPink;

        public Color CorrectColor { get; set; } = Color.White;

        public Font ValueFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10,
            FontStyle.Regular);

        public SolidBrush FontSolidBrush { get; set; } = new SolidBrush(Color.Black);

        public Pen AxisXPen { get; set; } = new Pen(Color.Black);

        public Pen AxisYPen { get; set; } = new Pen(Color.Black);

        public int LineXSize { get; set; } = 20;

        public Pen LineXPen { get; set; } = new Pen(Color.Black);

        public int LineYSize { get; set; } = 20;

        public Pen LineYPen { get; set; } = new Pen(Color.Black);

        public int PointSize { get; set; } = 10;

        public Pen OuterPointPen { get; set; } = new Pen(Color.Black);

        public SolidBrush InnerPointSolidBrush { get; set; } = new SolidBrush(Color.Gray);

        public Pen LinePen { get; set; } = new Pen(Color.Black);

        public SettingsFormat()
        {
        }
    }
}