using System;

namespace MethodsExercise
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(10, 2);



            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine(); 

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine(); 

            Console.WriteLine($"{color} COOL! What is your favorite animal?");
            var animal = Console.ReadLine(); 

            Console.WriteLine("Great! What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("--------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");



        }
    }
}



