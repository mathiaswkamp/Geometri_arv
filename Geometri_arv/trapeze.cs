using System;

namespace Geometri_arv
{
    class trapeze : square
    {

        private double side_b;

        public double Side_b
        {
            get { return side_b; }
            set { side_b = value; }
        }

        private double side_c;

        public double Side_c
        {
            get { return side_c; }
            set { side_c = value; }
        }

        private double side_d;

        public double Side_d
        {
            get { return side_d; }
            set { side_d = value; }
        }


        public trapeze(double side_a, double side_b, double side_c, double side_d) :base (side_a)
        {
            this.side_b = side_b;
            this.side_c = side_c;
            this.side_d = side_d;
        }


        

        public override double calcPerimeter()
        {
            return base.calcPerimeter();
        }

        public override double calcArea()
        {
            double s_trapeze = (side_a + side_b - side_c + side_d) / 2;


            double h_trapeze = ( side_a - side_c) / 2 *
                               Math.Sqrt(s_trapeze * ((s_trapeze - side_a + side_c) * (s_trapeze - side_d)));

            double area = 0.5 * (side_a + side_c) * h_trapeze;
            return area;
        }
    }
}