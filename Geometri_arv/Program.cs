using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            square square1 = new square(4);
            Console.WriteLine("the perimeter of a square with a = 4 is :{0} The area of the square is :{1}",
                square1.calcPerimeter(), square1.calcArea());
            square square2 = new square(8);
            Console.WriteLine("the perimeter of a square with a = 8 is :{0} The area of the square is :{1}",
                square2.calcPerimeter(), square2.calcArea());

            recktangle reckt1 = new recktangle(10,20);
            Console.WriteLine(
                "the perimeter of a recktangle with a = 10 and b = 20 is = {0} The area of the rectangle is :{1}",
                reckt1.calcPerimeter(), reckt1.calcArea());

            parallelogram paralell1 = new parallelogram(3,5,20);
            Console.WriteLine("the perimeter of paralellogram with a = 3, b = 5 and angel = 20 is = {0} and the area of the parallelogram = {1}",paralell1.calcPerimeter(),paralell1.calcArea());

            trapeze trapeze1 = new trapeze(10,9,8,9);
            Console.WriteLine("the area of the trapeze with a = 10, b = 9, c = 8, d = 9 is = {0}",trapeze1.calcArea());

            right_angled_Triangle rightAngledTriangle1 = new right_angled_Triangle(5,7);
            Console.WriteLine("the perimeter of right angled triangle with a = 5, b = 7  is = {0} and the area  = {1}", rightAngledTriangle1.calcPerimeter(), rightAngledTriangle1.calcArea());


            List<square> shapes = new List<square>()
            {
                square1,
                reckt1,
                paralell1,
                trapeze1,
                rightAngledTriangle1

            };

            foreach (var Shapes in shapes)
            {
                square1.calcArea();
                square1.calcPerimeter();
               

            }


        }
    }
}
