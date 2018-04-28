using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTask1
{
    class Program
    {
        static List<int> numberList = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Example Logic Task 1");

            string a;

            while (true)
            {
                Console.Write("Amount: ");

                a = Console.ReadLine();

                if (!String.IsNullOrEmpty(a) && IsInteger(a))
                    break;
            }

            for (int i = 1; Convert.ToInt32(a) >= i; i++)
            {
                string b;
                
                while (true)
                {
                    Console.Write("Number " + i + ": ");

                    b = Console.ReadLine();

                    if (!String.IsNullOrEmpty(b) && IsInteger(b))
                        break;
                }

                numberList.Add(Convert.ToInt32(b));
            }

            Console.WriteLine("Complete!");

            Console.WriteLine("Greatest: " + numberList.Max());

            Console.WriteLine("Lowest: " + numberList.Min());

            Console.WriteLine("Average: " + numberList.Average());

            Console.WriteLine("Total: " + numberList.Sum());

            Console.WriteLine("Press any key to terminate.");

            numberList.Clear();

            Console.ReadKey();
        }

        static bool IsInteger(string s)
        {
            try
            {
                Int32.TryParse(s, out int r);

                if (r == 0)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
