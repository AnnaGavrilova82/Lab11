using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            Root root= new Root();
            Console.WriteLine ("Введите значение К  ");
            root.K = Console.ReadLine(); 
            Console.Write("Введите значение B  ");
            root.B = Console.ReadLine();
            root.Result();
            Console.ReadKey();
        }

        struct Root
        {
            public double k;
            public double b;
            double result;

            public string K
            {
                set
                {
                    if (Convert.ToDouble(value).GetType() == typeof(double))
                    {
                        k = Convert.ToDouble(value);
                        Console.WriteLine(k);
                    }
                    else
                    {
                        Console.WriteLine("Не верный тип данных");

                    }
                }
                get
                {
                    return k;
                }
            }
            public string B
            {
                set
                {
                    if (Convert.ToDouble(value).GetType() == typeof(double))
                    {
                        b = Convert.ToDouble(value);
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine("Не верный тип данных");

                    }
                }
                get
                {
                    return b;
                }
            }

            public Root()
            {
                result = (-b) / k;
            }
            public void Result()
            {
                Console.WriteLine("Значение X: {0}", result);
            }
        } 
    }
}
