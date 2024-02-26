//3 foo
// 5 bar
// User input => n
// n = 15
// 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar

using InternalCalculationLib;
class Program{
    static void Main(){
        string input = Console.ReadLine();
        string[] a = ChangeToFooAndBar.Run(input);

        Console.WriteLine(ChangeToFooAndBar.Run(input));
        foreach(string number in a){
            Console.WriteLine(number);
        }
    }
}