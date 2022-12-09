using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

using PrimaryStatisticProcessingApp.Models.Graphs;

using Rectangle = PrimaryStatisticProcessingApp.Models.Graphs.Rectangle;

namespace PrimaryStatisticProcessingApp.View.Controls
{
    public partial class DisplayControl : UserControl
    {
        private Graph _graph;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Graph Graph
        {
            get
            {
                return _graph;
            }
            set
            {
                if(value != null)
                {
                    if (value.Axises.Count >= 2)
                    {
                        _graph = value;
                        _graph.Axises[0].Length = Width;
                        _graph.Axises[1].Length = Height;
                        _graph.DefaultDisplay();
                    }
                }
                else
                {
                    _graph = new Graph(new List<Axis>()
                    {
                        new Axis(),
                        new Axis()
                    });
                }
                Invalidate();
            }
        }

        public Font ValueFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10,
            FontStyle.Regular);

        public SolidBrush FontSolidBrush { get; set; } = new SolidBrush(Color.Black);

        public Pen AxisXPen { get; set; } = new Pen(Color.Black);

        public Pen AxisYPen { get; set; } = new Pen(Color.Black);

        public int LineXSize { get; set; } = 20;

        public Pen LineXPen { get; set; } = new Pen(Color.Black);

        public int LineYSize { get; set; } = 20;

        public Pen LineYPen { get; set; } = new Pen(Color.Black);

        public Pen RectanglePen { get; set; } = new Pen(Color.Black);

        public Brush RectangleBrush { get; set; } = new SolidBrush(Color.Blue);

        public DisplayControl()
        {
            InitializeComponent();

            Graph = new Graph(new List<Axis>() {
                new Axis(new LinearScale()), new Axis(new LinearScale()) });
        }

        private void DisplayControl_SizeChanged(object sender, EventArgs e)
        {
            Graph.Axises[0].Length = Width;
            Graph.Axises[1].Length = Height;

            Invalidate();
        }

        private void DisplayControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();

            List<IShape> display = Graph.Displays;
            List<IShape> shapes = Graph.Shapes;
            for (int n = 0; n < display.Count; ++n)
            {
                if (display[n] is Rectangle rectangle)
                {
                    int x1 = (int)rectangle.Point1[0];
                    int y1 = (int)rectangle.Point1[1];
                    int x2 = (int)rectangle.Point2[0];
                    int y2 = (int)rectangle.Point2[1];

                    graphics.FillRectangle(RectangleBrush, x1, Height - y2, x2 - x1, y2 - y1);
                    graphics.DrawRectangle(RectanglePen, x1, Height - y2, x2 - x1, y2 - y1);

                    Rectangle values = shapes[n] as Rectangle;

                    graphics.DrawLine(LineXPen, x1, Height, x1, Height - LineXSize);
                    graphics.DrawString(values.Point1[0].ToString(), ValueFont,
                        FontSolidBrush, x1, Height - LineXSize);
                    graphics.DrawLine(LineYPen, 0, Height - y1, LineYSize, Height - y1);
                    graphics.DrawString(values.Point1[1].ToString(), ValueFont,
                        FontSolidBrush, LineYSize, Height - y1);

                    graphics.DrawLine(LineXPen, x2, Height, x2, Height - LineXSize);
                    graphics.DrawString(values.Point2[0].ToString(), ValueFont,
                        FontSolidBrush, x2, Height - LineXSize);
                    graphics.DrawLine(LineYPen, 0, Height - y2, LineYSize, Height - y2);
                    graphics.DrawString(values.Point2[1].ToString(), ValueFont,
                        FontSolidBrush, LineYSize, Height - y2);
                }
            }
            graphics.DrawLine(AxisXPen, 0, Height - 1, Width, Height - 1);
            graphics.DrawLine(AxisYPen, 0, 0, 0, Height);
        }
    }
}