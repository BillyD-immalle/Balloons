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

        private int f = 10;



        Ellipse ellipse = new Ellipse();
        TextBlock text = new TextBlock();
        Brush bgBrush = new LinearGradientBrush(Colors.Red, Colors.Black, 90);

        static Random rndGen = new Random();
        

        public Balloon(Canvas canvas)
        {
            
            diameter = rndGen.Next(10, 50);
            x = rndGen.Next(5, 2000);
            y = rndGen.Next(5, 2000);



            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter)
        {
            this.diameter = diameter;
            x = rndGen.Next(5, 2000);
            y = rndGen.Next(5, 2000);

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, int height)
        {
            this.diameter = diameter;
            x = rndGen.Next(5, 2000);
            y = rndGen.Next(5, 2000);

            UpdateEllipse(canvas);
        }

        void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            ellipse.StrokeThickness = 2;
            ellipse.Fill = bgBrush;

            text.Text = "cirkel";
            text.Margin = new Thickness(x+diameter/4, y + diameter / 4, 0, 0);
            text.Foreground = new SolidColorBrush(Colors.Black);
            text.FontFamily = new FontFamily("Bauhaus 93");
            text.FontSize = 1;

            canvas.Children.Add(ellipse);
            canvas.Children.Add(text);
        }
         

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;

            text.Width = diameter / 2;
            text.Height = diameter / 2;
            text.Margin = new Thickness(x + diameter / 4, y + diameter / 4, 0, 0);
            text.FontSize = f+10;

        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);

            text.Margin = new Thickness(x + diameter / 4, y + diameter / 4, 0, 0);
        }

    }
}
