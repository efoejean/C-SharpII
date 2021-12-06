using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        //public delegate bool IsTest(int num);

        static void Main(string[] args)
        {


            int num = 5;
            Console.WriteLine($"Is {num} over 5?: {IsOver5(num)}");
            Console.WriteLine($"Is {num} over 5?: {IsEven(num)}");
            Console.WriteLine($"Is {num} over 5?: {IsOdd(num)}");


            int[] numbers = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            DisplayList("All numbers:", numbers);

            // implicty typed expression lambdas
            DisplayList("Even Numbers: ", Filter(numbers, n => n % 2 == 0));
            DisplayList("Odd Numbers: ", Filter(numbers, n => n % 2 == 1));
            DisplayList("Numbers Over5 : ", Filter(numbers, n => n > 5));

            //multipe statment lambda
            DisplayList("Numbers Over 5 : ", Filter(numbers, n => { bool x = n > 5; return x; }));

            // single statement lambda
            DisplayList("Numbers Over 5 : ", Filter(numbers, n => { return  n > 5; }));

            // explicity type expression lambda
            DisplayList("Numbers Over 5 : ", Filter(numbers, (int n ) =>  n > 5));


            var filtered = numbers.Where(n => n > 4);
            DisplayList("Filtered over 4 using LINQ method syntax: ", filtered);

            var ordered = numbers.OrderBy(n => n);
            DisplayList("Ordered using LINQ method syntax:", ordered);

            var selected = numbers.Select(n => n* 2);
            DisplayList("Double using LinQ methods  syntax:", selected);

            var orderedDescending = numbers.OrderByDescending(n => n);
            DisplayList("ordered Descending using LinQ methods  syntax:", orderedDescending);

            Console.WriteLine($"sum using LINQ Method: {numbers.Sum()}");

            Console.WriteLine($"sum  number that greater than 4 using LINQ Method: {numbers.Where(n => n > 4).Sum()}");

            Console.WriteLine($"double the sum using LINQ Method: {numbers.Sum( n => n * 2)}");

            Console.WriteLine($"count over using LINQ method: {numbers.Where(n => n > 4).Count()}");
            Console.WriteLine($"count over using LINQ method: {numbers.Count(n => n > 4)}");

            DisplayList("Over 4, double, reverse order: ",
                numbers.Where(n => n > 4)
                .Select(n => n * 2)
                .OrderByDescending(n => n)
                .Distinct());
                




            // methods
            List<int> Filter(int[] intArray, Func<int, bool> test)
            {
                var result = new List<int>();

                foreach (int item in intArray)
                {
                    if (test(item))
                    {
                        result.Add(item);
                    }
                }

                return result;
            }

            //List<int> FilterOdd(int[] intArray)
            //{
            //    var result = new List<int>();

            //    foreach (int item in intArray)
            //    {
            //        if (IsOdd(item))
            //        {
            //            result.Add(item);
            //        }
            //    }

            //    return result;
            //}




            //List<int> FilterEven(int[] intArray)
            //{
            //    var result = new List<int>();

            //    foreach (int item in intArray)
            //    {
            //        if (IsEven(item))
            //        {
            //            result.Add(item);
            //        }
            //    }

            //    return result;
            //}

            void DisplayList(string description, IEnumerable<int> list)
            {
                Console.Write(description);
                foreach (var item in list)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
           
            bool IsOver5(int n) => n > 5;
            bool IsEven(int n) => n % 2 == 0;
            bool IsOdd(int n) => n % 2 == 1;


            Console.ReadKey();
        }
    }
}
