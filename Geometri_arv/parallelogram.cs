using System;

namespace Geometri_arv
{
    class parallelogram : square
    {

        private double side_b;

        public double Side_b
        {
            get { return side_b; }
            set { side_b = value; }
        }

        private double angel;

        public double Angel
        {
            get { return angel; }
            set { angel = value; }
        }



        public parallelogram(double side_a, double side_b,double angel) :base(side_a)
        {
            this.side_b = side_b;
            this.side_a = side_a;
            this.angel = angel;

        }

        public override double calcArea()
        {
            

            double convertToRadian = (angel * (Math.PI)) / 180;

            double area = side_a * side_b * Math.Sin(convertToRadian);

            return area;
        }

        public override double calcPerimeter()
        {
            double perimeter = (2 * side_a) + (2 * side_b);
            return perimeter;
        }
    }
}