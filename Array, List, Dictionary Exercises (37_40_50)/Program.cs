using System;
using System.Collections.Generic;

namespace Array__List__Dictionary_Exercises__37_40_50_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 36
            Console.WriteLine("Please enter a number.");
            int inputOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            int inputTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third number.");
            int inputThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a fourth number.");
            int inputFour = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a fifth number.");
            int inputFive = int.Parse(Console.ReadLine());
            int[] sumArray = { inputOne, inputTwo, inputThree, inputFour, inputFive };
            int sum = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
                sum += sumArray[i];
            }

            Console.WriteLine($"The sum your your numbers is {sum}.");

            //Exercise 40
            Console.WriteLine("Please enter a number.");
            double numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third number.");
            double numberThree = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a fourth number.");
            double numberFour = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a fifth number.");
            double numberFive = double.Parse(Console.ReadLine());
            List<double> medianList = new List<double> { numberOne, numberTwo, numberThree, numberFour, numberFive };
            double medianResult = FindMedian(medianList, medianList.Count);
            Console.WriteLine($"The median is {medianResult}.");
        }
        public static double FindMedian(List<double> a, int n)
        {
            a.Sort();

            if (n % 2 != 0)
            {
                return (double)a[n / 2];
            }

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        

            //Exercise 50
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                { "Admiral Ackbar", 86 },
                { "Anakin Skywalker", 46 },
                { "Boba Fett", 29 },
                { "Darth Maul", 44 },
                { "Han Solo", 66 },
                { "Jango Fett", 44 },
                { "Ben Solo", 30 },
                { "Luke Skywalker", 53 },
                { "Mace Windu", 53 },
                { "Wedge Antilles", 56 }
            };
            Console.WriteLine("Please enter a student's full name.");
            string nameInput = Console.ReadLine();
            if (students.ContainsKey(nameInput))
            {

                Console.WriteLine($"{nameInput} is {students[nameInput]} years old.");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameInput} is not a student here.");
            }

        }

        }
}
