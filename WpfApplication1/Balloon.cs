using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {

        private int x = 10;
        private int y = 10;
        private int diameter = 10;

        const int growAmount = 10;
        const int moveAmount = 10;

        Ellipse ellipse = new Ellipse();
        Brush strokeBrush = new LinearGradientBrush(Colors.Pink, Colors.Red, 90);
        Brush bgBrush = new LinearGradientBrush(Colors.Red, Colors.Pink, 90);

        private void UpdateBalloon()
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = strokeBrush;
            ellipse.Fill = bgBrush;
        }


        public Balloon(Canvas canvas, int diameter) : this(canvas, diameter, 10, 10)
        { }

        public Balloon(Canvas canvas, int diameter, int height, int xpos)
        {
            this.diameter = diameter;
            x = xpos;
            y = height;

            UpdateBalloon();
            canvas.Children.Add(ellipse);
        }

        public void Grow()
        {
            diameter += growAmount;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void Move()
        {
            y -= moveAmount;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public Brush Background
        {
            get
            {
                return bgBrush;
            }
            set
            {
                bgBrush = value;
                UpdateBalloon();
            }
        }
    }
}
