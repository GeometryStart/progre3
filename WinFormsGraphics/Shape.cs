using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGraphics
{
    public abstract class Shape
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Pen Pen { get; set; }
        public Shape()
        {
            Pen = new Pen(Color.Black, 1);
        }
        public abstract void Draw(Graphics g);
      
    }

    public class RectangleShape : Shape
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Pen Pen { get; set; }
        public RectangleShape()
        {
            Pen = new Pen(Color.Black);
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, Location.X, Location.Y, Size.Width, Size.Height);
        }
    }

    public class EllipseShape : Shape
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Pen Pen { get; set; }
        public EllipseShape()
        {
            Pen = new Pen(Color.Black);
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pen, Location.X, Location.Y, Size.Width, Size.Height);
        }

    }

    public class TextShape : Shape
    {
        public Brush Brush { get; set; }
        public Font Font { get; set; }
        public string Text{ get; set; }
        public TextShape()
        {
            Brush = new SolidBrush(Color.DarkGreen);
            Font = new Font("Arial", 12, FontStyle.Regular);
        }
        public override void Draw(Graphics g)
        {
            g.DrawString(Text, Font, Brush, new RectangleF(Location.X, Location.Y, Size.Width, Size.Height));
        }

    }
    public class LinesShape : Shape
    {
        public Pen Pen { get; set; }
       
        public List<Point> Points { get; set; }
        public LinesShape()
        {
            Pen = new Pen(Color.GreenYellow);
            Points = new List<Point>();
        }
        public override void Draw(Graphics g)
        {
            g.DrawLines(Pen, Points.ToArray());
        }

    }


}
