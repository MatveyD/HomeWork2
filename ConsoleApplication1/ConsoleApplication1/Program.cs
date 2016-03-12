using System;


namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 solusion = new Class1();

            Console.WriteLine("(1) Два бандита");

            Console.WriteLine("(2) Максимум");

            Console.WriteLine("(3) Сумма");

            int getch = Convert.ToInt32(Console.ReadLine());
            while (getch < 4 && getch > 0)
            {

                switch (getch)
                {
                    case 1: solusion.ARMEDnDANEROUS(); break;
                    case 2: solusion.MAX(); break;
                    case 3: solusion.SUM(); break;
                }
                Console.Clear();
                Console.WriteLine("(1) Два бандита");
                Console.WriteLine("(2) Максимум");
                Console.WriteLine("(3) Сумма");
                getch = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
