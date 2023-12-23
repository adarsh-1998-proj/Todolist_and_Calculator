using System.ComponentModel;

Console.WriteLine("what do you want to do");
Console.WriteLine("[S]ee all todo");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");


//var result = Add(12, 15);
//Console.WriteLine("12 + 15 :" + result);

var userChoise = Console.ReadLine();
if (userChoise == "S")
{
    PrintSelectedOption("Selected option: see all todos");
}
else if (userChoise == "A")
{
    PrintSelectedOption("Selected option: Add a todo");
}
else if (userChoise == "R")
{
    PrintSelectedOption("Selected option: Remove a todo");

}
else
{
    PrintSelectedOption("Selected option: Exit");
}
Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}


//int Add(int a, int b)
//{ return a + b; }