using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphics
{
    public partial class MainForm : Form
    {
        private List<Shape> _shapes;
        public MainForm()
        {
            
            InitializeComponent();
            _shapes = new List<Shape>();
            CreateShapes();

        }
        private void CreateShapes()
        {
            _shapes.Add(new RectangleShape()
            {
                Pen = new Pen(Color.Yellow, 5),
                Location = new Point(80, 120),
                Size = new Size(60, 40)
            });
            _shapes.Add(new RectangleShape()
            {
                Pen = new Pen(Color.Blue, 4),
                Location = new Point(70, 50),
                Size = new Size(60, 40)
            });
            _shapes.Add(new EllipseShape()
            {
                Pen = new Pen(Color.Green, 2),
                Location = new Point(170, 150),
                Size = new Size(60, 40)
            });
            _shapes.Add(new TextShape()
            {
                Location = new Point(250, 20),
                Text = "See on meie tekst",
                
            });

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGraphics();

        }
        private void RefreshGraphics()
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                foreach (var shape in _shapes)
                {
                    shape.Draw(g);
                    //if (shape is RectangleShape)
                    //{
                    //    var rect = shape as RectangleShape;
                    //    g.DrawRectangle(rect.Pen,
                    //        rect.Location.X, rect.Location.Y,
                    //        rect.Size.Width, rect.Size.Height);
                    //}
                    //else if (shape is EllipseShape)
                    //{
                    //    var ellipse = shape as EllipseShape;
                    //    g.DrawEllipse(ellipse.Pen,
                    //    ellipse.Location.X, ellipse.Location.Y,
                    //    ellipse.Size.Width, ellipse.Size.Height);
                    //}
                }
                
            }
        }
    }
}
