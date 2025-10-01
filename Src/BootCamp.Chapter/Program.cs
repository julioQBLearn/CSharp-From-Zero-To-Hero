using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Write your name, user # " + i + ":");
                string name = Console.ReadLine();

                Console.WriteLine("Write your Surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your weight in kg:");
                double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Enter your height in cm:");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double BMI = weight / Math.Pow(height / 100, 2);

                Console.WriteLine(name + " " + surname + " is " + age +
                    " years old, his/her weight is " + weight + " and his/her height is " + height + " cm.");
                Console.WriteLine("His/her BMI is " + BMI + ".");
            }
        }
    }
}
