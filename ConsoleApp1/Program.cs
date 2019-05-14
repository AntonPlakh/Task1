using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Program
    {
        const double PI = 3.14;

        static void Main(string[] args)
        {

            double circleSquare;
            double squareSquare;


            Console.WriteLine("Type сircle radius");
            String r = Console.ReadLine();
            double radius = Convert.ToDouble(r);

            Console.WriteLine("Type square height");
            String h = Console.ReadLine();
            double height = Convert.ToDouble(h);



            Calculations (radius, height, out circleSquare, out squareSquare);
           bool isCircleInSquare = IsCircleInSquare(circleSquare, squareSquare);
           bool isSquareInCircle = IsSquareInCircle(circleSquare, squareSquare);

            Console.WriteLine("CircleSquare = {0} and SquareSquare = {1}", circleSquare, squareSquare);
            Console.WriteLine("is it possible to fit a circle in a square - {0}", isCircleInSquare);
            Console.WriteLine("is it possible to fit a square in a circle - {0}", isSquareInCircle);

        }

        //высчитываем площади фигур
        static void Calculations ( double r,  double h, out double circleSquare, out double squareSquare)
        {
             circleSquare = PI * Math.Pow(r, 2);
             squareSquare = Math.Pow(h, 2);
        }

        // возвращает влазит ли круг в квадрат
        static Boolean IsCircleInSquare (double circleSquare, double squareSquare)
        {
            return (Math.Pow((circleSquare / PI), 0.5) <= 0.5 * (Math.Pow((squareSquare), 0.5)));             
        }

        // возвращает влазит ли квадрат в круг
        static Boolean IsSquareInCircle (double circleSquare, double squareSquare)
        {
            return (Math.Pow((circleSquare / PI), 0.5) >= 0.5 * (Math.Pow((2*squareSquare), 0.5)));
        }
    }
}
