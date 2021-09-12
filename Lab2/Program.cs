using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unikal

            int eded = 12456;
            int n = eded;
            int m = eded;
            int count = 0;
            int unikalCount = 0;

            while (n > 0)
            {
                int qaliq = n % 10;
                m = eded;
                //count = 0;


                n /= 10;


                while (m > 0)
                {
                    int qaliq2 = m % 10;

                    if (qaliq == qaliq2)
                    {
                        count++;
                    }

                    m /= 10;
                }


                if (count == 1)
                {
                    unikalCount++;
                }

            }

            Console.WriteLine(unikalCount);

        }
        static int Toplama(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void Cixma(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void Vurma(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void Bolme(double a, double b)
        {
            double result = 0;


            if (b != 0)
            {
                result = a / b;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("ikinci eded sifir ola bilmez!");
            }
        }

        static void Calculate(int a, int b, char opp)
        {
            switch (opp)
            {
                case '+':
                    Toplama(a, b);
                    break;
                case '-':
                    Cixma(a, b);
                    break;
                case '*':
                    Vurma(a, b);
                    break;
                case '/':
                    Bolme(a, b);
                    break;

                default:
                    Console.WriteLine("Secdiyiniz emeliyyat yalnishdir!");
                    break;
            }
        }

        ///////////////////////
        // Ele bir method yazin ki,
        // methodun qebul etdiyi ededin reqemlerinin sayini tapib geriye qaytarsin.

        static void FindDigitCount(int a)
        {
            int count = 0;

            //heablama
            while (a > 0)
            {
                a /= 10;
                // a = a / 10;

                count++;

            }
            Console.WriteLine(count);

        }

        /// 7 * 10000 + 12345= 70000 + 12345 = 82345 *10 + 8
        /// 
        
        static int DigitCount (int a)
        {
            //0

            int eded = a;
            int step = 0;
            int b = 1;
            while (a>0)
            {
                a = a / 10; // 0
                step++; //3
                b = b * 10; // 1000
            }

            
            // 7 * 1000 + 123 = 7123 * 10 + 8          
            int result = (7 * b + eded) * 10 + 8;

            return result;
        }

        
    }
}
