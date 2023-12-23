
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Input the first number:");
        string firstNumber = Console.ReadLine();
        int number = int.Parse(firstNumber);
        Console.WriteLine("Input the second number:");
        string secondNumber = Console.ReadLine();
        int number2 = int.Parse(firstNumber);
        Console.WriteLine("What do you want to do with those numbers?");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubtract");
        Console.WriteLine("[M]ultiply");



        var userChoise = Console.ReadLine();
        if (userChoise == "A")
        {
            var addition = number + number2;
            Console.WriteLine(firstNumber + "+" + secondNumber + "=" + addition);
        }
        void PrintSelectedOption(string selectedOption)
        {
            Console.WriteLine("Selected option: " + selectedOption);
        }
    }
}