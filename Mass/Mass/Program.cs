using System.Runtime.InteropServices;
//Вычисление индекса массы тела

internal class program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите вес");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост (x,xx см)");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            double q = 16;
            double w = 18.5;
            double e = 25;
            double r = 30;
            double t = 35;
            double y = 40;
            Console.WriteLine("ваш индекс массы тела");
            Console.WriteLine(c = (a / Math.Pow(b, 2)));

            if (c <= q)
            {
                Console.WriteLine("У вас Выраженный дефицит массы тела");
            }
            if (c > q && c < w)
            {
                Console.WriteLine("У вас Недостаточная масса тела (дефицит)");
            }
            {
                if (c > w && c < e)
                {
                    Console.WriteLine("У вас  Норма");
                }
                if (c > e && c < r)
                {
                    Console.WriteLine("Избыточная масса тела (состояние, предшествующее ожирению)");
                }
                if (c > r && c < t)
                {
                    Console.WriteLine("У вас  Ожирение 1-й степени");
                }
                if (c > t && c < y)
                {
                    Console.WriteLine("У вас  Ожирение 2-й степени");
                }
                if (c > y)
                {
                    Console.WriteLine("У вас  Ожирение 3-й степени");
                }

                Console.WriteLine();

            }


        }
    }
}