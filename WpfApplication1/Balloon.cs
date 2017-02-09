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

    public class Balloon
    {
        private int x = 10;
        private int y = 100;
        private int diameter = 10;

        Ellipse ellipse = new Ellipse();
        TextBlock text = new TextBlock();

        static Random rndGen = new Random();
        

        public Balloon(Canvas canvas)
        {
            
            diameter = rndGen.Next(10, 30);
            x = rndGen.Next(10, 2000);
            y = rndGen.Next(10, 2000);



            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter)
        {
            this.diameter = diameter;
            x = rndGen.Next(10, 2000);
            y = rndGen.Next(10, 2000);

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, int height)
        {
            this.diameter = diameter;
            x = rndGen.Next(10, 2000);
            y = rndGen.Next(10, 2000);

            UpdateEllipse(canvas);
        }

        void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.StrokeThickness = 1;
            ellipse.Fill = new SolidColorBrush(Colors.White);

            text.Text = "Ik ben een cirkel";
            text.Margin = new Thickness(x, y, 100, 50);

            canvas.Children.Add(ellipse);
            canvas.Children.Add(text);
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;

            text.Width = diameter;
            text.Height = diameter;
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);

            text.Margin = new Thickness(x, y, 0, 0);
        }

    }
}
