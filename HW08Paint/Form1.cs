using System.Drawing.Drawing2D;

namespace HW08Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 5);
            Pen highlightPen = new Pen(Color.White, 5);
            Brush leafBrush = new SolidBrush(Color.Green);
            Brush gradientBrush = new LinearGradientBrush(
                                            new Point(170, 200), new Point(400, 260),
                                            Color.Red, Color.Green);
            Brush highLight = new SolidBrush(Color.White);

            Point[] polygonPoints = new Point[]{ new(300, 225), new(300, 160), new(350, 130)};

            GraphicsPath apple = new();


        
            ///Заливка
            apple.AddArc(200, 200 , 100, 60, 180, 180);
            //apple.AddPolygon(polygonPoints);
            //apple.FillPolygon(brush, polygonPoints);
            apple.AddArc(300  , 200  , 100,60, 180, 180);
            apple.AddBezier(new Point(400  , 224  ), new Point(400  , 224  ), new Point(370  , 400  ), new Point(300  , 340));
            apple.AddBezier(new Point(300  , 340  ), new Point(230  , 400  ), new Point(200    , 224  ), new Point(200  ,224  ));

            g.FillPath(gradientBrush, apple);

            g.DrawPolygon(pen, polygonPoints);
            g.FillPolygon(leafBrush, polygonPoints);

            ///Контур
            g.DrawArc(pen, 200  , 200  , 100, 60, 180, 180);
            //apple.AddPolygon(polygonPoints);
            //apple.FillPolygon(brush, polygonPoints);
            g.DrawArc(pen, 300  , 200  , 100, 60, 180, 180);
            g.DrawBezier(pen, new Point(400  , 224  ), new Point(400  , 224  ), new Point(370  , 400  ), new Point(300  , 340  ));
            g.DrawBezier(pen, new Point(300  , 340  ), new Point(230  , 400  ), new Point(200  , 224  ), new Point(200  , 224  ));
            g.DrawEllipse(highlightPen, 250  , 250  , 10, 10);
            g.FillEllipse(highLight, 250  , 250  , 10, 10);


        }
    }
}
