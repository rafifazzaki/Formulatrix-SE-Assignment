//3 foo
// 5 bar
// User input => n
// n = 15
// 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar

using System.Text;
using InternalCalculationLib;
class Program
{
    static void Main()
    {
        ChangeToFooAndBar fb = new();

        string? answer;
        string? addRuleInt;
        string? addRuleString;

        string? input;
        bool isEnding = false;

        do
        {
            Console.WriteLine("Add rule?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No, Go to input");
            answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.WriteLine("=======================");
                    Console.WriteLine("Number to change:");
                    addRuleInt = Console.ReadLine();
                    Console.WriteLine("to string:");
                    addRuleString = Console.ReadLine();
                    int.TryParse(addRuleInt, out int output);
                    fb.AddRules(output, addRuleString);

                    break;
                case "2":
                    Console.WriteLine("=======================");
                    Console.WriteLine("Input number:");
                    input = Console.ReadLine();
                    string[] a = fb.Run(input); //return string[]
                    foreach (string number in a)
                    {
                        Console.WriteLine(number);
                    }
                    isEnding = true;
                    break;
                default:

                    break;
            }

        } while (!isEnding);




    }
}