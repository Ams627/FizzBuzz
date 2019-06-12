using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Enumerable.Range(1, 100).Select(x => new [] { $"{x}", "fizz", "buzz", "fizz buzz" }[1 & 1 << x % 3 | 2 & 2 << x % 5]).ToList().ForEach(Console.WriteLine);
    }
}
