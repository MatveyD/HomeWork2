using System;
using System.Collections.Generic;
using System.Linq;


namespace HomeWork2
{
    class Class1
    {
        public void ARMEDnDANEROUS()
        {
            Console.WriteLine("Два бандита");
            Console.WriteLine("Количество банок простреленных Ларри (1)");
            int bandit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество банок простреленных Гарри (2)");
            int bandit2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ларри (1) не прострелил " + (bandit2 - 1) + " банок");
            Console.WriteLine("Гарри (2) не прострелил " + (bandit1 - 1) + " банок");
            Console.WriteLine(" (!) Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }


        public void MAX()
        {
            Console.WriteLine("Максимум");
            Console.WriteLine("Введите количество тестов (не более 10)");
            int k = Convert.ToInt16(Console.ReadLine());
            if ((k > 0) && (k < 10))
            {
                int[] num = new int[k];
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine("Опыт #" + (j+1));
                    num[j] = Convert.ToInt32(Console.ReadLine());
                }

                int n = num.Max();
                    if (n != 0)
                    {
                        List<int> seq = new List<int>();
                        seq.Add(0);
                        seq.Add(1);
                        for (int i = 1; ; i++)
                        {
                            if (seq.Count <= n) seq.Add(seq[i]);
                            else break;
                            if (seq.Count <= n) seq.Add(seq[i] + seq[i + 1]);
                            else break;
                        }
                       for (int i=0; i< k; i++)
                       {
                        int Max = 0;
                        for (int j = 0; j <= num[i]; j++)
                            if (seq[j] > Max)
                                Max = seq[j];
                         Console.WriteLine("Опыт # "+ (i + 1) + "( " + num[i]+ " ) Ответ:  " + Max);

                        }
                    }
                    else Console.WriteLine("Ответ: 0");
                    Console.WriteLine(" (!) Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                
            }
         }       

        public void SUM()
        {
            Console.WriteLine("Cумма целых чисел от 1 до N" );
            Console.WriteLine("Введите целое N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (n > 0)
            {
                sum = n*(1 + n) / 2;
                Console.WriteLine("Сумма = " + sum);
            }
            if (n < 0)
            {
                sum = -(Math.Abs(n)*(1 + Math.Abs(n)) / 2) + 1;
                Console.WriteLine("Сумма = " + sum);
            }
            if (n == 0)
            {
                Console.WriteLine("Сумма = 1");
            }

            Console.WriteLine(" (!) Нажмите любую клавишу для продолжения");
            Console.ReadKey();

        }
    }
}
