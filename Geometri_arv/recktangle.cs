namespace Geometri_arv
{
    class recktangle : square

    {
        private double side_b;

        public double Side_b
        {
            get { return side_b; }
            set { side_b = value; }
        }



        public recktangle(double side_a, double side_b) :base(side_a)
        {
            this.side_b = side_b;
            this.side_a = side_a;
        }

        public override double calcPerimeter()
        {
            double perimeter = 2 * (side_a + side_b);
            return perimeter;
        }

        public override double calcArea()
        {
            double area = side_a * side_b;
            return area;
        }
       

        


    }
}