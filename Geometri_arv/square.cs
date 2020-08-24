using System;

namespace Geometri_arv
{
    public class square
    {
		protected double side_a;

        // opgave B
		public double Side_a
		{
			get { return side_a; }
			set { side_a = value; }
		}



        public square(double a)
        {
            this.side_a = a;
            
        }
        public virtual double calcPerimeter()
        {
            double perimeter = Math.Pow(side_a,2);
            return perimeter;
        }

        public virtual double calcArea()
        {
            double area = side_a * 4;
            return area;
        }
	}
}