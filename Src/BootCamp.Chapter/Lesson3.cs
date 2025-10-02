using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
    {    
        public static void Demo()
        {
            for (int i = 1; i <= 2; i++)
            {
                // Name and surname input
                string name = getNameFromInput("Enter your name:");
                string surname = getNameFromInput("Enter your surname:");

                // Age input
                int age = getAgeFromInput("Enter your age:");

                // Weight and height input
                float weight = getFloatFromInput("Enter your weight in kg:");
                float height = getFloatFromInput("Enter your height in cm");

                float BMI = CalculateBMI(weight, height);

                Console.WriteLine(name + " " + surname + " is " + age +
                    " years old, his/her weight is " + weight + " and his/her height is " + height + " cm.");
                Console.WriteLine("His/her BMI is " + BMI + ".");
            }
        }

        public static string getNameFromInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int getAgeFromInput(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float getFloatFromInput(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
