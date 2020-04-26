using System;

namespace Average_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is an average calculator");

            int num1, num2, num3, num4, average;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter secound number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fourd number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have enterd the numbers: " + num1 + " " + num2 + " " + num3 + " " + num4);

            average = (num1 + num2 + num3 + num4) / 4;
            

            Console.WriteLine("The average number of your 4 numbers are: " + average);
        }
    }
}
