using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    public class Rat
    {
        public int numerator;
        public int denominator;

        public Rat(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        public Rat(int num): this(num, 1) { }

        public Rat(): this(1, 1) { }

        public override string ToString()
        {
            return $"{numerator} / {denominator}";
        }

        public double ToDouble()
        {
            return (double)numerator / denominator;
        }


        public static Rat operator *(Rat x, Rat y)
        {
            int N, D;
            N = x.numerator * y.numerator;
            D = x.denominator * y.denominator;

            Rat newR;
            newR = new Rat(N, D);

            return newR;
        }
        public static Rat operator *(int x, Rat y)
        {
            Rat XX = new Rat(x);
            return XX * y;
        }
        public static Rat operator *(Rat x, int y)
        {
            Rat yy = new Rat(y);
            return yy * x;
        }



        public static Rat operator +(Rat x, Rat y)
        {
            int N, D;

            N = x.numerator * y.denominator + y.numerator * x.denominator;
            D = x.denominator * y.denominator;
            Rat newR;
            newR = new Rat(N, D);

            return newR;
        }


        public Rat Simple_fraction()
        {
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var r1 = new Rat(a, b);
            var r2 = new Rat(4);

            Console.WriteLine();

        }
    }
}
