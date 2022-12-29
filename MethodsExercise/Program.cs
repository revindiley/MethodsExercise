using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine("Whats your favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine("Whats your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Whats your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What state do you live in?");
            var userState = Console.ReadLine();

            Console.WriteLine($"There once was a person named {userName}, they were {userAge} years old.");
            Console.WriteLine($"They lived in the far off land of {userState} where they enjoyed spending time with their pet {animal}.");
            Console.WriteLine($"{userName}'s favorite food to prepare is their famous {color} {food}.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.WriteLine("Time to do some calculations!");

            Console.WriteLine("Enter in the first number you'd like to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your second number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);

            Console.WriteLine($"The sum is {sum}.");
            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();

            Console.WriteLine("Enter in the first number you'd like to multiply");
             num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your second number");
             num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is {product}");
            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();
            
            Console.WriteLine("Enter in the first number you'd like to divide");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your second number");
            num2 = int.Parse(Console.ReadLine());

            int division = Divide(num1, num2);
            Console.WriteLine($"The answer is {division}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            Console.WriteLine("Enter in the first number you'd like to subtract");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in your second number");
            num2 = int.Parse(Console.ReadLine());

            int difference = Subtract(num1, num2);
            Console.WriteLine($"The difference is {difference}");
            Console.WriteLine("Thanks for using the program!");
        }

        public static int Sum(int num1, int num2)    //"Sum" return type is "int" so "return" is needed 
        {
            int sum = num1 + num2;
            return sum;                             // could also have been written "return num1+num2"
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;

        }
        public static int Divide(int num1, int num2) 
        {
            return num1 / num2;
        }

    }
}
